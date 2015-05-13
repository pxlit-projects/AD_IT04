using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;



namespace finah_desktop_CSharp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public class inlogGegevens {
            private String email;
            private String password;
            private String returnUrl;

            public inlogGegevens(String email, String password, String returnUrl)
            {
                this.email = email;
                this.password = password;
                this.returnUrl = returnUrl;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = gebruikersTextBox.Text;
            string password = wwTextBox.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");
            


            var gegevens = new inlogGegevens("jan.schoefs@gmail.com", "P@ssw0rd", "iets");

            

        //    int openForm = 1;

        //    //openForm =                de gebruikersnaam, wachtwoord en type gebruiker worden opgevraagd en vergeleken

        //    if (openForm == 0)  //verkeerde gebruikersnaam of wachtwoord
        //    {
        //        MessageBox.Show("U heeft een verkeerde gebruikersnaam of wachtwoord ingegeven");
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
        //        MessageBox.Show("Er is een fout opgetreden bij het verbinding maken met de server");
        //    }

        //}

        //private int CheckUser(string gebruikersnaam, string wachtwoord)
        //{
        //    int result = 0;



        //    return result;
        }
    }
}
