namespace BankSystem.UI.Forms
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.LogIn_button = new System.Windows.Forms.Button();
            this.UserName_textBox = new System.Windows.Forms.TextBox();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Registration_Button = new System.Windows.Forms.Label();
            this.Error_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogIn_button
            // 
            this.LogIn_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogIn_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn_button.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_button.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LogIn_button.Location = new System.Drawing.Point(167, 364);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(300, 40);
            this.LogIn_button.TabIndex = 3;
            this.LogIn_button.Text = "Sign In";
            this.LogIn_button.UseVisualStyleBackColor = true;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // UserName_textBox
            // 
            this.UserName_textBox.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_textBox.Location = new System.Drawing.Point(167, 225);
            this.UserName_textBox.Name = "UserName_textBox";
            this.UserName_textBox.Size = new System.Drawing.Size(300, 33);
            this.UserName_textBox.TabIndex = 1;
            this.UserName_textBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.UserName_label.Location = new System.Drawing.Point(170, 201);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(93, 22);
            this.UserName_label.TabIndex = 3;
            this.UserName_label.Text = "User Name";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Password_label.Location = new System.Drawing.Point(170, 260);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(80, 22);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Password";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textBox.Location = new System.Drawing.Point(168, 285);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(300, 33);
            this.Password_textBox.TabIndex = 2;
            this.Password_textBox.UseSystemPasswordChar = true;
            this.Password_textBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Passwordlabel.Location = new System.Drawing.Point(0, 0);
            this.Passwordlabel.MaximumSize = new System.Drawing.Size(3, 0);
            this.Passwordlabel.MinimumSize = new System.Drawing.Size(3, 0);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(3, 176);
            this.Passwordlabel.TabIndex = 3;
            this.Passwordlabel.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Registration_Button
            // 
            this.Registration_Button.AutoSize = true;
            this.Registration_Button.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_Button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Registration_Button.Location = new System.Drawing.Point(269, 417);
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.Size = new System.Drawing.Size(102, 22);
            this.Registration_Button.TabIndex = 0;
            this.Registration_Button.Text = "Registration";
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_label.ForeColor = System.Drawing.Color.Maroon;
            this.Error_label.Location = new System.Drawing.Point(198, 172);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(238, 22);
            this.Error_label.TabIndex = 5;
            this.Error_label.Text = "Username or Password is incorrect";
            this.Error_label.Visible = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 541);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.Registration_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.UserName_textBox);
            this.Controls.Add(this.LogIn_button);
            this.MaximumSize = new System.Drawing.Size(650, 580);
            this.MinimumSize = new System.Drawing.Size(650, 580);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.TextBox UserName_textBox;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Registration_Button;
        private System.Windows.Forms.Label Error_label;
    }
}