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
    public partial class VoegPatientForm : Form
    {
        private DataGridView datagrid;
        private DataGridView verzorgerdatagrid;

        public VoegPatientForm(DataGridView datagrid, DataGridView verzorgerDatagrid)
        {
            InitializeComponent();
            this.datagrid = datagrid;
            this.verzorgerdatagrid = verzorgerDatagrid;
            verzorgerComboBox.DataSource = verzorgerDatagrid.DataSource;
        }

        private void VoegPatientForm_Load(object sender, EventArgs e)
        {
            //IEnumerable<Vraag> vragen = getVragenByVragenlijstId(vragenlijstId).Result;
            IEnumerable<Patientmantelzorger> verzorger = getVerzorger("http://finahweb.azurewebsites.net/api/patientmantelzorger/true").Result;
            verzorgerComboBox.DataSource = verzorger;

            foreach (Patientmantelzorger vraag in verzorger)
            {
                Console.WriteLine();
                Console.WriteLine("VraagId: " + vraag.Id + "Beschrijving :" + vraag.Anaam);
            }
        }

        public Task<IEnumerable<Patientmantelzorger>> getVerzorger(string baseUrl)
        {

            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Patientmantelzorger>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Patientmantelzorger[]>(json);
            });
        }

        private void voegPatientButton_Click(object sender, EventArgs e)
        {
            datagrid.Rows.Add(voornaamTextBox.Text, naamTextBox.Text, emailTextBox.Text, verzorgerComboBox.SelectedText);
        }

        private void voegVerzorgerButton_Click(object sender, EventArgs e)
        {
            Form form = new VoegVerzorgerForm(verzorgerdatagrid);
            form.ShowDialog();
        }
    }
}
