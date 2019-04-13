namespace BankSystem.UI.Forms
{
    partial class TransactionsForm
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
            this.TransactionFrom_layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Name_label = new System.Windows.Forms.Label();
            this.CardNumber_label = new System.Windows.Forms.Label();
            this.Balance_label = new System.Windows.Forms.Label();
            this.DailyLimit_label = new System.Windows.Forms.Label();
            this.Bonus_label = new System.Windows.Forms.Label();
            this.MonthlyPayment_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransactionFrom_layoutPanel
            // 
            this.TransactionFrom_layoutPanel.Location = new System.Drawing.Point(12, 12);
            this.TransactionFrom_layoutPanel.Name = "TransactionFrom_layoutPanel";
            this.TransactionFrom_layoutPanel.Size = new System.Drawing.Size(271, 138);
            this.TransactionFrom_layoutPanel.TabIndex = 0;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(12, 162);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(63, 22);
            this.Name_label.TabIndex = 0;
            this.Name_label.Text = "Name: ";
            // 
            // CardNumber_label
            // 
            this.CardNumber_label.AutoSize = true;
            this.CardNumber_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumber_label.Location = new System.Drawing.Point(12, 196);
            this.CardNumber_label.Name = "CardNumber_label";
            this.CardNumber_label.Size = new System.Drawing.Size(120, 22);
            this.CardNumber_label.TabIndex = 0;
            this.CardNumber_label.Text = "Card Number: ";
            // 
            // Balance_label
            // 
            this.Balance_label.AutoSize = true;
            this.Balance_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance_label.Location = new System.Drawing.Point(12, 229);
            this.Balance_label.Name = "Balance_label";
            this.Balance_label.Size = new System.Drawing.Size(78, 22);
            this.Balance_label.TabIndex = 0;
            this.Balance_label.Text = "Balance: ";
            // 
            // DailyLimit_label
            // 
            this.DailyLimit_label.AutoSize = true;
            this.DailyLimit_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyLimit_label.Location = new System.Drawing.Point(12, 267);
            this.DailyLimit_label.Name = "DailyLimit_label";
            this.DailyLimit_label.Size = new System.Drawing.Size(109, 22);
            this.DailyLimit_label.TabIndex = 0;
            this.DailyLimit_label.Text = "Daily Limit: ";
            // 
            // Bonus_label
            // 
            this.Bonus_label.AutoSize = true;
            this.Bonus_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bonus_label.Location = new System.Drawing.Point(12, 304);
            this.Bonus_label.Name = "Bonus_label";
            this.Bonus_label.Size = new System.Drawing.Size(65, 22);
            this.Bonus_label.TabIndex = 0;
            this.Bonus_label.Text = "Bonus: ";
            // 
            // MonthlyPayment_label
            // 
            this.MonthlyPayment_label.AutoSize = true;
            this.MonthlyPayment_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyPayment_label.Location = new System.Drawing.Point(12, 343);
            this.MonthlyPayment_label.Name = "MonthlyPayment_label";
            this.MonthlyPayment_label.Size = new System.Drawing.Size(153, 22);
            this.MonthlyPayment_label.TabIndex = 0;
            this.MonthlyPayment_label.Text = "Monthly Payment: ";
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MonthlyPayment_label);
            this.Controls.Add(this.Bonus_label);
            this.Controls.Add(this.DailyLimit_label);
            this.Controls.Add(this.Balance_label);
            this.Controls.Add(this.CardNumber_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.TransactionFrom_layoutPanel);
            this.Name = "TransactionsForm";
            this.Text = "TransactionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TransactionFrom_layoutPanel;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label CardNumber_label;
        private System.Windows.Forms.Label Balance_label;
        private System.Windows.Forms.Label DailyLimit_label;
        private System.Windows.Forms.Label Bonus_label;
        private System.Windows.Forms.Label MonthlyPayment_label;
    }
}