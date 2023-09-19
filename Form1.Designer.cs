namespace MORTGAGE_CALCULATOR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            txtLoanAmount = new TextBox();
            txtDownPayment = new TextBox();
            txtInterestRate = new TextBox();
            txtTerms = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblAmount = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(522, 257);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "AUTO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(356, 257);
            button2.Name = "button2";
            button2.Size = new Size(123, 34);
            button2.TabIndex = 0;
            button2.Text = "MORTGAGE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location = new Point(356, 24);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(278, 31);
            txtLoanAmount.TabIndex = 1;
            // 
            // txtDownPayment
            // 
            txtDownPayment.Location = new Point(356, 94);
            txtDownPayment.Name = "txtDownPayment";
            txtDownPayment.Size = new Size(278, 31);
            txtDownPayment.TabIndex = 1;
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(356, 143);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(278, 31);
            txtInterestRate.TabIndex = 1;
            // 
            // txtTerms
            // 
            txtTerms.Location = new Point(356, 203);
            txtTerms.Name = "txtTerms";
            txtTerms.Size = new Size(278, 31);
            txtTerms.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 2;
            label1.Text = "LOAN AMOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 100);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 2;
            label2.Text = "DOWN PAYMENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 149);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 2;
            label3.Text = "INTEREST RATE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 209);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 2;
            label4.Text = "TERM IN YEARS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 337);
            label5.Name = "label5";
            label5.Size = new Size(176, 25);
            label5.TabIndex = 2;
            label5.Text = "MONTHLY PAYMENT";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(356, 337);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(77, 25);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAmount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTerms);
            Controls.Add(txtInterestRate);
            Controls.Add(txtDownPayment);
            Controls.Add(txtLoanAmount);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "LOAN CALCULATOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtLoanAmount;
        private TextBox txtDownPayment;
        private TextBox txtInterestRate;
        private TextBox txtTerms;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblAmount;
    }
}