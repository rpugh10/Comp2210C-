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

        String userPassword = "Soccer#10";
        String userUsername = "rpugh777";
        String username = "";
        String password = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Equals(userUsername) && password.Equals(userPassword))
            {
                MessageBox.Show("Signed in!");
            }
            else
            {
                MessageBox.Show("Incorrect login information");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             password = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
