using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACCDataReading.Services;
using SimDataReadingCore.Events;
using SteelSeriesGameEngine;

namespace SimDataReadingCore.ActiveGameData
{
    public class ActiveGameRelayingClient
    {
        private readonly GameSenseClient _client;
        private readonly ACCDataReader _accDataReader;

        public ActiveGameRelayingClient()
        {
            _client = new GameSenseClient();
            _accDataReader = new ACCDataReader();
            _accDataReader.GameStateUpdated += AccDataReader_GameStateUpdated;
        }

        public async Task Stop()
        {
            await _client.StopGame();
        }

        private async void AccDataReader_GameStateUpdated(object? sender, GameStateUpdateEventArgs e)
        {
            if (e.GameState == null || !e.GameState.IsGameRunning)
                return;

            await _client.SendFlagEventAsync(e.GameState.Flag);
        }
    }
}
