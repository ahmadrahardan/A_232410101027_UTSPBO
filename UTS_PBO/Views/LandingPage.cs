using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_PBO.Views;

namespace UTS_PBO.Views
{
    public partial class LandingPage : Form
    {
        UserControlLogin login;
        UserControlRegister register;
        UserControlDashboard dashboard;
        System.Windows.Forms.Timer timer;
        public LandingPage()
        {
            InitializeComponent();
            login = new UserControlLogin(this);
            register = new UserControlRegister(this);
            dashboard = new UserControlDashboard(this);

            this.Controls.Add(login);
            this.Controls.Add(register);
            this.Controls.Add(dashboard);

            HideAllUserControl();
            ShowLogin();


        public void HideAllUserControl()
        {
            foreach (UserControl userControl in this.Controls)
            {
                userControl.Visible = false;
            }
        }

        public void ShowLogin()
        {
            HideAllUserControl();
            login.Visible = true;
        }

        public void ShowRegister()
        {
            HideAllUserControl();
            register.Visible = true;
        }

        public void ShowDashboard()
        {
            HideAllUserControl();
            dashboard.Visible = true;
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }
    }
}

