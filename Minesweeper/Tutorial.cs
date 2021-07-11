using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Tutorial : Form
    {
        private int _count;

        public Tutorial()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            _count++;
            switch (_count)
            {
                case 1:
                    Description.Visible = false;
                    Events.Visible = true;
                    Back.Text = @"Back";
                    break;
                case 2:
                    Events.Visible = false;
                    GameOver.Visible = true;
                    Next.Text = @"Exit";
                    break;
                case 3:
                    Close();
                    break;
                default:
                    return;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            _count--;
            switch (_count)
            {
                case -1:
                    Close();
                    break;
                case 0:
                    Events.Visible = false;
                    Description.Visible = true;
                    Back.Text = @"Exit";
                    break;
                case 1:
                    GameOver.Visible = false;
                    Events.Visible = true;
                    Next.Text = @"Next";
                    break;
                default:
                    return;
            }
        }
    }
}
