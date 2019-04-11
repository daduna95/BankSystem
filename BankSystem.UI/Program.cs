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
                        Name = "Basic",
                        Id = 1,
                        CardNumber = "1111 2222 3333 4444",
                        Balance = 2000,
                        Bonus = 150,
                        DailyLimit = 5000,
                        ImageURL = "http://techcentral.co.za/wp-content/uploads/2012/12/A-Standard-Bank-cheque-card-with-integrated-NFC-technology-from-MasterCard.jpg",
                        MonthlyPayment = 50

                    },
                    new CardModel
                    {
                        Name = "Bronze",
                        Id = 2,
                        CardNumber = "4444 1111 2222 3333",
                        Balance = 3000,
                        Bonus = 250,
                        DailyLimit = 10000,
                        ImageURL = "http://techcentral.co.za/wp-content/uploads/2012/12/A-Standard-Bank-cheque-card-with-integrated-NFC-technology-from-MasterCard.jpg",
                        MonthlyPayment = 100

                    },
                    new CardModel
                    {
                        Name = "Silver",
                        Id = 2,
                        CardNumber = "4444 3333 1111 2222",
                        Balance = 4000,
                        Bonus = 350,
                        DailyLimit = 15000,
                        ImageURL = "http://techcentral.co.za/wp-content/uploads/2012/12/A-Standard-Bank-cheque-card-with-integrated-NFC-technology-from-MasterCard.jpg",
                        MonthlyPayment = 150

                    },
                    new CardModel
                    {
                        Name = "Gold",
                        Id = 2,
                        CardNumber = "4444 3333 2222 1111",
                        Balance = 5000,
                        Bonus = 450,
                        DailyLimit = 20000,
                        ImageURL = "http://techcentral.co.za/wp-content/uploads/2012/12/A-Standard-Bank-cheque-card-with-integrated-NFC-technology-from-MasterCard.jpg",
                        MonthlyPayment = 200

                    }

                },
            };


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(user));
        }
    }
}
