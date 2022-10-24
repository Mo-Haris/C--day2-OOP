using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Height_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked");
            int input1 = Int32.Parse(textBox1.Text);
            int input2 = Int32.Parse(textBox2.Text);
            Console.WriteLine(input1);
            Console.WriteLine(input2);
            int ans = input1 * input2;
            textBox3.Text = ans.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int input1 = Int32.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int input2 = Int32.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
