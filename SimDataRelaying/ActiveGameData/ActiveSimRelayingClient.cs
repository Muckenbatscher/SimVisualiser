using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCDataReading.Services;
using SimDataReadingCore.Enumerations;
using SimDataReadingCore.Events;
using SimDataReadingCore.ModelClasses;
using SteelSeriesGameEngine;

namespace SimDataReadingCore.ActiveGameData
{
    public class ActiveSimRelayingClient
    {
        public event EventHandler<ActiveSimChangedEventArgs>? ActiveSimChanged;
        private ActiveSimulator ActiveSim
        {
            get { return _activeSim; }
            set
            {
                bool valueChanges = _activeSim != value;
                _activeSim = value;
                if (valueChanges)
                {
                    var eventArgs = new ActiveSimChangedEventArgs(_activeSim);
                    ActiveSimChanged?.Invoke(this, eventArgs);
                }
            }
        }
        private ActiveSimulator _activeSim;


        private GameState? _latestGameState;


        private readonly GameSenseClient _client;
        private readonly ACCDataReader _accDataReader;

        public ActiveSimRelayingClient()
        {
            _client = new GameSenseClient();
            _accDataReader = new ACCDataReader();
            _accDataReader.GameStateUpdated += AccDataReader_GameStateUpdated;
        }

        public async Task Stop()
        {
            await _client.StopGame();
        }

        private async Task PropagateLatestGameState()
        {
            if (_latestGameState == null)
                return;

            await _client.SendFlagEventAsync(_latestGameState.Flag);
            await _client.SendDeltaEventAsync(_latestGameState.LapTimeDelta);
            await _client.SendTCEventAsync(_latestGameState.TCActive);
            await _client.SendABSEventAsync(_latestGameState.ABSActive);
        }

        private void SetNoneIfNotRunning(ActiveSimulator simToSet, bool running)
        {
            if (ActiveSim == simToSet && !running)
                ActiveSim = ActiveSimulator.None;
            else
                ActiveSim = simToSet;
        }

        private async void AccDataReader_GameStateUpdated(object? sender, GameStateUpdateEventArgs e)
        {
            if (e.GameState == null || !e.GameState.IsGameRunning)
                return;

            SetNoneIfNotRunning(ActiveSimulator.AssettoCorsaCompetizione, e.GameState.IsGameRunning);

            _latestGameState = e.GameState;
            await PropagateLatestGameState();
        }
    }
}
