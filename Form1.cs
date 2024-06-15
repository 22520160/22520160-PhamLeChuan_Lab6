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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01 f = new Bai01();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 f = new Bai02();
            f.Show();
        }
    }
}
