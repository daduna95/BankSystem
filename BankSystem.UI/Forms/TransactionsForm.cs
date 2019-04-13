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
        public TransactionsForm(CardModel card)
        {
            InitializeComponent();
            Name_label.Text += card.Name;
            CardNumber_label.Text += card.CardNumber;
            Balance_label.Text += card.Balance;
            DailyLimit_label.Text += card.DailyLimit;
            Bonus_label.Text += card.Bonus;
            MonthlyPayment_label.Text += card.Bonus;
            TransactionFrom_layoutPanel.BackgroundImage = Properties.Resources.Card;
            TransactionFrom_layoutPanel.BackgroundImageLayout = ImageLayout.Zoom;

        }
    }
}
