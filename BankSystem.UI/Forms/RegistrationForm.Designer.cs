namespace BankSystem.UI.Forms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.FirstName_textbox = new System.Windows.Forms.TextBox();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.PrivateNumber_textbox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.RepeatPassword_textbox = new System.Windows.Forms.TextBox();
            this.Registration_button = new System.Windows.Forms.Button();
            this.FirstName_label = new System.Windows.Forms.Label();
            this.LastName_label = new System.Windows.Forms.Label();
            this.Email_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.RepeatPassword_label = new System.Windows.Forms.Label();
            this.Registration_picturebox = new System.Windows.Forms.PictureBox();
            this.PasswordError_label = new System.Windows.Forms.Label();
            this.RepeatPasswordError_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Registration_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName_textbox
            // 
            this.FirstName_textbox.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_textbox.Location = new System.Drawing.Point(298, 233);
            this.FirstName_textbox.Name = "FirstName_textbox";
            this.FirstName_textbox.Size = new System.Drawing.Size(228, 33);
            this.FirstName_textbox.TabIndex = 0;
            this.FirstName_textbox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_textBox.Location = new System.Drawing.Point(297, 294);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(229, 33);
            this.LastName_textBox.TabIndex = 1;
            this.LastName_textBox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // Email_textbox
            // 
            this.Email_textbox.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_textbox.Location = new System.Drawing.Point(298, 355);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(228, 33);
            this.Email_textbox.TabIndex = 2;
            this.Email_textbox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // PrivateNumber_textbox
            // 
            this.PrivateNumber_textbox.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivateNumber_textbox.Location = new System.Drawing.Point(298, 416);
            this.PrivateNumber_textbox.Name = "PrivateNumber_textbox";
            this.PrivateNumber_textbox.Size = new System.Drawing.Size(228, 33);
            this.PrivateNumber_textbox.TabIndex = 3;
            this.PrivateNumber_textbox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // Password_textbox
            // 
            this.Password_textbox.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textbox.Location = new System.Drawing.Point(297, 477);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(229, 33);
            this.Password_textbox.TabIndex = 4;
            this.Password_textbox.UseSystemPasswordChar = true;
            this.Password_textbox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // RepeatPassword_textbox
            // 
            this.RepeatPassword_textbox.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPassword_textbox.Location = new System.Drawing.Point(297, 538);
            this.RepeatPassword_textbox.Name = "RepeatPassword_textbox";
            this.RepeatPassword_textbox.Size = new System.Drawing.Size(229, 33);
            this.RepeatPassword_textbox.TabIndex = 5;
            this.RepeatPassword_textbox.UseSystemPasswordChar = true;
            this.RepeatPassword_textbox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // Registration_button
            // 
            this.Registration_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_button.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_button.Location = new System.Drawing.Point(356, 588);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(113, 40);
            this.Registration_button.TabIndex = 6;
            this.Registration_button.Text = "Register";
            this.Registration_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Registration_button.UseVisualStyleBackColor = true;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // FirstName_label
            // 
            this.FirstName_label.AutoSize = true;
            this.FirstName_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_label.Location = new System.Drawing.Point(297, 208);
            this.FirstName_label.Name = "FirstName_label";
            this.FirstName_label.Size = new System.Drawing.Size(94, 22);
            this.FirstName_label.TabIndex = 2;
            this.FirstName_label.Text = "First Name";
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_label.Location = new System.Drawing.Point(297, 269);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(89, 22);
            this.LastName_label.TabIndex = 2;
            this.LastName_label.Text = "Last Name";
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_label.Location = new System.Drawing.Point(297, 330);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(54, 22);
            this.Email_label.TabIndex = 2;
            this.Email_label.Text = "Email";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(297, 391);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(129, 22);
            this.ID_label.TabIndex = 2;
            this.ID_label.Text = "Private Number";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(297, 452);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(80, 22);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // RepeatPassword_label
            // 
            this.RepeatPassword_label.AutoSize = true;
            this.RepeatPassword_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPassword_label.Location = new System.Drawing.Point(297, 513);
            this.RepeatPassword_label.Name = "RepeatPassword_label";
            this.RepeatPassword_label.Size = new System.Drawing.Size(135, 22);
            this.RepeatPassword_label.TabIndex = 2;
            this.RepeatPassword_label.Text = "Repeat Password";
            // 
            // Registration_picturebox
            // 
            this.Registration_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("Registration_picturebox.Image")));
            this.Registration_picturebox.Location = new System.Drawing.Point(369, 110);
            this.Registration_picturebox.Name = "Registration_picturebox";
            this.Registration_picturebox.Size = new System.Drawing.Size(100, 100);
            this.Registration_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Registration_picturebox.TabIndex = 3;
            this.Registration_picturebox.TabStop = false;
            // 
            // PasswordError_label
            // 
            this.PasswordError_label.AutoSize = true;
            this.PasswordError_label.ForeColor = System.Drawing.Color.Red;
            this.PasswordError_label.Location = new System.Drawing.Point(383, 458);
            this.PasswordError_label.Name = "PasswordError_label";
            this.PasswordError_label.Size = new System.Drawing.Size(85, 13);
            this.PasswordError_label.TabIndex = 4;
            this.PasswordError_label.Text = "Does Not Match";
            this.PasswordError_label.Visible = false;
            // 
            // RepeatPasswordError_label
            // 
            this.RepeatPasswordError_label.AutoSize = true;
            this.RepeatPasswordError_label.ForeColor = System.Drawing.Color.Red;
            this.RepeatPasswordError_label.Location = new System.Drawing.Point(438, 519);
            this.RepeatPasswordError_label.Name = "RepeatPasswordError_label";
            this.RepeatPasswordError_label.Size = new System.Drawing.Size(85, 13);
            this.RepeatPasswordError_label.TabIndex = 5;
            this.RepeatPasswordError_label.Text = "Does Not Match";
            this.RepeatPasswordError_label.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 676);
            this.Controls.Add(this.RepeatPasswordError_label);
            this.Controls.Add(this.PasswordError_label);
            this.Controls.Add(this.Registration_picturebox);
            this.Controls.Add(this.RepeatPassword_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.LastName_label);
            this.Controls.Add(this.FirstName_label);
            this.Controls.Add(this.Registration_button);
            this.Controls.Add(this.RepeatPassword_textbox);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.PrivateNumber_textbox);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.LastName_textBox);
            this.Controls.Add(this.FirstName_textbox);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.Registration_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName_textbox;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.TextBox PrivateNumber_textbox;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.TextBox RepeatPassword_textbox;
        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.Label FirstName_label;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label RepeatPassword_label;
        private System.Windows.Forms.PictureBox Registration_picturebox;
        private System.Windows.Forms.Label PasswordError_label;
        private System.Windows.Forms.Label RepeatPasswordError_label;
    }
}