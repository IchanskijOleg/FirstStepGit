using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormITEA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;
        }

        private void btSum_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(tBoxA.Text) + Convert.ToInt32(tBoxB.Text);
            tBoxSum.Text = Convert.ToString(sum);
        }
    }
}
