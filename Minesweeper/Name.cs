using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Name : Form
    {
        private readonly string _level;
        private readonly int _time;

        public Name(string level, int time)
        {
            InitializeComponent();
            _level = level;
            _time = time;
            label1.Text = @"Congratulations! You have the best time in the " + _level + @" level.";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
            var name = Name_Box.Text;
            Save.Save.Serialize(name, _level, _time);
            var records = new Records();
            records.ShowDialog();
        }
    }
}
