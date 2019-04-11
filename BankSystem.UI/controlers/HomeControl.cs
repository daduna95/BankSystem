using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem.BL.Models;

namespace BankSystem.UI.controlers
{
    public partial class HomeControl : UserControl
    {
        public UserModel User { get; set; }
        public HomeControl(UserModel user)
        {
            InitializeComponent();

            User = user;

            var cardControls = user.Cards.Select(c => new CardControl(c)).ToArray();
            cardsPanel.Controls.AddRange(cardControls);
        }
    }
}
