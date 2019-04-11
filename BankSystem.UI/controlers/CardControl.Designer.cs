namespace BankSystem.UI.controlers
{
    partial class CardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Card_pictureBox = new System.Windows.Forms.PictureBox();
            this.CardNumber_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Card_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Card_pictureBox
            // 
            this.Card_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card_pictureBox.ImageLocation = "";
            this.Card_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.Card_pictureBox.Name = "Card_pictureBox";
            this.Card_pictureBox.Size = new System.Drawing.Size(330, 170);
            this.Card_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Card_pictureBox.TabIndex = 0;
            this.Card_pictureBox.TabStop = false;
            // 
            // CardNumber_label
            // 
            this.CardNumber_label.AutoSize = true;
            this.CardNumber_label.BackColor = System.Drawing.Color.Transparent;
            this.CardNumber_label.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumber_label.ForeColor = System.Drawing.Color.Black;
            this.CardNumber_label.Location = new System.Drawing.Point(110, 124);
            this.CardNumber_label.Name = "CardNumber_label";
            this.CardNumber_label.Size = new System.Drawing.Size(96, 16);
            this.CardNumber_label.TabIndex = 3;
            this.CardNumber_label.Text = "Card Number";
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CardNumber_label);
            this.Controls.Add(this.Card_pictureBox);
            this.MaximumSize = new System.Drawing.Size(330, 170);
            this.MinimumSize = new System.Drawing.Size(330, 170);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(330, 170);
            ((System.ComponentModel.ISupportInitialize)(this.Card_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Card_pictureBox;
        private System.Windows.Forms.Label CardNumber_label;
    }
}
