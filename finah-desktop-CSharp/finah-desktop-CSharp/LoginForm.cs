﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace finah_desktop_CSharp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");
        //    int openForm = 1;

        //    //openForm =                de gebruikersnaam, wachtwoord en type gebruiker worden opgevraagd en vergeleken

        //    if (openForm == 0)  //verkeerde gebruikersnaam of wachtwoord
        //    {
        //        MessageBox.Show("U heeft een verkeerde gebruikernaam of wachtwoord ingegeven");
        //    }
        //    else if (openForm == 1) //dokter : open beheerform
        //    {
        //        Form form = new BeheerForm();
        //        form.ShowDialog();
        //    }
        //    else if (openForm == 2) //verzorger/patient : open vragenlijstform
        //    {
        //        Form form = new VragenlijstForm();
        //        form.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Er is een fout opgestreden bij het verbinding maken met de server");
        //    }

        //}

        //private int CheckUser(string gebruikersnaam, string wachtwoord)
        //{
        //    int result = 0;



        //    return result;
        //}
    }
}
