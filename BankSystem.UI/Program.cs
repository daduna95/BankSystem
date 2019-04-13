using BankSystem.BL.Models;
using BankSystem.UI.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                FirstName = "Levani",
                LastName = "Chubinidze",
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
                        Color = Color.Blue,
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
                        Color = Color.Tan,
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
                        Color = Color.Silver,
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
                        Color = Color.Gold,
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
