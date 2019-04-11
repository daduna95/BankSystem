namespace BankSystem.UI.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.Menu_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.By_Card_button = new System.Windows.Forms.Button();
            this.Home_button = new System.Windows.Forms.Button();
            this.User_pictureBox = new System.Windows.Forms.PictureBox();
            this.LastName_label = new System.Windows.Forms.Label();
            this.FirstName_label = new System.Windows.Forms.Label();
            this.Menu_Panel_timer = new System.Windows.Forms.Timer(this.components);
            this.Menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Menu_panel.Controls.Add(this.Menu_button);
            this.Menu_panel.Controls.Add(this.button3);
            this.Menu_panel.Controls.Add(this.button2);
            this.Menu_panel.Controls.Add(this.By_Card_button);
            this.Menu_panel.Controls.Add(this.Home_button);
            this.Menu_panel.Controls.Add(this.User_pictureBox);
            this.Menu_panel.Controls.Add(this.LastName_label);
            this.Menu_panel.Controls.Add(this.FirstName_label);
            this.Menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_panel.Location = new System.Drawing.Point(0, 0);
            this.Menu_panel.MaximumSize = new System.Drawing.Size(205, 0);
            this.Menu_panel.MinimumSize = new System.Drawing.Size(65, 0);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(205, 561);
            this.Menu_panel.TabIndex = 0;
            // 
            // Menu_button
            // 
            this.Menu_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Menu_button.FlatAppearance.BorderSize = 0;
            this.Menu_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.Menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_button.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_button.ForeColor = System.Drawing.Color.White;
            this.Menu_button.Image = ((System.Drawing.Image)(resources.GetObject("Menu_button.Image")));
            this.Menu_button.Location = new System.Drawing.Point(155, 4);
            this.Menu_button.Name = "Menu_button";
            this.Menu_button.Size = new System.Drawing.Size(38, 36);
            this.Menu_button.TabIndex = 3;
            this.Menu_button.UseVisualStyleBackColor = false;
            this.Menu_button.Click += new System.EventHandler(this.Sandwich_button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(7, 428);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(190, 50);
            this.button3.TabIndex = 2;
            this.button3.Tag = "";
            this.button3.Text = "  Home";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(7, 370);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(190, 50);
            this.button2.TabIndex = 2;
            this.button2.Tag = "";
            this.button2.Text = "  Home";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // By_Card_button
            // 
            this.By_Card_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.By_Card_button.FlatAppearance.BorderSize = 0;
            this.By_Card_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.By_Card_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.By_Card_button.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.By_Card_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.By_Card_button.Image = ((System.Drawing.Image)(resources.GetObject("By_Card_button.Image")));
            this.By_Card_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.By_Card_button.Location = new System.Drawing.Point(7, 312);
            this.By_Card_button.Name = "By_Card_button";
            this.By_Card_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.By_Card_button.Size = new System.Drawing.Size(190, 50);
            this.By_Card_button.TabIndex = 2;
            this.By_Card_button.Tag = "";
            this.By_Card_button.Text = "  By Card";
            this.By_Card_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.By_Card_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.By_Card_button.UseVisualStyleBackColor = false;
            // 
            // Home_button
            // 
            this.Home_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Home_button.FlatAppearance.BorderSize = 0;
            this.Home_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.Home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_button.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Home_button.Image = ((System.Drawing.Image)(resources.GetObject("Home_button.Image")));
            this.Home_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_button.Location = new System.Drawing.Point(7, 254);
            this.Home_button.Name = "Home_button";
            this.Home_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Home_button.Size = new System.Drawing.Size(190, 50);
            this.Home_button.TabIndex = 2;
            this.Home_button.Tag = "";
            this.Home_button.Text = "  Home";
            this.Home_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Home_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_button.UseVisualStyleBackColor = false;
            // 
            // User_pictureBox
            // 
            this.User_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.User_pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.User_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.User_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.User_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("User_pictureBox.Image")));
            this.User_pictureBox.Location = new System.Drawing.Point(47, 61);
            this.User_pictureBox.Name = "User_pictureBox";
            this.User_pictureBox.Size = new System.Drawing.Size(110, 110);
            this.User_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.User_pictureBox.TabIndex = 1;
            this.User_pictureBox.TabStop = false;
            // 
            // LastName_label
            // 
            this.LastName_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastName_label.AutoSize = true;
            this.LastName_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LastName_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastName_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_label.ForeColor = System.Drawing.Color.White;
            this.LastName_label.Location = new System.Drawing.Point(60, 205);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(84, 22);
            this.LastName_label.TabIndex = 0;
            this.LastName_label.Text = "LastName";
            this.LastName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstName_label
            // 
            this.FirstName_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstName_label.AutoSize = true;
            this.FirstName_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FirstName_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstName_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_label.ForeColor = System.Drawing.Color.White;
            this.FirstName_label.Location = new System.Drawing.Point(76, 175);
            this.FirstName_label.Name = "FirstName_label";
            this.FirstName_label.Size = new System.Drawing.Size(53, 22);
            this.FirstName_label.TabIndex = 0;
            this.FirstName_label.Text = "Name";
            this.FirstName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu_Panel_timer
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(220, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(580, 450);
            this.contentPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Menu_panel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Menu_panel.ResumeLayout(false);
            this.Menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.PictureBox User_pictureBox;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.Label FirstName_label;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button By_Card_button;
        private System.Windows.Forms.Button Menu_button;
        private System.Windows.Forms.Timer Menu_Panel_timer;
    }
}