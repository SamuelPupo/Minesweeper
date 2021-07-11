using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Reset : Form
    {
        public Reset()
        {
            InitializeComponent();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            if (All.Checked)
                Save.Save.Reset("All");
            else if (Novice.Checked)
                Save.Save.Reset("Novice");
            else if (Intermediate.Checked)
                Save.Save.Reset("Intermediate");
            else if (Expert.Checked)
                Save.Save.Reset("Expert");
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
