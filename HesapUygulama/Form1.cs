using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam =sayi1 + sayi2;
            label4.Text = toplam.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi3, sayi4;
            int carpim;
            sayi3 = Convert.ToInt32(textBox4.Text);
            sayi4 = Convert.ToInt32(textBox3.Text);
            carpim = sayi3 * sayi4;
            label8.Text = carpim.ToString();
        }
    }
}
