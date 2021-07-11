using System;
using System.Windows.Forms;
using Logical;

namespace Minesweeper
{
    public partial class Game : Form
    {
        private Map _map;

        private int _time;

        private void Reset()
        {
            Timer.Stop();
            _time = 0;
            Time.Text = @"00.00";
            MinesQuantity.Text = _map.Mines.ToString();
            Board.Refresh();
        }

        public Game()
        {
            InitializeComponent();
            _map = new Map(9, 9, 10);
            Reset();
        }
        
        private void NewGameMenu_Click(object sender, EventArgs e)
        {
            _map = new Map(_map.Height, _map.Width, _map.Mines);
            Reset();
        }

        private void OptionsMenu_Click(object sender, EventArgs e)
        {
            var options = new Options(_map.Height, _map.Width, _map.Mines);
            options.ShowDialog();
            if (!options.Change)
                return;
            _map = new Map(options.Height, options.Width, options.Mines);
            Height = _map.Height*Dimensions + 130;
            Width = _map.Width*Dimensions + 40;
            CenterToScreen();
            Reset();
        }
        
        private void RecordsMenu_Click(object sender, EventArgs e)
        {
            new Records().ShowDialog();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void AboutMenu_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void TutorialMenu_Click(object sender, EventArgs e)
        {
            new Tutorial().ShowDialog();
        }

        private void Board_MouseClick(object sender, MouseEventArgs e)
        {
            Timer.Start();
            var x = e.Y/Dimensions;
            var y = e.X/Dimensions;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _map.LeftClick(x, y);
                    break;
                case MouseButtons.Right:
                    _map.RightClick(x, y);
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    return;
            }
            GameOver();
        }

        private static int Dimensions => 25;

        private void GameOver()
        {
            MinesQuantity.Text = (_map.Mines - _map.FlagsQuantity).ToString();
            Board.Refresh();
            if (!_map.GameOver)
                return;
            Timer.Stop();
            if (_map.Defeat)
                MessageBox.Show(@"You Lose!", @"Game Over");
            else
            {
                MessageBox.Show(@"You Win!", @"Congratulations");
                var level = "";
                switch (_map.Height)
                {
                    case 9 when _map.Width == 9 && _map.Mines == 10:
                        level = "Novice";
                        break;
                    case 16 when _map.Width == 16 && _map.Mines == 40:
                        level = "Intermediate";
                        break;
                    case 16 when _map.Width == 30 && _map.Mines == 99:
                        level = "Expert";
                        break;
                }
                if (Save.Save.Record(level, _time))
                    new Name(level, _time).ShowDialog();
            }                
        }

        private void Board_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var x = e.Y/Dimensions;
            var y = e.X/Dimensions;
            _map.DoubleClick(x, y);
            GameOver();
        }

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            for (var i = 0; i < _map.Height; i++)
                for (var j = 0; j < _map.Width; j++)
                {
                    if (_map[i, j].Value < 10)
                        g.DrawImage(Images.Empty, j*Dimensions, i*Dimensions, Dimensions, Dimensions);
                    else if (_map[i, j].Value < 20)
                        g.DrawImage(Images.Flag, j*Dimensions, i*Dimensions, Dimensions, Dimensions);
                    else if (_map[i, j].Value < 30)
                        g.DrawImage(Images.Doubt, j*Dimensions, i*Dimensions, Dimensions, Dimensions);
                    else
                        switch (_map[i, j].Value)
                        {
                            case 30:
                                g.DrawImage(Images._0, j * Dimensions, i * Dimensions, Dimensions, Dimensions);
                                break;
                            case 31:
                                g.DrawImage(Images._1, j * Dimensions, i * Dimensions, Dimensions, Dimensions);
                                break;
                            case 32:
                                g.DrawImage(Images._2, j * Dimensions, i * Dimensions, Dimensions, Dimensions);
                                break;
                            case 33:
                                g.DrawImage(Images._3, j * Dimensions, i * Dimensions, Dimensions, Dimensions);
                                break;
                            case 34:
                                g.DrawImage(Images._4, j * Dimensions, i * Dimensions, Dimensions, Dimensions);
                                break;
                            case 35:
                                g.DrawImage(Images._5, j * Dimensions, i * Dimensions, Dimensions, Dimensions);
                                break;
                            case 36:
                                g.DrawImage(Images._6, j * Dimensions, i * Dimensions, Dimensions, Dimensions);
                                break;
                            case 37:
                                g.DrawImage(Images._7, j * Dimensions, i * Dimensions, Dimensions, Dimensions);
                                break;
                            case 38:
                                g.DrawImage(Images._8, j * Dimensions, i * Dimensions, Dimensions, Dimensions);
                                break;
                            case 39:
                                g.DrawImage(Images.Mine, j * Dimensions, i * Dimensions, Dimensions, Dimensions);
                                break;
                            case 40:
                                g.DrawImage(Images.Incorrect, j*Dimensions, i*Dimensions, Dimensions, Dimensions);
                                break;
                            case 49:
                                g.DrawImage(Images.ActivatedMine, j*Dimensions, i*Dimensions, Dimensions, Dimensions);
                                break;
                        }
                }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_time == 99999)
                Timer.Stop();
            _time++;
            if (_time < 100)
                Time.Text = @"00." + _time;
            else if (_time < 1000)
                Time.Text = @"0" + _time.ToString()[0] + @"." + _time.ToString()[1] + _time.ToString()[2];
            else
            {
                var time = "";
                for (var i = 0; i < _time.ToString().Length - 2; i++)
                    time += _time.ToString()[i];
                time += @"." + _time.ToString()[_time.ToString().Length - 2] + _time.ToString()[_time.ToString().Length - 1];
                Time.Text = time;
            }
        }
    }
}
