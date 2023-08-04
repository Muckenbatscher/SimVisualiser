using ACCDataReading.Services;
using SimDataReadingCore.Enumerations;
using SimDataReadingCore.Events;
using SteelSeriesGameEngine;

namespace SimVisualiser
{
    public partial class MainWindow : Form
    {

        private GameSenseClient _client;
        private ACCDataReader _accDataReader;

        public MainWindow()
        {
            InitializeComponent();

            _client = new GameSenseClient();
            _accDataReader = new ACCDataReader();
            _accDataReader.GameStateUpdated += AccDataReader_GameStateUpdated;
        }

        private async void AccDataReader_GameStateUpdated(object? sender, GameStateUpdateEventArgs e)
        {
            if (e.GameState == null)
                return;

            switch (e.GameState.Flag)
            {
                case Flag.YellowFlag:
                    await _client.SendYellowFlagEventAsync();
                    break;
                case Flag.BlueFlag:
                    await _client.SendBlueFlagEventAsync();
                    break;
                case Flag.GreenFlag:
                    await _client.SendGreenFlagEventAsync();
                    break;
                case Flag.WhiteFlag:
                case Flag.CheckeredFlag:
                    await _client.SendWhiteFlagEventAsync();
                    break;
                case Flag.OrangeFlag:
                    await _client.SendYellowFlagEventAsync();
                    break;
                default:
                    await _client.ClearFlagEventAsync();
                    break;
            }
        }

        private async void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            await _client.StopGame();
        }


        private async void BT_CLEAR_Click(object sender, EventArgs e)
        {
            await _client.ClearFlagEventAsync();
        }
        private async void BT_BLUE_Click(object sender, EventArgs e)
        {
            await _client.SendBlueFlagEventAsync();
        }
        private async void BT_YELLOW_Click(object sender, EventArgs e)
        {
            await _client.SendYellowFlagEventAsync();
        }
        private async void BT_WHITE_Click(object sender, EventArgs e)
        {
            await _client.SendWhiteFlagEventAsync();
        }
        private async void BT_GREEN_Click(object sender, EventArgs e)
        {
            await _client.SendGreenFlagEventAsync();
        }
        private async void BT_ORANGE_Click(object sender, EventArgs e)
        {
            await _client.SendOrangeFlagEventAsync();
        }
    }
}