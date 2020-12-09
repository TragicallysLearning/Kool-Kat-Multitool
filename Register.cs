using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void reg_Click(object sender, EventArgs e)
        {
            if (API.Register(tbUsername.Text, tbPassword.Text, tbEmail.Text, tbToken.Text))
            {
                Hide();
                new Login().Show();
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().Show();
        }
    }
}
