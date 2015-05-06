using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace net.finah
{
    public partial class aanVragenlijstForm : Form
    {
        public aanVragenlijstForm()
        {
            InitializeComponent();
        }

        private void aanVragenlijstForm_Load(object sender, EventArgs e)
        {
            //vragenDataGridView.DataSource = API.DB.getVragen();

            int vragenlijstId = 1;

            IEnumerable<Vraag> vragen = getVragenByVragenlijstId(vragenlijstId).Result;

            foreach (Vraag vraag in vragen)
            {
                Console.WriteLine();
                Console.WriteLine("VraagId: " + vraag.Id + "Beschrijving :" + vraag.Beschrijving);
            }
        }

        public Task<IEnumerable<Vraag>> getVragenByVragenlijstId(int vragenlijstId)
        {
            string baseUrl = "http://finahweb.azurewebsites.net/api/vraag/" + vragenlijstId;

            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Vraag>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Vraag[]>(json);
            });
        }
    }
}
