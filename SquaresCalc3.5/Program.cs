using System;
using System.Windows.Forms;
using SquaresCalc3._5.View;

namespace SquaresCalc3._5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Environment.GetCommandLineArgs().Length > 1
                ? new MainViewForm(Environment.GetCommandLineArgs()[1])
                : new MainViewForm());
        }
    }
}
