using System;
using System.Windows.Forms;

namespace PayrollSystem
{
    static class Program
    {
        // This is the main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Start the application with the MainForm window
            Application.Run(new MainForm());
        }
    }
}
