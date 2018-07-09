using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Username_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            username_lbl.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstname = firstname_txt.Text;

            if (firstname.Length == 0)
            {
                MessageBox.Show("Please enter a first name");
                return;
            }

            string lastname = lastname_txt.Text;

            if (lastname.Length == 0)
            {
                MessageBox.Show("Please enter a last name");
                return;
            }

            string firstLetter = firstname.Substring(0, 1);

            string username = firstLetter + lastname;

            username_lbl.Text = "Your username is " + username;
        }

        private void firstname_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
