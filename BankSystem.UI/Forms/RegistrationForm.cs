using BankSystem.BL.Models;
using BankSystem.BL.Service;
using BankSystem.UI.Utils;
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
        IUserService user = new RegistrationService();
        List<UserModel> TestDB = new List<UserModel>();
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
                UserModel userModel = new UserModel
                {
                    FirstName = FirstName_textbox.Text,
                    LastName = LastName_textBox.Text,
                    Email = Email_textbox.Text,
                    PrivateNumber = PrivateNumber_textbox.Text,
                    Password = Password_textbox.Text
                };
              
                TestDB.Add(user.RegisterUser(userModel));
            }
        }


        private bool ValidateInput()
        {
            bool IsValidateInput = IsValid.Valid(FirstName_textbox, FirstName_label);
            IsValidateInput = IsValid.Valid(LastName_textBox, LastName_label);
            IsValidateInput = IsValid.Valid(Email_textbox, Email_label);
            IsValidateInput = IsValid.Valid(PrivateNumber_textbox, ID_label);
            IsValidateInput = IsValid.Valid(Password_textbox, Password_label);
            IsValidateInput = IsValid.Valid(RepeatPassword_textbox, RepeatPassword_label);
            IsValidateInput = PasswordMatch();
            return IsValidateInput;
        }

        private bool PasswordMatch()
        {
            bool PasswordIsNotEmpty = !string.IsNullOrWhiteSpace(Password_textbox.Text) && !string.IsNullOrWhiteSpace(RepeatPassword_textbox.Text);
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
                IsValid.Valid(textBox, label);
            }
        }
    }
}
