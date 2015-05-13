using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace finah_desktop_CSharp
{
    public class DbFunctions
    {
        public List<Patientmantelzorger> loadPatienten()
        {
            return getPatienten("http://finahweb.azurewebsites.net/api/patientmantelzorger/false").Result.ToList();
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


        public List<Patientmantelzorger> loadVerzorger()
        {
            return getVerzorger("http://finahweb.azurewebsites.net/api/patientmantelzorger/false").Result.ToList();
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


        public List<Vraag> loadVragen()
        {
            return getVragen("http://finahweb.azurewebsites.net/api/vraag/").Result.ToList();
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


        public List<Dokter> loadDokters()
        {
            return getDokters("http://finahweb.azurewebsites.net/api/vraag/").Result.ToList();
        }

        private Task<IEnumerable<Dokter>> getDokters(string baseUrl)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Dokter>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Dokter[]>(json);
            });
        }


        public List<Antwoord> loadAntwoorden()
        {
            return getAntwoorden("http://finahweb.azurewebsites.net/api/antwoord/").Result.ToList();
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


        public List<Rapport> loadRapport()
        {
            return getRapport("http://finahweb.azurewebsites.net/api/vraag/").Result.ToList();
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


        public List<Vragenlijst> loadVragenlijsten()
        {
            return getVragenlijsten("http://finahweb.azurewebsites.net/api/antwoord/").Result.ToList();
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



        /* private void loadVragen(int vragenlijstId)
         {
             //IEnumerable<Vraag> vragen = getVragenByVragenlijstId(vragenlijstId).Result;
             IEnumerable<Vraag> vragen = getData("http://finahweb.azurewebsites.net/api/patientmantelzorger/false").Result;
             patientDataGridView.DataSource = patient;

             foreach (Patientmantelzorger vraag in patient)
             {
                 Console.WriteLine();
                 Console.WriteLine("VraagId: " + vraag.Id + "Beschrijving :" + vraag.Anaam);
             }
         }*/

   

        /*private void loadRapport()
        {
            //IEnumerable<Vraag> vragen = getVragenByVragenlijstId(vragenlijstId).Result;
            IEnumerable<Rapport> rapport = getRapport("http://finahweb.azurewebsites.net/api/rapport").Result;
            rapportDataGridView.DataSource = rapport;

            foreach (Rapport vraag in rapport)
            {
                Console.WriteLine();
                Console.WriteLine("VraagId: " + vraag.Id + "Beschrijving :" + vraag.Date);
            }
        }

        private void loadVragenlijst()
        {
            //IEnumerable<Vraag> vragen = getVragenByVragenlijstId(vragenlijstId).Result;
            IEnumerable<Vragenlijst> vragenlijst = getVragenlijst("http://finahweb.azurewebsites.net/api/vragenlijst").Result;
            vragenlijstDataGridView.DataSource = vragenlijst;
            //vragenlijstDataGridView.

            foreach (Vragenlijst vraag in vragenlijst)
            {
                Console.WriteLine();
                Console.WriteLine("VraagId: " + vraag.Id + "Beschrijving :" + vraag.Beschrijving);
            }
        }


        public Task<IEnumerable<Rapport>> getRapport(string baseUrl)
        {

            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Rapport>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Rapport[]>(json);
            });
        }

        public Task<IEnumerable<Vragenlijst>> getVragenlijst(string baseUrl)
        {

            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Vragenlijst>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Vragenlijst[]>(json);
            });
        }*/



    }
}
