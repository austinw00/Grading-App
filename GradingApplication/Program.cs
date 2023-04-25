using System;
using System.Windows.Forms;

namespace GradingApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Initialize the database
            DatabaseHelper.InitializeDatabase();
            Application.Run(new MainForm());
        }
    }
}
