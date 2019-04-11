﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem.BL.Models;
using BankSystem.BL.Service;
using BankSystem.BL.Repositorys;
using BankSystem.UI.Forms;

namespace BankSystem.UI.controlers
{
    public partial class CardControl : UserControl
    {
        public CardModel Card { get; set; }
     
        public CardControl(CardModel card)
        {
            InitializeComponent();
            Card = card;
            CardName_label.Text = Card.Name;
            CardNumber_label.Text = Card.CardNumber;
            if(CardName_label.Text == "Bronze")
            CardName_label.ForeColor = Color.SaddleBrown;
            else if (CardName_label.Text == "Silver")
                CardName_label.ForeColor = Color.Gray;
            else if (CardName_label.Text == "Gold")
                CardName_label.ForeColor = Color.Yellow;

            Card_pictureBox.LoadAsync(Card.ImageURL);
            Card_pictureBox.Hide();
            this.BackgroundImage = Card_pictureBox.Image;
            this.BackgroundImageLayout = ImageLayout.Zoom;

        }



        private void Card_Click(object sender, EventArgs e)
        {
            var transactionForm = new TransactionsForm();
            transactionForm.Show();
        }

        private  void  CardControl_Load(object sender, EventArgs e)
        {
         

        }
    }
}
