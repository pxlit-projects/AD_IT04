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
        private DbFunctions dbfunctions = new DbFunctions();

        private List<Patientmantelzorger> patientList = new List<Patientmantelzorger>();
        private List<Patientmantelzorger> mantelzorgerList = new List<Patientmantelzorger>();
        private List<Rapport> rapportList = new List<Rapport>();
        private List<Vragenlijst> vragenlijstList = new List<Vragenlijst>();

        private int dokter_Id;

        public BeheerForm(int dokter_Id)
        {
            InitializeComponent();
            this.dokter_Id = dokter_Id;
        }

        private void BeheerForm_Load(object sender, EventArgs e)
        {
            patientList = dbfunctions.loadPatienten(dokter_Id);
            patientDataGridView.DataSource = patientList;
            patientDataGridView.Columns["Id"].Visible = false;
            patientDataGridView.Columns["Verzorger"].Visible = false;
            patientDataGridView.Columns["Dokter_Id"].Visible = false;
            this.patientDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.patientDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            mantelzorgerList = dbfunctions.loadVerzorger(dokter_Id);
            verzorgerDataGridView.DataSource = mantelzorgerList;
            verzorgerDataGridView.Columns["Id"].Visible = false;
            verzorgerDataGridView.Columns["Verzorger"].Visible = false;
            verzorgerDataGridView.Columns["Dokter_Id"].Visible = false;

            vragenlijstList = dbfunctions.loadVragenlijsten(dokter_Id);
            vragenlijstDataGridView.DataSource = vragenlijstList;
            //vragenlijstDataGridView.Columns["Id"].Visible = false;
            vragenlijstDataGridView.Columns["Dokter_Id"].Visible = false;

            rapportList = dbfunctions.loadRapport(dokter_Id);
            rapportDataGridView.DataSource = rapportList;
            rapportDataGridView.Columns["Id"].Visible = false;
        }

        private void voegPatientToeButton_Click(object sender, EventArgs e)
        {
            Form patientForm = new VoegPatientForm(ref patientList, patientDataGridView, dokter_Id);
            patientForm.ShowDialog();
        }

        private void voegVerzorgerToeButton_Click(object sender, EventArgs e)
        {
            Form verzorgerForm = new VoegVerzorgerForm(ref mantelzorgerList, verzorgerDataGridView, dokter_Id);
            verzorgerForm.ShowDialog();
        }














        private void voegVragenlijstButton_Click(object sender, EventArgs e)
        {
            Form vragenlijstForm = new AanVragenlijstForm(ref vragenlijstList, patientList, mantelzorgerList, vragenlijstDataGridView);
            vragenlijstForm.ShowDialog();
        }

        private void rapportDetailButton_Click(object sender, EventArgs e)
        {
            /* Form form = new VragenlijstForm();
             form.ShowDialog();*/
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            int id;

            id = Convert.ToInt32(vragenlijstDataGridView.SelectedCells[0].Value.ToString());
            Console.WriteLine(id);


            Form vragenlijstForm = new AanVragenlijstForm(ref vragenlijstList, patientList, mantelzorgerList, vragenlijstDataGridView, id);
            vragenlijstForm.ShowDialog();
        }
    }
}
