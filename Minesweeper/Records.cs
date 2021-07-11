using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
            Data();
        }

        public void Data()
        {
            var data = Save.Save.Data();
            NoviceNameRecord.Text = data[0];
            NoviceRecord.Text = data[1];
            IntermediateNameRecord.Text = data[2];
            IntermediateRecord.Text = data[3];
            ExpertNameRecord.Text = data[4];
            ExpertRecord.Text = data[5];
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            new Reset().ShowDialog();
            Data();
        }
    }
}
