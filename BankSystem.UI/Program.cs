using BankSystem.UI.Forms;
using System;
using System.Windows.Forms;

namespace BankSystem.UI
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
            Application.Run(new LogInForm(new BL.Models.UserModel()));
        }
    }
}
