﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSportnetKinda
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void picBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLinkToRegistreren_Click(object sender, EventArgs e)
        {
            Register Register = new Register();
            this.Hide();
            Register.ShowDialog();
            this.Close();
        }

        private void lblLinkToWWVergeten_Click(object sender, EventArgs e)
        {
            WWVergeten wWVergeten = new WWVergeten();
            this.Hide();
            wWVergeten.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}