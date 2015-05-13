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

        private List<Patientmantelzorger> patientenList = new List<Patientmantelzorger>();
        private List<Patientmantelzorger> verzorgerList = new List<Patientmantelzorger>();
        private List<Rapport> rapportList = new List<Rapport>();
        private List<Vragenlijst> vragenlijstList = new List<Vragenlijst>();

        public BeheerForm()
        {
            InitializeComponent();
        }

        private void BeheerForm_Load(object sender, EventArgs e)
        {
            patientenList = dbfunctions.loadPatienten();
            patientDataGridView.DataSource = patientenList;

            verzorgerList = dbfunctions.loadVerzorger();
            verzorgerDataGridView.DataSource = verzorgerList;
            verzorgerDataGridView.Columns["Verzorger"].Visible = false;
            verzorgerDataGridView.Columns["Dokter_Id"].Visible = false;


            rapportList = dbfunctions.loadRapport();
            vragenlijstList = dbfunctions.loadVragenlijsten();


            //Patientmantelzorger patient = new Patientmantelzorger();
            //patient.Id = 88;
            //patient.Vnaam = "Pietje";
            //patient.Anaam = "Peeters";
            //patient.Email = "azeazeazeazeaze";
            //patient.Verzorger = false;
            //patient.Dokter_Id = 0;


            //patientenList.Add(patient);



            //patientDataGridView.DataSource = null;
            //patientDataGridView.DataSource = patientenList;

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
