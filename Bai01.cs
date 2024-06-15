using System;
using System.Windows.Forms;
namespace Lab06
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtShift.Text, out int shift))
            {
                txtOutput.Text = Encrypt(txtInput.Text, shift);
            }
            else
            {
                MessageBox.Show("Please enter a valid shift value.");
            }
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtShift.Text, out int shift))
            {
                txtGiaima.Text = Decrypt(txtOutput.Text, shift);
            }
            else
            {
                MessageBox.Show("Please enter a valid shift value.");
            }
        }
        private string Encrypt(string input, int shift)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsLetter(letter))
                {
                    char d = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)((((letter + shift) - d) % 26) + d);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }
        private string Decrypt(string input, int shift)
        {
            return Encrypt(input, 26 - shift);
        }
    }
}
