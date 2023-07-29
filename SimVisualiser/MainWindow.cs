using SteelSeriesGameEngine;

namespace SimVisualiser
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            var a = new GameSenseClient();
        }
    }
}