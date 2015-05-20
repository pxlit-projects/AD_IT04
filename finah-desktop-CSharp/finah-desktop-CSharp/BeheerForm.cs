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

        private BindingList<Patientmantelzorger> patientList = new BindingList<Patientmantelzorger>();
        private BindingList<Patientmantelzorger> mantelzorgerList = new BindingList<Patientmantelzorger>();
        private List<Rapport> rapportList = new List<Rapport>();
        private BindingList<RapportViewModel> rapportViewModelList = new BindingList<RapportViewModel>();
        private BindingList<Vragenlijst> vragenlijstList;
        private int dokter_Id;

        public BeheerForm(int dokter_Id)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            this.dokter_Id = dokter_Id;
        }

        private void BeheerForm_Load(object sender, EventArgs e)
        {
            List<Patientmantelzorger> patientHulpList = dbfunctions.loadPatienten(dokter_Id);
            if (patientHulpList != null)
            {
                patientList = new BindingList<Patientmantelzorger>(patientHulpList);
                patientDataGridView.DataSource = patientList;
                patientDataGridView.Columns["Id"].Visible = false;
                patientDataGridView.Columns["Verzorger"].Visible = false;
                patientDataGridView.Columns["Dokter_Id"].Visible = false;
                patientDataGridView.Columns["FullName"].Visible = false;
                this.patientDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.patientDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.patientDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            List<Patientmantelzorger> mantelzorgerHulpList = dbfunctions.loadVerzorgers(dokter_Id);
            if (mantelzorgerHulpList != null)
            {
                mantelzorgerList = new BindingList<Patientmantelzorger>(mantelzorgerHulpList);
                verzorgerDataGridView.DataSource = mantelzorgerList;
                verzorgerDataGridView.Columns["Id"].Visible = false;
                verzorgerDataGridView.Columns["Verzorger"].Visible = false;
                verzorgerDataGridView.Columns["Dokter_Id"].Visible = false;
                verzorgerDataGridView.Columns["FullName"].Visible = false;
                this.verzorgerDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.verzorgerDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.verzorgerDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            List<Vragenlijst> vragenlijstHulpList = dbfunctions.loadVragenlijsten(dokter_Id);
            if (vragenlijstHulpList != null)
            {
                vragenlijstList = new BindingList<Vragenlijst>(vragenlijstHulpList);
                vragenlijstDataGridView.DataSource = vragenlijstList;
                vragenlijstDataGridView.Columns["Id"].Visible = false;
                vragenlijstDataGridView.Columns["Dokter_Id"].Visible = false;
                this.vragenlijstDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            rapportList = dbfunctions.loadRapport(dokter_Id);
            if (rapportList != null)
            {
                foreach (Rapport rapport in rapportList)
                {
                    Patientmantelzorger patient = dbfunctions.loadPatientMantelzorger(rapport.Patient_Id).First();
                    Patientmantelzorger mantelzorger = dbfunctions.loadPatientMantelzorger(rapport.Mantelzorger_Id).First();
                    Vragenlijst vragenlijst = dbfunctions.loadVragenlijst(rapport.Vragenlijst_Id).First();
                    rapportViewModelList.Add(new RapportViewModel()
                    {
                        PatientNaam = patient.Vnaam + " " + patient.Anaam,
                        MantelzorgerNaam = mantelzorger.Vnaam + " " + mantelzorger.Anaam,
                        Date = rapport.Date,
                        VragenlijstBeschrijving = vragenlijst.Beschrijving
                    });
                }

                rapportDataGridView.DataSource = rapportViewModelList;
                this.rapportDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.rapportDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.rapportDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.rapportDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            comboBoxPatient.DataSource = patientHulpList;
            comboBoxPatient.DisplayMember = "FullName";
            comboBoxPatient.ValueMember = "Id";

            comboBoxMantelzorger.DataSource = mantelzorgerHulpList;
            comboBoxMantelzorger.DisplayMember = "FullName";
            comboBoxMantelzorger.ValueMember = "Id";

            comboBoxVragenlijst.DataSource = vragenlijstHulpList;
            comboBoxVragenlijst.DisplayMember = "Beschrijving";
            comboBoxVragenlijst.ValueMember = "Id";
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            Form patientForm = new VoegPatientForm(ref patientList, patientDataGridView, dokter_Id);
            patientForm.ShowDialog();
        }

        private void verzorgerButton_Click_1(object sender, EventArgs e)
        {
            Form verzorgerForm = new VoegVerzorgerForm(ref mantelzorgerList, verzorgerDataGridView, dokter_Id);
            verzorgerForm.ShowDialog();
        }

        private void voegVragenlijstButton_Click(object sender, EventArgs e)
        {
            Form vragenlijstForm = new AanVragenlijstForm(ref vragenlijstList, vragenlijstDataGridView, dokter_Id);
            vragenlijstForm.ShowDialog();
        }

        private void bekijkVragenlijst_Click(object sender, EventArgs e)
        {
            Vragenlijst vragenlijst = vragenlijstList[vragenlijstDataGridView.CurrentCell.RowIndex];
            int vragenlijstId = vragenlijst.Id;
            String beschrijving = vragenlijst.Beschrijving;
            Form bekijkvragenlijstForm = new BekijkVragenlijstForm(vragenlijstId, beschrijving);
            bekijkvragenlijstForm.ShowDialog();
        }

        private void rapportDetailButton_Click_1(object sender, EventArgs e)
        {
            Rapport rapport = rapportList[rapportDataGridView.CurrentCell.RowIndex];
            Form rapportDetailsForm = new RapportDetailsForm(rapport.Id, rapport.Patient_Id, rapport.Mantelzorger_Id, rapport.Vragenlijst_Id, rapport.Date);
            rapportDetailsForm.ShowDialog();
        }

        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            int patientId = (int)comboBoxPatient.SelectedValue;
            int mantelzorgerId = (int)comboBoxMantelzorger.SelectedValue;
            int vragenlijstId = (int)comboBoxVragenlijst.SelectedValue;

            Rapport rapport = new Rapport()
            {
                Patient_Id = patientId,
                Mantelzorger_Id = mantelzorgerId,
                Vragenlijst_Id = vragenlijstId,
                Date = DateTime.Now,
                Dokter_Id = dokter_Id
            };

            Patientmantelzorger patient = dbfunctions.loadPatientMantelzorger(rapport.Patient_Id).First();
            Patientmantelzorger mantelzorger = dbfunctions.loadPatientMantelzorger(rapport.Mantelzorger_Id).First();
            Vragenlijst vragenlijst = dbfunctions.loadVragenlijst(rapport.Vragenlijst_Id).First();

            rapportViewModelList.Add(new RapportViewModel()
            {
                PatientNaam = patient.Vnaam + " " + patient.Anaam,
                MantelzorgerNaam = mantelzorger.Vnaam + " " + mantelzorger.Anaam,
                Date = rapport.Date,
                VragenlijstBeschrijving = vragenlijst.Beschrijving
            });

            int rapportId = dbfunctions.postRapport(rapport);

            //new VerstuurVragenlijst().sendMessage(patientId, mantelzorgerId, rapportId, vragenlijstId);

            MessageBox.Show(
                "De vragenlijst '" + comboBoxVragenlijst.Text
                + "' is verstuurd naar patiënt " + comboBoxPatient.Text
                + " en naar mantelzorger " + comboBoxMantelzorger.Text
                + ".", "Finah", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //
        // Piece of code I found online for preventing screen flickering
        //
        //
        int originalExStyle = -1;
        bool enableFormLevelDoubleBuffering = true;

        protected override CreateParams CreateParams
        {
            get
            {
                if (originalExStyle == -1)
                    originalExStyle = base.CreateParams.ExStyle;

                CreateParams cp = base.CreateParams;
                if (enableFormLevelDoubleBuffering)
                    cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                else
                    cp.ExStyle = originalExStyle;

                return cp;
            }
        }

        private void TurnOffFormLevelDoubleBuffering()
        {
            enableFormLevelDoubleBuffering = false;
            this.MaximizeBox = true;
        }

        private void BeheerForm_Shown(object sender, EventArgs e)
        {
            TurnOffFormLevelDoubleBuffering();
        }
        //
        //
        //
        //
    }
}
