using System;
using System.Windows.Forms;
using Internship_7_Library.Forms;

namespace Internship_7_Library
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var startMenu = new StartMenu();
            startMenu.ShowDialog();

        }
    }
}
