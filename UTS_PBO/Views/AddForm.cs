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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UTS_PBO.Views
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }
        }

        Kontak kontak = new Kontak
        {
            nama = textBox1.Text,
            email = textBox2.Text,
            no_hp = textBox3.Text,

            KontakContext.AddKontak(kontak);
            MessageBox.Show("Berhasil ditambahkan");
        };


        //ClearFields();
        //this.DialogResult = DialogResult.OK;
        //this.Hide()


        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
