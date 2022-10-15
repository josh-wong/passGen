using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        // menuStrip items - File
        private void OpenNewWindow_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
        private void Clear_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomNumber.Visible = false;
            Copy.Visible = false;
            RandomNumber_s.Visible = false;
            Copy_s.Visible = false;
        }
        private void Exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // menuStrip items - Help
        private void Documentation_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://josh-wong.github.io/passGen");
        }
        private void ReleaseNotes_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/josh-wong/passGen/releases");
        }
        private void ReportIssue_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/josh-wong/passGen/issues");
        }
        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 3.0.0 | Updated: October 15, 2022" + Environment.NewLine + "MIT License." + Environment.NewLine + "" + Environment.NewLine + "Created by josh-wong.", "About passGen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Main passGen window
        protected void Generate_pw_Click(object sender, EventArgs e)
        {
            int lengthOfPassword = 10;

            // Generate a password with uppercase letters, lowercase letters, and numbers
            string valid = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ12345678901234567890";
            StringBuilder strB = new StringBuilder(100);
            Random random = new Random();
            while (0 < lengthOfPassword--)
            {
                strB.Append(valid[random.Next(valid.Length)]);
            }
            RandomNumber.Text = strB.ToString();

            RandomNumber.Visible = true;
            Copy.Visible = true;
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RandomNumber.Text);
            MessageBox.Show("Password copied to clipboard.", "passGen");
        }

        protected void Generate_pw_s_Click(object sender, EventArgs e)
        {
            int lengthOfPassword = 10;

            // Generate a password with symbols, uppercase letters, lowercase letters, and numbers; symbols duplicated to increase likelihood of symbols being included
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ12345678901234567890!@^&-()!@^&-()!@^&-()";
            StringBuilder strB = new StringBuilder(100);
            Random random = new Random();
            while (0 < lengthOfPassword--)
            {
                strB.Append(valid[random.Next(valid.Length)]);
            }
            RandomNumber_s.Text = strB.ToString();

            RandomNumber_s.Visible = true;
            Copy_s.Visible = true;
        }

        private void Copy_s_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RandomNumber_s.Text);
            MessageBox.Show("Password copied to clipboard.", "passGen");
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
        
        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
