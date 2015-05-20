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
        public List<Patientmantelzorger> loadPatientMantelzorger(int patientId)
        {
            return getPatient("http://finahweb.azurewebsites.net/api/patientmantelzorger/" + patientId + "/1/1/1").Result.ToList();
        }

        private Task<IEnumerable<Patientmantelzorger>> getPatient(string baseUrl)
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

        public List<Vragenlijst> loadVragenlijst(int vragenlijstId)
        {
            return getVragenlijst("http://finahweb.azurewebsites.net/api/vragenlijst/" + vragenlijstId + "/1/1/1").Result.ToList();
        }

        private Task<IEnumerable<Vragenlijst>> getVragenlijst(string baseUrl)
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

        public List<Patientmantelzorger> loadPatienten(int dokterId)
        {
            if (getPatienten("http://finahweb.azurewebsites.net/api/patientmantelzorger/" + dokterId + "/false").Result != null)
            {
                return getPatienten("http://finahweb.azurewebsites.net/api/patientmantelzorger/" + dokterId + "/false").Result.ToList();
            }

            return null;
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
                    return null;
                }
            });
        }

        public List<Patientmantelzorger> loadVerzorgers(int dokterId)
        {
            if (getVerzorgers("http://finahweb.azurewebsites.net/api/patientmantelzorger/" + dokterId + "/true").Result != null)
            {
                return getVerzorgers("http://finahweb.azurewebsites.net/api/patientmantelzorger/" + dokterId + "/true").Result.ToList();
            }

            return null;
        }

        private Task<IEnumerable<Patientmantelzorger>> getVerzorgers(string baseUrl)
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

                    return null;
                }
            });
        }

        public List<Vraag> loadAlleVragen()
        {
            if (getAlleVragen("http://finahweb.azurewebsites.net/api/vraag/").Result != null)
            {
                return getAlleVragen("http://finahweb.azurewebsites.net/api/vraag/").Result.ToList();
            }

            return null;
        }

        private Task<IEnumerable<Vraag>> getAlleVragen(string baseUrl)
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

                    return null;
                }
            });
        }

        public List<Antwoord> loadAntwoordenByRapportId(int rapportId)
        {
            if (getAntwoordenByRapportId("http://finahweb.azurewebsites.net/api/antwoord/" + rapportId).Result != null)
            {
                return getAntwoordenByRapportId("http://finahweb.azurewebsites.net/api/antwoord/" + rapportId).Result.ToList();
            }
            else
            {
                return null;
            }
        }

        private Task<IEnumerable<Antwoord>> getAntwoordenByRapportId(string baseUrl)
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
                    return null;
                }
            });
        }


        public List<Rapport> loadRapport(int dokterId)
        {
            if (getRapport("http://finahweb.azurewebsites.net/api/rapport/" + dokterId).Result != null)
            {
                return getRapport("http://finahweb.azurewebsites.net/api/rapport/" + dokterId).Result.ToList();
            }

            return null;
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

                    return null;
                }
            });
        }


        public List<Vragenlijst> loadVragenlijsten(int dokterId)
        {
            if (getVragenlijsten("http://finahweb.azurewebsites.net/api/vragenlijst/" + dokterId).Result != null)
            {
                return getVragenlijsten("http://finahweb.azurewebsites.net/api/vragenlijst/" + dokterId).Result.ToList();
            }

            return null;
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

                    return null;
                }
            });
        }

        public List<Vraag> loadVragenByVragenlijstId(int vragenlijstId)
        {
            if (getVragenByVragenlijstId("http://finahweb.azurewebsites.net/api/vraag/" + vragenlijstId).Result != null)
            {
                return getVragenByVragenlijstId("http://finahweb.azurewebsites.net/api/vraag/" + vragenlijstId).Result.ToList();
            }
            else
            {
                return null;
            }
        }

        private Task<IEnumerable<Vraag>> getVragenByVragenlijstId(string baseUrl)
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
                catch
                {
                    return null;
                }
            });
        }

        public void postPatient(Patientmantelzorger patient)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.PostAsJsonAsync("api/patientmantelzorger", patient);
        }

        public void postMantelzorger(Patientmantelzorger mantelzorger)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync("api/patientmantelzorger", mantelzorger);
        }

        public int postVragenlijst(Vragenlijst vragenlijst)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync("api/vragenlijst", vragenlijst);

            return response.Result.Content.ReadAsAsync<Vragenlijst>().Result.Id;
        }

        public void postVraag(Vraag vraag)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync("api/vraag", vraag);
        }

        public int postRapport(Rapport rapport)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://finahweb.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync("api/rapport", rapport);

            return response.Result.Content.ReadAsAsync<Rapport>().Result.Id;
        }
    }
}
