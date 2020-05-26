using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinForms25052020Test1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void cleanButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void addRndStrButton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(Rnd());
            }
        }

        public string Rnd()
        {
            string str = "";
            for (int i = 0; i < 10; i++)
                str += (char)random.Next(97, 122);
            return str;
        }
    }
}