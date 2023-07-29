using SteelSeriesGameEngine;

namespace SimVisualiser
{
    public partial class MainWindow : Form
    {

        private GameSenseClient _client;

        public MainWindow()
        {
            InitializeComponent();

            _client = new GameSenseClient();
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