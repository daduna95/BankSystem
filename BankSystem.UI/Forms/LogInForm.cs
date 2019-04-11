using BankSystem.BL.Models;
using BankSystem.BL.Repositorys;
using BankSystem.BL.Service;
using BankSystem.UI.Common;
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
    public partial class LogInForm : Form
    {

        bool IsValidInput = false;

        public LogInForm(UserModel userModel)
        {
            InitializeComponent();
            UserName_textBox.Tag = UserName_label;
            Password_textBox.Tag = Password_label;
        }

        private void LoginUser(UserModel user)
        {
            IUserService userService = new UserServiceXmlRepository();
            var logedUser = userService.LoginUser(user);
            if (logedUser != null)
            {
                var MainForm = new MainForm(logedUser);
                MainForm.Show();
                Hide();
            }
            else
            {
                Error_label.Visible = true;
            }
        }

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.UserRegistered += RegistrationForm_UserRegistered;
            registrationForm.ShowDialog();
        }

        private void RegistrationForm_UserRegistered(object sender, UserModel user)
        {
            LoginUser(user);
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            IsValidInput = Utils.ValidateInput(UserName_textBox, UserName_label);
            IsValidInput = Utils.ValidateInput(Password_textBox, Passwordlabel);

            if (IsValidInput)
            {
                var user = new UserModel
                {
                    Password = Password_textBox.Text,
                    Email = UserName_textBox.Text,
                };
                LoginUser(user);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox text && text.Tag is Label label)
            {
                Utils.ValidateInput(text, label);
            }
        }
    }
}
