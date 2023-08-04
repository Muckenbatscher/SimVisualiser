using ACCDataReading.Services;
using SimDataReadingCore.Enumerations;
using SimDataReadingCore.Events;
using SteelSeriesGameEngine;
using System.Windows.Forms;

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

            await _client.SendFlagEventAsync(e.GameState.Flag);
        }

        private async void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            await _client.StopGame();
        }


        private async void BT_CLEAR_Click(object sender, EventArgs e)
        {
            await _client.SendFlagEventAsync(Flag.None);
        }
        private async void BT_BLUE_Click(object sender, EventArgs e)
        {
            await _client.SendFlagEventAsync(Flag.BlueFlag);
        }
        private async void BT_YELLOW_Click(object sender, EventArgs e)
        {
            await _client.SendFlagEventAsync(Flag.YellowFlag);
        }
        private async void BT_WHITE_Click(object sender, EventArgs e)
        {
            await _client.SendFlagEventAsync(Flag.WhiteFlag);
        }
        private async void BT_GREEN_Click(object sender, EventArgs e)
        {
            await _client.SendFlagEventAsync(Flag.GreenFlag);
        }
        private async void BT_ORANGE_Click(object sender, EventArgs e)
        {
            await _client.SendFlagEventAsync(Flag.OrangeFlag);
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                TrayIcon.Visible = true;
            }
        }
        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            TrayIcon.Visible = false;
        }

    }
}