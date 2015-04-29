using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace API
{
    public class DB
    {
        public static string GetVragen()
        {

            HttpResponseMessage response = null;
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/Vraag").Result;

                if (response.IsSuccessStatusCode)
                {
                    var Vraag = response.Content.ReadAsStringAsync().Result;
                    ///usergrid.ItemsSource = users; datagridview

                }
            }
            catch (HttpRequestException ex)
            {
                //throw ("Error Code" +  response.StatusCode + " : Message - " + response.ReasonPhrase);
            }

            return response.ToString();
        }

        private void GetVragenlijst()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/User").Result;

            if (response.IsSuccessStatusCode)
            {
                /*   var users = response.Content.ReadAsAsync&
                   lt;IEnumerable&lt;Users&gt;&gt;().Result;
                   usergrid.ItemsSource = users;*/

            }
            else
            {
                // MessageBox.Show("Error Code" + 
                // response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void GetGebruiker()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/User").Result;

            if (response.IsSuccessStatusCode)
            {
                /*   var users = response.Content.ReadAsAsync&
                   lt;IEnumerable&lt;Users&gt;&gt;().Result;
                   usergrid.ItemsSource = users;*/

            }
            else
            {
                // MessageBox.Show("Error Code" + 
                // response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void GetRapport()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/User").Result;

            if (response.IsSuccessStatusCode)
            {
                /*   var users = response.Content.ReadAsAsync&
                   lt;IEnumerable&lt;Users&gt;&gt;().Result;
                   usergrid.ItemsSource = users;*/

            }
            else
            {
                // MessageBox.Show("Error Code" + 
                // response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
    }
}
