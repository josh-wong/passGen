using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passGen
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        protected void generate_pw_Click(object sender, EventArgs e)
        {
            int lengthOfPassword = 8;

            // Generate a password with uppercase letters, lowercase letters, and numbers
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder strB = new StringBuilder(100);
            Random random = new Random();
            while (0 < lengthOfPassword--)
            {
                strB.Append(valid[random.Next(valid.Length)]);
            }
            RandomNumber.Text = strB.ToString();

            RandomNumber.Visible = true;
            copy.Visible = true;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RandomNumber.Text);
            MessageBox.Show("Password copied.", "passGen");
        }

        protected void generate_pw_s_Click(object sender, EventArgs e)
        {
            int lengthOfPassword = 8;

            // Generate a password with symbols, uppercase letters, lowercase letters, and numbers; symbols duplicated to increase likelihood of symbols being included
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@^&-_!@^&-_";
            StringBuilder strB = new StringBuilder(100);
            Random random = new Random();
            while (0 < lengthOfPassword--)
            {
                strB.Append(valid[random.Next(valid.Length)]);
            }
            RandomNumber_s.Text = strB.ToString();

            RandomNumber_s.Visible = true;
            copy_s.Visible = true;
        }

        private void copy_s_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RandomNumber_s.Text);
            MessageBox.Show("Password copied.", "passGen");
        }

        private void RandomNumber_MouseDown(object sender, MouseEventArgs e)
        {
            RandomNumber.PasswordChar = '\0';
        }

        private void RandomNumber_MouseUp(object sender, MouseEventArgs e)
        {
            RandomNumber.PasswordChar = '*';
        }

        private void RandomNumber_s_MouseDown(object sender, MouseEventArgs e)
        {
            RandomNumber_s.PasswordChar = '\0';
        }

        private void RandomNumber_s_MouseUp(object sender, MouseEventArgs e)
        {
            RandomNumber_s.PasswordChar = '*';
        }

        private void reset_Click(object sender, EventArgs e)
        {
            RandomNumber.Visible = false;
            copy.Visible = false;
            RandomNumber_s.Visible = false;
            copy_s.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
