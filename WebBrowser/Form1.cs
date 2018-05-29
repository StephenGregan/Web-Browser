using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string WebPage = textBox1.Text.Trim();
            textBox2.Navigate(WebPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.GoHome();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Go();
        }
    }
}
