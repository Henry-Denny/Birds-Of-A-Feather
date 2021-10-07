using System;
using System.Windows.Forms;

namespace Birds_Of_A_Feather
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void BtnStartSimulation_Click(object sender, EventArgs e)
        {
            Simulation simulation = new Simulation();
            simulation.FormClosed += (s, args) => Close();
            Hide();
            simulation.Show();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
