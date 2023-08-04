using ACCDataReading.MemoryStructs;
using ACCDataReading.Services.Mapping;
using SharedMemoryReader.Services;
using SimDataReadingCore.Events;
using SimDataReadingCore.ModelClasses;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ACCDataReading.Services
{
    public class ACCDataReader : SimDataReader
    {
        private Timer _physicsTimer, _graphicsTimer, _staticTimer;
        private Timer _mainTimer;

        private SharedMemoryReader<Physics> _physicsReader;
        private SharedMemoryReader<Graphics> _graphicsReader;
        private SharedMemoryReader<Statics> _staticsReader;

        private Physics? _latestPhysics;
        private Graphics? _latestGraphics;
        private Statics? _latestStatics;

        public ACCDataReader()
        {
            SetUpMemoryReaders();
            SetUpTimers();
        }

        private void SetUpMemoryReaders()
        {
            _physicsReader = new SharedMemoryReader<Physics>(@"Local\acpmf_physics");
            _graphicsReader = new SharedMemoryReader<Graphics>(@"Local\acpmf_graphics");
            _staticsReader = new SharedMemoryReader<Statics>(@"Local\acpmf_static");
        }
        private void SetUpTimers()
        {
            _physicsTimer = new Timer(10);
            _physicsTimer.AutoReset = true;
            _physicsTimer.Elapsed += PhysicsTimer_Elapsed;

            _graphicsTimer = new Timer(100);
            _graphicsTimer.AutoReset = true;
            _graphicsTimer.Elapsed += GraphicsTimer_Elapsed;

            _staticTimer = new Timer(1000);
            _staticTimer.AutoReset = true;
            _staticTimer.Elapsed += StaticsTimer_Elapsed;

            _mainTimer = new Timer(50);
            _mainTimer.AutoReset = true;
            _mainTimer.Elapsed += MainTimer_Elapsed;

            StartTimers();
        }
        private void StartTimers()
        {
            _physicsTimer.Start();
            _graphicsTimer.Start();
            _staticTimer.Start();
            _mainTimer.Start();
        }

        private void PhysicsTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _latestPhysics = _physicsReader.ReadSharedMemory();
        }
        private void GraphicsTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _latestGraphics = _graphicsReader.ReadSharedMemory();
        }
        private void StaticsTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _latestStatics = _staticsReader.ReadSharedMemory();
        }
        private void MainTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var gameState = CreateGameState();
            if (gameState != null)
            {
                base.OnGameStateChange(new GameStateUpdateEventArgs(gameState));
            }
        }

        private GameState CreateGameState()
        {
            if (_latestStatics == null && _latestPhysics == null && _latestGraphics == null)
                return null;

            var state = new GameState();
            state.AddStaticsInfo(_latestStatics);
            state.AddGraphicsInfo(_latestGraphics);
            state.AddPhysicsInfo(_latestPhysics);
            return state;
        }
    }
}
