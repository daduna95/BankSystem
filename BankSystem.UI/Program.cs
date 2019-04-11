using BankSystem.BL.Models;
using BankSystem.UI.Forms;
using System;
using System.Collections.Generic;
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
            // ToDo : User is Test Data. Needs Remove
            var user = new BL.Models.UserModel
            {
                Email = "LevanCubinidze",
                Password = "123",
                Cards = new List<CardModel>
                {
                    new CardModel
                    {
                        Name = string.Empty,
                        Id = 0,
                        CardNumber = string.Empty,
                        Balance = 0,
                        Bonus = 0,
                        DailyLimit = 0,
                        ImageURL = "http://techcentral.co.za/wp-content/uploads/2012/12/A-Standard-Bank-cheque-card-with-integrated-NFC-technology-from-MasterCard.jpg",
                        MonthlyPayment = 0

                    }
                },
            };


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(user));
        }
    }
}
