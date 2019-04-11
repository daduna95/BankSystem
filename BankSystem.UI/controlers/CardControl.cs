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
    public partial class CardControl : UserControl
    {
        public CardModel Card { get; set; }
        
        public CardControl(CardModel card)
        {
            InitializeComponent();
            Card = card;
            CardNumber_label.Text = Card.CardNumber;
            Card_pictureBox.Load(Card.ImageURL);
            Card_pictureBox.Hide();
            this.BackgroundImage = Card_pictureBox.Image;
            this.BackgroundImageLayout = ImageLayout.Zoom;

        }
       
        
    }
}
