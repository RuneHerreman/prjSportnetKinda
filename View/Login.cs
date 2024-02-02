﻿using prjSportnetKinda.DA;
using prjSportnetKinda.Model;
using System;
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
            //var decl
            string strEmail, strWachtwoord;

            //var opvangen
            strEmail = txtEmail.Text;
            strWachtwoord = txtPassword.Text;

            //Klasse oproepen
            zrc___Sportnet login = zrc___SportnetDA.Inloggen(strEmail, strWachtwoord);

            //Controle op wachtoord en email
            if (zrc___SportnetDA.Inloggen(strEmail, strWachtwoord) == null)
            {
                //Foutmelding tonen
                lblFout.Text = "E-mail of Wachtwoord is fout";

                //textboxen resetten
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }
            else if (login.email == strEmail && login.Wachtwoord == strWachtwoord) 
            {
                //Main form openen
                Main Main = new Main();
                this.Hide();
                Main.ShowDialog();
                this.Close();
            }
        }
    }
}
