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
            this.CardNumber_label = new System.Windows.Forms.Label();
            this.CardName_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CardNumber_label
            // 
            this.CardNumber_label.AutoSize = true;
            this.CardNumber_label.BackColor = System.Drawing.Color.Transparent;
            this.CardNumber_label.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumber_label.ForeColor = System.Drawing.Color.White;
            this.CardNumber_label.Location = new System.Drawing.Point(3, 104);
            this.CardNumber_label.Name = "CardNumber_label";
            this.CardNumber_label.Size = new System.Drawing.Size(84, 14);
            this.CardNumber_label.TabIndex = 3;
            this.CardNumber_label.Text = "Card Number";
            // 
            // CardName_label
            // 
            this.CardName_label.AutoSize = true;
            this.CardName_label.BackColor = System.Drawing.Color.Transparent;
            this.CardName_label.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName_label.ForeColor = System.Drawing.Color.White;
            this.CardName_label.Location = new System.Drawing.Point(3, 37);
            this.CardName_label.Name = "CardName_label";
            this.CardName_label.Size = new System.Drawing.Size(70, 14);
            this.CardName_label.TabIndex = 3;
            this.CardName_label.Text = "Card Type";
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CardName_label);
            this.Controls.Add(this.CardNumber_label);
            this.MaximumSize = new System.Drawing.Size(200, 150);
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(200, 150);
            this.Click += new System.EventHandler(this.Card_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CardNumber_label;
        private System.Windows.Forms.Label CardName_label;
    }
}
