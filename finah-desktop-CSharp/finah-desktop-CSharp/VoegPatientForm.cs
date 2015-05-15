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
        private List<Patientmantelzorger> list;
        private DataGridView datagrid;
        private int dokter_Id;
        private DbFunctions dbfunctions;

        public VoegPatientForm(ref List<Patientmantelzorger> list, DataGridView datagrid, int dokter_Id)
        {
            InitializeComponent();
            this.list = list;
            this.datagrid = datagrid;
            this.dokter_Id = dokter_Id;
            dbfunctions = new DbFunctions();
        }

        private void voegPatientButton_Click(object sender, EventArgs e)
        {
            Patientmantelzorger patient = new Patientmantelzorger();

            patient.Vnaam = voornaamTextBox.Text;
            patient.Anaam = naamTextBox.Text;
            patient.Email = emailTextBox.Text;
            patient.Verzorger = false;
            patient.Dokter_Id = dokter_Id;

            list.Add(patient);

            // Met deze functie wordt de patient toegevoegd aan de database
           // dbfunctions.postPatient(patient);

            this.Close();
        }

        private void VoegPatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            datagrid.DataSource = null;
            datagrid.DataSource = list;
            datagrid.Columns["Id"].Visible = false;
            datagrid.Columns["Verzorger"].Visible = false;
            datagrid.Columns["Dokter_Id"].Visible = false;
        }

    }
}
