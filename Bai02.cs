using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab06
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string key = txtKey.Text;
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            txtOutput.Text = Encrypt(input, key);
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string input = txtOutput.Text;
            string key = txtKey.Text;
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            txtGiaima.Text = Decrypt(input, key);
        }
        private string Encrypt(string text, string key)
        {
            string result = string.Empty;
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char symbol in text)
            {
                if (char.IsLetter(symbol))
                {
                    char offset = char.IsUpper(symbol) ? 'A' : 'a';
                    int encryptedChar = ((symbol + key[keyIndex] - 2 * offset) % 26) + offset;
                    result += (char)encryptedChar;
                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    result += symbol;
                }
            }
            return result;
        }
        private string Decrypt(string text, string key)
        {
            string result = string.Empty;
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char symbol in text)
            {
                if (char.IsLetter(symbol))
                {
                    char offset = char.IsUpper(symbol) ? 'A' : 'a';
                    int decryptedChar = ((symbol - key[keyIndex] + 26) % 26) + offset;
                    result += (char)decryptedChar;
                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    result += symbol;
                }
            }
            return result;
        }
    }
}
