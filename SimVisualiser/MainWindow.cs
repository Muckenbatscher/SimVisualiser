using ACCDataReading.Services;
using SimDataReadingCore.ActiveGameData;
using SimDataReadingCore.Enumerations;
using SimDataReadingCore.Events;
using SteelSeriesGameEngine;
using System.Windows.Forms;

namespace SimVisualiser
{
    public partial class MainWindow : Form
    {

        private readonly ActiveSimRelayingClient _client;

        public MainWindow()
        {
            InitializeComponent();

            _client = new ActiveSimRelayingClient();
        }

        private async void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            await _client.Stop();
        }


        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                TrayIcon.Visible = true;
            }
        }
        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

    }
}