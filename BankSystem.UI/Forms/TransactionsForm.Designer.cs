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
            this.Type_label = new System.Windows.Forms.Label();
            this.CardNumber_label = new System.Windows.Forms.Label();
            this.Balance_label = new System.Windows.Forms.Label();
            this.DailyLimit_label = new System.Windows.Forms.Label();
            this.Bonus_label = new System.Windows.Forms.Label();
            this.MonthlyPayment_label = new System.Windows.Forms.Label();
            this.TransferInfo_label = new System.Windows.Forms.Label();
            this.TransferCardNumber_label = new System.Windows.Forms.Label();
            this.CardNumber_textBox = new System.Windows.Forms.TextBox();
            this.Amount_label = new System.Windows.Forms.Label();
            this.Amount_textBox = new System.Windows.Forms.TextBox();
            this.AmountConfirmation_button = new System.Windows.Forms.Button();
            this.TypeChangeable_label = new System.Windows.Forms.Label();
            this.CardNumberChangeable_label = new System.Windows.Forms.Label();
            this.BalanceChangeable_label = new System.Windows.Forms.Label();
            this.DailyLimitChangeable_label = new System.Windows.Forms.Label();
            this.BonusChangeable_label = new System.Windows.Forms.Label();
            this.MonthlyPaymentChangeable_label = new System.Windows.Forms.Label();
            this.SMSBank_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TransactionFrom_layoutPanel
            // 
            this.TransactionFrom_layoutPanel.Location = new System.Drawing.Point(12, 12);
            this.TransactionFrom_layoutPanel.Name = "TransactionFrom_layoutPanel";
            this.TransactionFrom_layoutPanel.Size = new System.Drawing.Size(271, 138);
            this.TransactionFrom_layoutPanel.TabIndex = 0;
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_label.Location = new System.Drawing.Point(12, 162);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(57, 22);
            this.Type_label.TabIndex = 0;
            this.Type_label.Text = "Type: ";
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
            // TransferInfo_label
            // 
            this.TransferInfo_label.AutoSize = true;
            this.TransferInfo_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferInfo_label.Location = new System.Drawing.Point(324, 12);
            this.TransferInfo_label.Name = "TransferInfo_label";
            this.TransferInfo_label.Size = new System.Drawing.Size(129, 22);
            this.TransferInfo_label.TabIndex = 1;
            this.TransferInfo_label.Text = "Transfer Money";
            // 
            // TransferCardNumber_label
            // 
            this.TransferCardNumber_label.AutoSize = true;
            this.TransferCardNumber_label.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferCardNumber_label.Location = new System.Drawing.Point(325, 38);
            this.TransferCardNumber_label.Name = "TransferCardNumber_label";
            this.TransferCardNumber_label.Size = new System.Drawing.Size(83, 18);
            this.TransferCardNumber_label.TabIndex = 2;
            this.TransferCardNumber_label.Text = "Card Number";
            // 
            // CardNumber_textBox
            // 
            this.CardNumber_textBox.Location = new System.Drawing.Point(434, 38);
            this.CardNumber_textBox.Name = "CardNumber_textBox";
            this.CardNumber_textBox.Size = new System.Drawing.Size(200, 20);
            this.CardNumber_textBox.TabIndex = 3;
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_label.Location = new System.Drawing.Point(325, 69);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(53, 16);
            this.Amount_label.TabIndex = 4;
            this.Amount_label.Text = "Amount";
            // 
            // Amount_textBox
            // 
            this.Amount_textBox.Location = new System.Drawing.Point(384, 68);
            this.Amount_textBox.Name = "Amount_textBox";
            this.Amount_textBox.Size = new System.Drawing.Size(178, 20);
            this.Amount_textBox.TabIndex = 5;
            // 
            // AmountConfirmation_button
            // 
            this.AmountConfirmation_button.Location = new System.Drawing.Point(568, 68);
            this.AmountConfirmation_button.Name = "AmountConfirmation_button";
            this.AmountConfirmation_button.Size = new System.Drawing.Size(75, 20);
            this.AmountConfirmation_button.TabIndex = 6;
            this.AmountConfirmation_button.Text = "Transfer";
            this.AmountConfirmation_button.UseVisualStyleBackColor = true;
            this.AmountConfirmation_button.Click += new System.EventHandler(this.Transfer_buttonClick);
            // 
            // TypeChangeable_label
            // 
            this.TypeChangeable_label.AutoSize = true;
            this.TypeChangeable_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeChangeable_label.Location = new System.Drawing.Point(64, 162);
            this.TypeChangeable_label.Name = "TypeChangeable_label";
            this.TypeChangeable_label.Size = new System.Drawing.Size(47, 22);
            this.TypeChangeable_label.TabIndex = 0;
            this.TypeChangeable_label.Text = "Type";
            // 
            // CardNumberChangeable_label
            // 
            this.CardNumberChangeable_label.AutoSize = true;
            this.CardNumberChangeable_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberChangeable_label.Location = new System.Drawing.Point(138, 196);
            this.CardNumberChangeable_label.Name = "CardNumberChangeable_label";
            this.CardNumberChangeable_label.Size = new System.Drawing.Size(115, 22);
            this.CardNumberChangeable_label.TabIndex = 0;
            this.CardNumberChangeable_label.Text = "Card Number:";
            // 
            // BalanceChangeable_label
            // 
            this.BalanceChangeable_label.AutoSize = true;
            this.BalanceChangeable_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceChangeable_label.Location = new System.Drawing.Point(96, 229);
            this.BalanceChangeable_label.Name = "BalanceChangeable_label";
            this.BalanceChangeable_label.Size = new System.Drawing.Size(68, 22);
            this.BalanceChangeable_label.TabIndex = 0;
            this.BalanceChangeable_label.Text = "Balance";
            // 
            // DailyLimitChangeable_label
            // 
            this.DailyLimitChangeable_label.AutoSize = true;
            this.DailyLimitChangeable_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyLimitChangeable_label.Location = new System.Drawing.Point(127, 267);
            this.DailyLimitChangeable_label.Name = "DailyLimitChangeable_label";
            this.DailyLimitChangeable_label.Size = new System.Drawing.Size(99, 22);
            this.DailyLimitChangeable_label.TabIndex = 0;
            this.DailyLimitChangeable_label.Text = "Daily Limit";
            // 
            // BonusChangeable_label
            // 
            this.BonusChangeable_label.AutoSize = true;
            this.BonusChangeable_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonusChangeable_label.Location = new System.Drawing.Point(83, 304);
            this.BonusChangeable_label.Name = "BonusChangeable_label";
            this.BonusChangeable_label.Size = new System.Drawing.Size(55, 22);
            this.BonusChangeable_label.TabIndex = 0;
            this.BonusChangeable_label.Text = "Bonus";
            // 
            // MonthlyPaymentChangeable_label
            // 
            this.MonthlyPaymentChangeable_label.AutoSize = true;
            this.MonthlyPaymentChangeable_label.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyPaymentChangeable_label.Location = new System.Drawing.Point(171, 343);
            this.MonthlyPaymentChangeable_label.Name = "MonthlyPaymentChangeable_label";
            this.MonthlyPaymentChangeable_label.Size = new System.Drawing.Size(143, 22);
            this.MonthlyPaymentChangeable_label.TabIndex = 0;
            this.MonthlyPaymentChangeable_label.Text = "Monthly Payment";
            // 
            // SMSBank_checkBox
            // 
            this.SMSBank_checkBox.AutoSize = true;
            this.SMSBank_checkBox.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMSBank_checkBox.Location = new System.Drawing.Point(16, 382);
            this.SMSBank_checkBox.Name = "SMSBank_checkBox";
            this.SMSBank_checkBox.Size = new System.Drawing.Size(131, 22);
            this.SMSBank_checkBox.TabIndex = 7;
            this.SMSBank_checkBox.Text = "Activate SMS Bank";
            this.SMSBank_checkBox.UseVisualStyleBackColor = true;
            this.SMSBank_checkBox.Click += new System.EventHandler(this.SMSBank_checkBox_Click);
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SMSBank_checkBox);
            this.Controls.Add(this.AmountConfirmation_button);
            this.Controls.Add(this.Amount_textBox);
            this.Controls.Add(this.Amount_label);
            this.Controls.Add(this.CardNumber_textBox);
            this.Controls.Add(this.TransferCardNumber_label);
            this.Controls.Add(this.TransferInfo_label);
            this.Controls.Add(this.MonthlyPaymentChangeable_label);
            this.Controls.Add(this.MonthlyPayment_label);
            this.Controls.Add(this.BonusChangeable_label);
            this.Controls.Add(this.Bonus_label);
            this.Controls.Add(this.DailyLimitChangeable_label);
            this.Controls.Add(this.DailyLimit_label);
            this.Controls.Add(this.BalanceChangeable_label);
            this.Controls.Add(this.Balance_label);
            this.Controls.Add(this.CardNumberChangeable_label);
            this.Controls.Add(this.CardNumber_label);
            this.Controls.Add(this.TypeChangeable_label);
            this.Controls.Add(this.Type_label);
            this.Controls.Add(this.TransactionFrom_layoutPanel);
            this.Name = "TransactionsForm";
            this.Text = "TransactionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TransactionFrom_layoutPanel;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.Label CardNumber_label;
        private System.Windows.Forms.Label Balance_label;
        private System.Windows.Forms.Label DailyLimit_label;
        private System.Windows.Forms.Label Bonus_label;
        private System.Windows.Forms.Label MonthlyPayment_label;
        private System.Windows.Forms.Label TransferInfo_label;
        private System.Windows.Forms.Label TransferCardNumber_label;
        private System.Windows.Forms.TextBox CardNumber_textBox;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.TextBox Amount_textBox;
        private System.Windows.Forms.Button AmountConfirmation_button;
        private System.Windows.Forms.Label TypeChangeable_label;
        private System.Windows.Forms.Label CardNumberChangeable_label;
        private System.Windows.Forms.Label BalanceChangeable_label;
        private System.Windows.Forms.Label DailyLimitChangeable_label;
        private System.Windows.Forms.Label BonusChangeable_label;
        private System.Windows.Forms.Label MonthlyPaymentChangeable_label;
        private System.Windows.Forms.CheckBox SMSBank_checkBox;
    }
}