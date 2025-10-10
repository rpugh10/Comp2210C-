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
            String userPassword = "Soccer#10";
            String userUsername = "rpugh777";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String password = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String username = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
