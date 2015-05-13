using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace finah_desktop_CSharp
{
    public class DbFunctions
    {
        public List<Patientmantelzorger> loadPatienten(int dokter_Id)
        {
            return getPatienten("http://finahweb.azurewebsites.net/api/patientmantelzorger/" + dokter_Id + "/false").Result.ToList();
        }

        private Task<IEnumerable<Patientmantelzorger>> getPatienten(string baseUrl)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Patientmantelzorger>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Patientmantelzorger[]>(json);
            });
        }


        public List<Patientmantelzorger> loadMantelzorgers(int dokter_Id)
        {
            return getVerzorger("http://finahweb.azurewebsites.net/api/patientmantelzorger/" + dokter_Id + "/true").Result.ToList();
        }

        private Task<IEnumerable<Patientmantelzorger>> getVerzorger(string baseUrl)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Patientmantelzorger>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Patientmantelzorger[]>(json);
            });
        }


        public List<Vraag> loadVragen(int vragenlijst_Id)
        {
            return getVragen("http://finahweb.azurewebsites.net/api/vraag/" + vragenlijst_Id).Result.ToList();
        }

        private Task<IEnumerable<Vraag>> getVragen(string baseUrl)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Vraag>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Vraag[]>(json);
            });
        }

        public List<Antwoord> loadAntwoorden(int rapport_Id)
        {
            return getAntwoorden("http://finahweb.azurewebsites.net/api/antwoord/" + rapport_Id).Result.ToList();
        }

        private Task<IEnumerable<Antwoord>> getAntwoorden(string baseUrl)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Antwoord>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Antwoord[]>(json);
            });
        }


        public List<Rapport> loadRapporten(int dokter_Id)
        {
            return getRapport("http://finahweb.azurewebsites.net/api/rapport/" + dokter_Id).Result.ToList();
        }

        private Task<IEnumerable<Rapport>> getRapport(string baseUrl)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Rapport>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Rapport[]>(json);
            });
        }


        public List<Vragenlijst> loadVragenlijsten(int dokter_Id)
        {
            return getVragenlijsten("http://finahweb.azurewebsites.net/api/vragenlijst/" + dokter_Id).Result.ToList();
        }

        private Task<IEnumerable<Vragenlijst>> getVragenlijsten(string baseUrl)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Vragenlijst>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Vragenlijst[]>(json);
            });
        }

        public void postPatient(Patientmantelzorger patient)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync("api/patientmantelzorger", patient);

            System.Diagnostics.Debug.WriteLine(response.Result);
        }

        public void postMantelzorger(Patientmantelzorger mantelzorger)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync("api/patientmantelzorger", mantelzorger);

            System.Diagnostics.Debug.WriteLine(response.Result);
        }

        public int postVragenlijst(Vragenlijst vragenlijst)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync("api/vragenlijst", vragenlijst);

            System.Diagnostics.Debug.WriteLine(response.Result);

            return response.Result.Content.ReadAsAsync<Vragenlijst>().Result.Id;
        }
    }
}
