using System.Windows.Forms;

namespace Minesweeper
{
    internal partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            Text = @"About";
            Game.Text = @"Minesweeper";
            By.Text = @"By: Samuel Efraín Pupo Wong";
            Location.Text = @"Made in Cuba";
            Year.Text = @"2017";
            Description.Text = @" The game consists of clearing all the cells that do not hide a mine.
 Some cells have a number, which indicates the number of mines in the surrounding cells. 
 In this way, if a square has the number 3, it means that of the eight squares around it (if not in a corner or edge) there are 3 with mines and 5 without mines. If a square without a number is discovered, it indicates that none of the neighboring squares has a mine and these are discovered automatically.
 If a cell with a mine is discovered, the game is over.
 A check mark can be placed in the boxes that the player thinks there are mines to help discover those that are nearby.
 The game also has a record system for each of the 4 levels in which the shortest time to finish the game is indicated. The levels are:
 Novice level: 9 × 9 cells y 10 mines.
 Intermediate level: 16 × 16 cells y 40 mines.
 Expert level: 16 × 30 cells y 99 mines.
 Custom level: in this case the user personalizes his game by choosing the number of mines and the size of the grid.";
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }
    }
}
