using BankSystem.BL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.UI.Forms
{
    public partial class TransactionsForm : Form
    {
        List<string> cards = new List<string>
        {
            "1234",
            "4321"
        };
        public TransactionsForm(CardModel card)
        {
            Card = card;

            InitializeComponent();
            TypeChangeable_label.Text = Card.Name;
            CardNumberChangeable_label.Text = Card.CardNumber;
            BalanceChangeable_label.Text = Card.Balance.ToString();
            DailyLimitChangeable_label.Text = Card.DailyLimit.ToString();
            BonusChangeable_label.Text = Card.Bonus.ToString();
            MonthlyPaymentChangeable_label.Text = Card.Bonus.ToString();
            TransactionFrom_layoutPanel.BackgroundImage = Properties.Resources.Card;
            TransactionFrom_layoutPanel.BackgroundImageLayout = ImageLayout.Zoom;

        }

        public CardModel Card { get; }

        //TODO: Add transfer on other account logic.
        private void Transfer_buttonClick(object sender, EventArgs e)
        {
            
            if (cards.Any(c => c == CardNumber_textBox.Text))
            {

                if (Card.Balance > int.Parse(Amount_textBox.Text) && int.Parse(Amount_textBox.Text) <= Card.DailyLimit)
                {
                    Card.Balance -= int.Parse(Amount_textBox.Text);
                    BalanceChangeable_label.Text = Card.Balance.ToString(); 
                }
                else
                {
                    MessageBox.Show("Not enough money on balance or ammount exceeded daily limit. Enter different ammount!");
                    Amount_textBox.Clear();
                }
            }
        }

        private void SMSBank_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SMSBank_checkBox_Click(object sender, EventArgs e)
        {

        }
    }
}
