using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kool_Kat_Panel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            OnProgramStart.Initialize("Kool Kat Panel", "132439", "PFZ1wGYzOKby78tXYzw8xOTvNWNMXwcQZeR", "1.1");
        }

        private void logInButton2_Click(object sender, EventArgs e)
        {
            if (API.Login(tbUsername.Text, tbPassword.Text))
            {
                Hide();
                new Main().Show();
            }
        }

        private void logInButton1_Click(object sender, EventArgs e)
        {
            Hide();
            new Register().Show();
        }

        private void logInCheckBox1_CheckedChanged(object sender)
        {
            if (logInCheckBox1.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void xRails_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://instagram.com/preroutings");
            Process.Start("https://discord.gg/9QVeTZasTN");
            Process.Start("https://snapchat.com/add/daddysurtains");
            Process.Start("https://tiktok.com/@surtains");
        }
    }
}
