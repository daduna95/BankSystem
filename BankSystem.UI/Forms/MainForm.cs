using BankSystem.BL.Models;
using BankSystem.UI.controlers;
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
    public partial class MainForm : Form
    {
        public UserModel User { get; }
        
        public MainForm(UserModel user)
        {
            InitializeComponent();
            User = user;
           
        }


        private void Home_button_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(new HomeControl(User));
     
        }
    }
}
