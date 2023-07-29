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

        private async void button1_Click(object sender, EventArgs e)
        {
            await _client.SendYellowFlagEventAsync();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await _client.SendBlueFlagEventAsync();
        }

        private async void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            await _client.StopGame();
        }
    }
}