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
            this.Card_pictureBox.Location = new System.Drawing.Point(4, 4);
            this.Card_pictureBox.Name = "Card_pictureBox";
            this.Card_pictureBox.Size = new System.Drawing.Size(323, 163);
            this.Card_pictureBox.TabIndex = 0;
            this.Card_pictureBox.TabStop = false;
            // 
            // CardNumber_label
            // 
            this.CardNumber_label.AutoSize = true;
            this.CardNumber_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumber_label.Location = new System.Drawing.Point(17, 128);
            this.CardNumber_label.Name = "CardNumber_label";
            this.CardNumber_label.Size = new System.Drawing.Size(110, 22);
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
