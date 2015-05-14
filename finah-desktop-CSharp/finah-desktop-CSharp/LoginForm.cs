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
using System.Runtime.Serialization;
using System.Net.Http.Headers;



namespace finah_desktop_CSharp
{
    public partial class LoginForm : Form
    {
        private DbFunctions dbfunctions;

        public LoginForm()
        {
            InitializeComponent();
            dbfunctions = new DbFunctions();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = gebruikersTextBox.Text;
            string password = wwTextBox.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");

            var loginGegevens = new LoginGegevens() { Email = email, Password = password, returnUrl = "Hier moet gewoon iets staan maakt niet uit wat" };

            int dokter_Id = login(loginGegevens);

            if (dokter_Id != 0)
            {
                Form form = new BeheerForm(dokter_Id);
                form.ShowDialog();
            }
            else
            {

            }
        }

        public int login(LoginGegevens loginGegevens)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync("account/login", loginGegevens);

            try
            {
                return response.Result.Content.ReadAsAsync<int>().Result;
            }
            catch
            {
                return 0;
            }
        }
    }

    public class LoginGegevens
    {
        [DataMember]
        public String Email;

        [DataMember]
        public String Password;

        [DataMember]
        public String returnUrl;
    }
}
