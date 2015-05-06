using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finah_desktop_CSharp
{
    public partial class BeheerForm : Form
    {
        public BeheerForm()
        {
            InitializeComponent();
        }

        private void voegPatientToeButton_Click(object sender, EventArgs e)
        {
            Form patientForm = new VoegPatientForm();
            patientForm.ShowDialog();
        }

        private void voegVerzorgerToeButton_Click(object sender, EventArgs e)
        {
            Form verzorgerForm = new VoegVerzorgerForm();
            verzorgerForm.ShowDialog();
        }

        private void voegVragenlijstButton_Click(object sender, EventArgs e)
        {
            Form vragenlijstForm = new AanVragenlijstForm();
            vragenlijstForm.ShowDialog();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {

        }

        private void BeheerForm_Load(object sender, EventArgs e)
        {
            loadpatient();
            loadverzorger();
        }

        private void loadpatient()
        {
            //IEnumerable<Vraag> vragen = getVragenByVragenlijstId(vragenlijstId).Result;
            IEnumerable<Patientmantelzorger> patient = getData("http://finahweb.azurewebsites.net/api/patientmantelzorger/false").Result;
            patientDataGridView.DataSource = patient;

            foreach (Patientmantelzorger vraag in patient)
            {
                Console.WriteLine();
                Console.WriteLine("VraagId: " + vraag.Id + "Beschrijving :" + vraag.Anaam);
            }
        }

        private void loadverzorger()
        {
            //IEnumerable<Vraag> vragen = getVragenByVragenlijstId(vragenlijstId).Result;
            IEnumerable<Patientmantelzorger> verzorger = getData("http://finahweb.azurewebsites.net/api/patientmantelzorger/true").Result;
            verzorgerDataGridView.DataSource = verzorger;

            foreach (Patientmantelzorger vraag in verzorger)
            {
                Console.WriteLine();
                Console.WriteLine("VraagId: " + vraag.Id + "Beschrijving :" + vraag.Anaam);
            }
        }


        public Task<IEnumerable<Patientmantelzorger>> getData(string baseUrl)
        {

            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Patientmantelzorger>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Patientmantelzorger[]>(json);
            });
        }

        public Task<IEnumerable<Patientmantelzorger>> getData(string baseUrl)
        {

            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Patientmantelzorger>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Patientmantelzorger[]>(json);
            });
        }
    }
}
