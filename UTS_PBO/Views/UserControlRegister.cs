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
using Microsoft.Win32;

namespace UTS_PBO.Views
{
    public partial class UserControlRegister : UserControl
    {
        LandingPage FormParent;
        public UserControlRegister(LandingPage FormParent)
        {
            InitializeComponent();
            this.FormParent = FormParent;
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            FormParent.ShowLogin();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameBox.Text) ||
                string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Akun register = new Akun(
                UsernameBox.Text,
                PasswordBox.Text
            );

            RegisterContext registerContext = new RegisterContext();
            bool isRegistered = registerContext.Register(register);

            if (isRegistered)
            {
                MessageBox.Show("Register berhasil!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal mendaftarkan user. Email atau username mungkin sudah digunakan.", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
