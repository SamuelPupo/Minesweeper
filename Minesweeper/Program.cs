using System;
using System.Windows.Forms;

namespace Minesweeper
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Game());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
