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
    public partial class AanVragenlijstForm : Form
    {
        private DataGridView datagrid; //verniewen van datagridview beheerFrom
        private DbFunctions dbfunctions = new DbFunctions();
        private List<Vraag> toeVragenList = new List<Vraag>(); //toegevoegde vragen van de vragenlijst
        private List<Vraag> vragenList = new List<Vraag>(); //alle vragen
        private List<Vragenlijst> vragenlijstList = new List<Vragenlijst>(); //vragenlijsten van beheerForm
        private List<Patientmantelzorger> patientList = new List<Patientmantelzorger>(); //
        private List<Patientmantelzorger> verzorgerList = new List<Patientmantelzorger>();

        public AanVragenlijstForm(ref List<Vragenlijst> list, List<Patientmantelzorger> patient, List<Patientmantelzorger> verzorger, DataGridView datagrid)
        {
            InitializeComponent();

            this.datagrid = datagrid;
            vragenlijstList = list;

            int idd = 0;

            foreach (Vragenlijst id in list)
            {
                if (id.Id > idd)
                {
                    idd = id.Id;
                }
            }
            idd += 1;
            idLabel.Text = idd.ToString();

            foreach (Patientmantelzorger pat in patientList)
            {
                clientComboBox.Items.Add(pat.Vnaam.ToString());
            }

       }

        public AanVragenlijstForm(ref List<Vragenlijst> list, List<Patientmantelzorger> patient, List<Patientmantelzorger> verzorger, DataGridView datagrid, int vragenID) 
        {
            InitializeComponent();

            toeVragenList = dbfunctions.loadVragen();
            toeVragenDataGridView.DataSource = toeVragenList;
            //toeVragenDataGridView.Columns["Verzorger"].Visible = false;
            //toeVragenDataGridView.Columns["Dokter_Id"].Visible = false;

            this.datagrid = datagrid;

            idLabel.Text = vragenID.ToString();

            toeVragenList = dbfunctions.getVragelijst(vragenID);
            toeVragenDataGridView.DataSource = toeVragenList;
            toeVragenDataGridView.Columns["Id"].Visible = false;
            toeVragenDataGridView.Columns["Beschrijving"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void AanVragenlijstForm_Load(object sender, EventArgs e)
        {

            vragenList = dbfunctions.loadVragen();
            vragenDataGridView.DataSource = vragenList;
            vragenDataGridView.Columns["Id"].Visible = false;
            vragenDataGridView.Columns["Beschrijving"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            clientComboBox.DisplayMember = "Vnaam";
            clientComboBox.ValueMember = "Vnaam";
            clientComboBox.DataSource = patientList;
            verzorgerComboBox.DataSource = verzorgerList;

            

            //vragenDataGridView.Columns["Vragenlijst_Id"].Visible = false;

          /*  //vragenDataGridView.DataSource = API.DB.getVragen();

            //int vragenlijstId = 1;

            //IEnumerable<Vraag> vragen = getVragenByVragenlijstId(vragenlijstId).Result;
            IEnumerable<Vraag> vragen = getVragen().Result;
            vragenDataGridView.DataSource = vragen;

            foreach (Vraag vraag in vragen)
            {
                Console.WriteLine();
                Console.WriteLine("VraagId: " + vraag.Id + "Beschrijving :" + vraag.Beschrijving);

                
            }*/
        }


        /*public Task<IEnumerable<Vraag>> getVragenByVragenlijstId(int vragenlijstId)
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
        

        public Task<IEnumerable<Vraag>> getVragen()
        {
            string baseUrl = "http://finahweb.azurewebsites.net/api/vraag/";

            var client = new HttpClient();
            var task = client.GetStringAsync(baseUrl);

            return task.ContinueWith<IEnumerable<Vraag>>(innerTask =>
            {
                var json = innerTask.Result;
                return JsonConvert.DeserializeObject<Vraag[]>(json);
            });
        }*/

        private void toevoegButton_Click(object sender, EventArgs e)
        {
           //toeVragenDataGridView.Rows.Add(vragenDataGridView.SelectedRows.);

            toeVragenList.Add(vragenList[vragenDataGridView.CurrentCell.RowIndex]);

            toeVragenDataGridView.DataSource = null;
            toeVragenDataGridView.DataSource = toeVragenList;
            toeVragenDataGridView.Columns["Id"].Visible = false;
            toeVragenDataGridView.Columns["Beschrijving"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
       
        }

        private void verwijderButton_Click(object sender, EventArgs e)
        {
            if (toeVragenDataGridView.SelectedRows.Count > 0)
            {
                int idVraag = toeVragenDataGridView.CurrentCell.RowIndex;
                toeVragenList.RemoveAt(idVraag);
            }
            

            toeVragenDataGridView.DataSource = null;
            toeVragenDataGridView.DataSource = toeVragenList;
            toeVragenDataGridView.Columns["Id"].Visible = false;
            toeVragenDataGridView.Columns["Beschrijving"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

           // toeVragenDataGridView.Rows.Remove(toeVragenDataGridView.CurrentRow);
        }

        private void nieuwButton_Click(object sender, EventArgs e)
        {
            Form form = new AanVragenFrom(toeVragenDataGridView, ref toeVragenList);
            form.ShowDialog();
        }

        private void bewerkButton_Click(object sender, EventArgs e)
        {
            if (toeVragenDataGridView.CurrentCell.Value != null)
            {
                string beschrijving = toeVragenDataGridView.CurrentCell.Value.ToString();
                Form form = new AanVragenFrom(beschrijving, toeVragenDataGridView, ref toeVragenList, toeVragenDataGridView.CurrentCell.RowIndex);
                form.ShowDialog();
            }
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            ///moet nog gemaakt worden
        }

        private void clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
