using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Options : Form
    {
        public new int Height { get; private set; }

        public new int Width { get; private set; }

        public int Mines { get; private set; }


        public bool Change { get; private set; }


        public Options(int height, int width, int mines)
        {
            InitializeComponent();
            Height = height;
            Width = width;
            Mines = mines;
        }

        private void Custom_CheckedChanged(object sender, EventArgs e)
        {
            if (!HeightSelector.Enabled)
            {
                HeightSelector.Enabled = true;
                WidthSelector.Enabled = true;
                MinesSelector.Enabled = true;
                HeightNumber.Enabled = true;
                WidthNumber.Enabled = true;
                MinesNumber.Enabled = true;
            }
            else
            {
                HeightSelector.Enabled = false;
                WidthSelector.Enabled = false;
                MinesSelector.Enabled = false;
                HeightNumber.Enabled = false;
                WidthNumber.Enabled = false;
                MinesNumber.Enabled = false;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Selector();
            Change = true;
            Close();
        }

        public void Selector()
        {
            if (Novice.Checked)
            {
                Height = Width = 9;
                Mines = 10;
            }
            else if (Intermediate.Checked)
            {
                Height = Width = 16;
                Mines = 40;
            }
            else if (Expert.Checked)
            {
                Height = 16;
                Width = 30;
                Mines = 99;
            }
            else
            {
                Height = int.Parse(HeightNumber.Text);
                Width = int.Parse(WidthNumber.Text);
                Mines = int.Parse(MinesNumber.Text);
                if (Mines > (Height - 1)*(Width - 1))
                    Mines = (Height - 1)*(Width - 1);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
