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
            Form patientForm = new VoegPatientForm(patientDataGridView, verzorgerDataGridView);
            patientForm.ShowDialog();
        }

        private void voegVerzorgerToeButton_Click(object sender, EventArgs e)
        {
            Form verzorgerForm = new VoegVerzorgerForm(verzorgerDataGridView);
            verzorgerForm.ShowDialog();
        }

        private void voegVragenlijstButton_Click(object sender, EventArgs e)
        {
            Form vragenlijstForm = new AanVragenlijstForm(vragenlijstDataGridView);
            vragenlijstForm.ShowDialog();
        }

        private void BeheerForm_Load(object sender, EventArgs e)
        {
            loadpatient();
            loadverzorger();
            loadRapport();
            loadVragenlijst();
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
            //Console.WriteLine("current " + verzorgerDataGridView.CurrentRow.Selected);

        }

        private void loadRapport()
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
        }

        private void rapportDetailButton_Click(object sender, EventArgs e)
        {
           /* Form form = new VragenlijstForm();
            form.ShowDialog();*/
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            Form vragenlijstForm = new AanVragenlijstForm(1, vragenlijstDataGridView);
            vragenlijstForm.ShowDialog();
        }
    }
}
