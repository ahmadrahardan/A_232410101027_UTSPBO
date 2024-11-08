using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_PBO.App.Models;
using UTS_PBO.App.Context;
using UTS_PBO.Views;
using Microsoft.VisualBasic.Logging;

namespace UTS_PBO.Views
{
    public partial class UserControlLogin : UserControl
    {
        LandingPage FormParent;
        public UserControlLogin(LandingPage FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            FormParent.ShowRegister();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginContext loginAdminContext = new LoginContext();
            Akun login = loginAdminContext.Validate(UsernameBox.Text, PasswordBox.Text);

            if (login != null)
            {
                MessageBox.Show("Login berhasil!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FormParent.ShowDashboard();
                ClearTextBox();
            }
            else if (string.IsNullOrEmpty(UsernameBox.Text) || string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Username & Password tidak boleh kosong!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username atau Password salah. Masukkan dengan benar!", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
        }

        public void ClearTextBox()
        {
            UsernameBox.Text = "";
            PasswordBox.Text = "";
        }

        private void UserControlLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
