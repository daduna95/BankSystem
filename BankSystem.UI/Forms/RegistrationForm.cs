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
    public partial class RegistrationForm : Form
    {
        public event EventHandler<UserModel> UserRegistered;
    
        public RegistrationForm()
        {
            InitializeComponent();
            FirstName_textbox.Tag = FirstName_label;
            LastName_textBox.Tag = LastName_label;
            Email_textbox.Tag = Email_label;
            PrivateNumber_textbox.Tag = ID_label;
            Password_textbox.Tag = Password_label;
            RepeatPassword_textbox.Tag = RepeatPassword_label;
        }

        private void Registration_button_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                IUserService userService = new UserServiceXmlRepository();
                var newUser = new UserModel
                {
                    FirstName = FirstName_textbox.Text,
                    LastName = LastName_textBox.Text,
                    Email = Email_textbox.Text,
                    PrivateNumber = PrivateNumber_textbox.Text,
                    Password = Password_textbox.Text
                };

                if (userService.RegisterUser(newUser))
                {
                    UserRegistered?.Invoke(this, newUser);
                    Close();
                }
                else
                    RegistrationError_label.Visible = true;
            }
        }


        private bool ValidateInput()
        {
            bool IsValidateInput = Utils.ValidateInput(FirstName_textbox, FirstName_label);
            IsValidateInput = Utils.ValidateInput(LastName_textBox, LastName_label);
            IsValidateInput = Utils.ValidateInput(Email_textbox, Email_label);
            IsValidateInput = Utils.ValidateInput(PrivateNumber_textbox, ID_label);
            IsValidateInput = Utils.ValidateInput(Password_textbox, Password_label);
            IsValidateInput = Utils.ValidateInput(RepeatPassword_textbox, RepeatPassword_label);
            IsValidateInput = PasswordMatch();
            return IsValidateInput;
        }

        private bool PasswordMatch()
        {
            bool PasswordIsNotEmpty = !string.IsNullOrWhiteSpace(Password_textbox.Text) 
                && !string.IsNullOrWhiteSpace(RepeatPassword_textbox.Text);
            if(PasswordIsNotEmpty && Password_textbox.Text == RepeatPassword_textbox.Text)
            {
                PasswordError_label.Visible = false;
                RepeatPasswordError_label.Visible = false;
                return true;
            }
            else if(PasswordIsNotEmpty)
            {
                PasswordError_label.Visible = true;
                RepeatPasswordError_label.Visible = true;
                return false;
            }
            else
            {
                PasswordError_label.Visible = false;
                RepeatPasswordError_label.Visible = false;
                return false;
            }
        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            if(sender is TextBox textBox && textBox.Tag is Label label)
            {
                Utils.ValidateInput(textBox, label);
            }
        }


    }
}
