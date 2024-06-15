namespace Lab06
{
    partial class Bai02
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
            txtGiaima = new RichTextBox();
            label5 = new Label();
            txtOutput = new RichTextBox();
            txtInput = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            txtKey = new TextBox();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtGiaima
            // 
            txtGiaima.Location = new Point(12, 466);
            txtGiaima.Name = "txtGiaima";
            txtGiaima.Size = new Size(524, 120);
            txtGiaima.TabIndex = 23;
            txtGiaima.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 443);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 22;
            label5.Text = "Giải mã";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 307);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(524, 120);
            txtOutput.TabIndex = 21;
            txtOutput.Text = "";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 141);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(524, 120);
            txtInput.TabIndex = 20;
            txtInput.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 275);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 19;
            label4.Text = "Mã hóa ";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(132, -51);
            label3.Name = "label3";
            label3.Size = new Size(274, 30);
            label3.TabIndex = 18;
            label3.Text = "Mã hóa CAESAR";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(12, 68);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(109, 27);
            txtKey.TabIndex = 17;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(433, 58);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(103, 37);
            btnDecrypt.TabIndex = 16;
            btnDecrypt.Text = "Giải mã";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(284, 58);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(103, 37);
            btnEncrypt.TabIndex = 15;
            btnEncrypt.Text = "Mã hóa";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, -20);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 14;
            label2.Text = "Dịch (Shift)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 13;
            label1.Text = "Dữ liệu (Input)";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(-1, 6);
            label6.Name = "label6";
            label6.Size = new Size(274, 30);
            label6.TabIndex = 24;
            label6.Text = "Mã hóa Vigenère";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 45);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 25;
            label7.Text = "Dịch (Shift)";
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 598);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtGiaima);
            Controls.Add(label5);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtKey);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai02";
            Text = "Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtGiaima;
        private Label label5;
        private RichTextBox txtOutput;
        private RichTextBox txtInput;
        private Label label4;
        private Label label3;
        private TextBox txtKey;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
    }
}