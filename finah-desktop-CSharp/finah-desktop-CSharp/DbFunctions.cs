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
                try
                {
                    var json = innerTask.Result;
                    return JsonConvert.DeserializeObject<Patientmantelzorger[]>(json);
                }
                catch (Exception)
                {
                    
                    throw;
                }
                
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
                try
                {
                    var json = innerTask.Result;
                    return JsonConvert.DeserializeObject<Patientmantelzorger[]>(json);
                }
                catch (Exception)
                {

                    throw;
                }
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
                try
                {
                    var json = innerTask.Result;
                    return JsonConvert.DeserializeObject<Vraag[]>(json);
                }
                catch (Exception)
                {

                    throw;
                }
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
                try
                {
                    var json = innerTask.Result;
                    return JsonConvert.DeserializeObject<Dokter[]>(json);
                }
                catch (Exception)
                {

                    throw;
                }
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
                try
                {
                    var json = innerTask.Result;
                    return JsonConvert.DeserializeObject<Antwoord[]>(json);
                }
                catch (Exception)
                {

                    throw;
                }
            });
        }


        public List<Rapport> loadRapport()
        {
            /*//List<Rapport> list = new List<Rapport>();
            //IEnumerable<Vraag> vragen = getVragenByVragenlijstId(vragenlijstId).Result;
            IEnumerable<Rapport> rapport = getRapport("http://finahweb.azurewebsites.net/api/rapport").Result;

            foreach (Rapport test in rapport)
            {
                Console.WriteLine(rapport);
            }
            return null;*/
           return getRapport("http://finahweb.azurewebsites.net/api/vraag/").Result.ToList();
        }

        private Task<IEnumerable<Rapport>> getRapport(string baseUrl)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Rapport>>(innerTask =>
            {
                try
                {
                    var json = innerTask.Result;
                    return JsonConvert.DeserializeObject<Rapport[]>(json);
                }
                catch (Exception)
                {

                    throw;
                }
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
                try
                {
                    var json = innerTask.Result;
                    return JsonConvert.DeserializeObject<Vragenlijst[]>(json);
                }
                catch (Exception)
                {

                    throw;
                }
            });
        }


        public List<Vraag> getVragelijst(int vragenlijstId)
        {
            return getvragenId("http://finahweb.azurewebsites.net/api/vraag/" + vragenlijstId).Result.ToList();
        }

        private Task<IEnumerable<Vraag>> getvragenId(string baseUrl)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Vraag>>(innerTask =>
            {
                try
                {
                    var json = innerTask.Result;
                    return JsonConvert.DeserializeObject<Vraag[]>(json);
                }
                catch (Exception)
                {

                    throw;
                }
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
