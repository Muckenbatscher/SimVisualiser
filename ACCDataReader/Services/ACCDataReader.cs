using ACCDataReader.MemoryStructs;
using ACCDataReader.Services.Mapping;
using SharedMemoryReader.Services;
using SimDataReadingCore.Events;
using SimDataReadingCore.ModelClasses;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ACCDataReader.Services
{
    public class ACCDataReader : SimDataReader
    {
        private Timer _physicsTimer, _graphicsTImer, _staticTimer;
        private Timer _mainTimer;

        private SharedMemoryReader<Physics> _physicsReader;
        private SharedMemoryReader<Graphics> _graphicsReader;
        private SharedMemoryReader<Statics> _staticsReader;

        private Physics? _latestPhysics;
        private Graphics? _latestGraphics;
        private Statics? _latestStatics;

        public ACCDataReader()
        {
            _physicsReader = new SharedMemoryReader<Physics>(@"Local\acpmf_physics");
            _graphicsReader = new SharedMemoryReader<Graphics>(@"Local\acpmf_graphics");
            _staticsReader = new SharedMemoryReader<Statics>(@"Local\acpmf_static");

            _physicsTimer = new Timer(10);
            _physicsTimer.AutoReset = true;
            _physicsTimer.Elapsed += PhysicsTimer_Elapsed;

            _graphicsTImer = new Timer(100);
            _physicsTimer.AutoReset = true;
            _physicsTimer.Elapsed += GraphicsTimer_Elapsed;

            _staticTimer = new Timer(1000);
            _physicsTimer.AutoReset = true;
            _physicsTimer.Elapsed += StaticsTimer_Elapsed;

            _mainTimer = new Timer(50);
            _physicsTimer.AutoReset = true;
            _physicsTimer.Elapsed += MainTimer_Elapsed;
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
