using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testDemoTDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameIstGleich_Click(object sender, EventArgs e)
        {
            Bruch b1 = new Bruch(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            textBox3.Text = b1.quotient().ToString();
        }

        private void kuerzel_Click(object sender, EventArgs e)
        {
            Bruch b2 = new Bruch(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            b2.kuerzel();
            textBox1.Text = b2.Zaehler.ToString();
            textBox2.Text = b2.Nenner.ToString();
        }
    }
}
