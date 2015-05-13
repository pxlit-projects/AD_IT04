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

        public VoegPatientForm(DataGridView datagrid)
        {
            InitializeComponent();
            this.datagrid = datagrid;
        }

        private void VoegPatientForm_Load(object sender, EventArgs e)
        {
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

    }
}
