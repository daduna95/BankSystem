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
        public UserModel User { get;  }
        
        bool isCollapsed = false;
        int maxWidth = 205;
        int minWidth = 65;
        int stepsize = 5;

        public MainForm(UserModel user)
        {
            InitializeComponent();
            User = user;

            FirstName_label.Text = user.FirstName;
            LastName_label.Text = user.LastName;

            CenterLabel(FirstName_label);
            CenterLabel(LastName_label);

        }

        private void CenterLabel(Label label)
        {
            var x = (label.Right - label.Left) / 2;

            label.Left = Menu_panel.Width / 2 - x;
        }

        private void Sandwich_button_Click(object sender, EventArgs e)
        {
            Menu_Panel_timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                UserVisible(true);
                if (Menu_panel.Width < maxWidth)
                {
                    Menu_panel.Width += stepsize;
                }
                else
                {
                    isCollapsed = false;
                    Menu_Panel_timer.Stop();
                }
            }
            else
            {
                UserVisible(false);
                if (Menu_panel.Width > minWidth)
                {
                    Menu_panel.Width -= stepsize;
                }
                else
                {
                    isCollapsed = true;
                    Menu_Panel_timer.Stop();
                }
            }
        }

        private void UserVisible(bool visible)
        {
            if (visible)
            {
                User_pictureBox.Visible = true;
                FirstName_label.Visible = true;
                LastName_label.Visible = true;
            }
            else
            {
                User_pictureBox.Visible = false;
                FirstName_label.Visible = false;
                LastName_label.Visible = false;
            }
           
        }


        private void Home_button_Click(object sender, EventArgs e)
        {
           contentPanel.Controls.Clear();
           contentPanel.Controls.Add(new HomeControl(User));
     
        }
    }
}
