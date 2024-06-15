namespace Lab06
{
    partial class Bai01
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
            label1 = new Label();
            label2 = new Label();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            txtShift = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtInput = new RichTextBox();
            txtOutput = new RichTextBox();
            label5 = new Label();
            txtGiaima = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Dữ liệu (Input)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Dịch (Shift)";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(295, 31);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(103, 37);
            btnEncrypt.TabIndex = 2;
            btnEncrypt.Text = "Mã hóa";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(433, 31);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(103, 37);
            btnDecrypt.TabIndex = 3;
            btnDecrypt.Text = "Giải mã";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtShift
            // 
            txtShift.Location = new Point(12, 54);
            txtShift.Name = "txtShift";
            txtShift.Size = new Size(109, 27);
            txtShift.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(0, 1);
            label3.Name = "label3";
            label3.Size = new Size(274, 30);
            label3.TabIndex = 7;
            label3.Text = "Mã hóa CAESAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 253);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "Mã hóa ";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 117);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(524, 120);
            txtInput.TabIndex = 9;
            txtInput.Text = "";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 276);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(524, 120);
            txtOutput.TabIndex = 10;
            txtOutput.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 409);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 11;
            label5.Text = "Giải mã";
            // 
            // txtGiaima
            // 
            txtGiaima.Location = new Point(12, 432);
            txtGiaima.Name = "txtGiaima";
            txtGiaima.Size = new Size(524, 120);
            txtGiaima.TabIndex = 12;
            txtGiaima.Text = "";
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 574);
            Controls.Add(txtGiaima);
            Controls.Add(label5);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtShift);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai01";
            Text = "Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private TextBox txtShift;
        private Label label3;
        private Label label4;
        private RichTextBox txtInput;
        private RichTextBox txtOutput;
        private Label label5;
        private RichTextBox txtGiaima;
    }
}
