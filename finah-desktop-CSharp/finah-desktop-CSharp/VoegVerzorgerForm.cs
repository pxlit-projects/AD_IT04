using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finah_desktop_CSharp
{
    public partial class VoegVerzorgerForm : Form
    {
        private List<Patientmantelzorger> list;
        private DataGridView datagrid;
        private int Dokter_Id;
        private DbFunctions dbfunctions;

        public VoegVerzorgerForm(ref List<Patientmantelzorger> list, DataGridView datagrid, int dokter_Id)
        {
            InitializeComponent();
            this.list = list;
            this.datagrid = datagrid;
            this.Dokter_Id = dokter_Id;
            dbfunctions = new DbFunctions();        
        }

        private void voegVerzorgerButton_Click(object sender, EventArgs e)
        {
            Patientmantelzorger mantelzorger = new Patientmantelzorger();

            mantelzorger.Vnaam = voornaamTextBox.Text;
            mantelzorger.Anaam = naamTextBox.Text;
            mantelzorger.Email = emailTextBox.Text;
            mantelzorger.Verzorger = true;
            mantelzorger.Dokter_Id = Dokter_Id;            

            list.Add(mantelzorger);

            //Met deze functie wordt de mantelzorger toegevoegd aan de database
            //dbfunctions.postMantelzorger(mantelzorger);

            this.Close();
        }

        private void VoegVerzorgerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            datagrid.DataSource = null;
            datagrid.DataSource = list;
            datagrid.Columns["Id"].Visible = false;
            datagrid.Columns["Verzorger"].Visible = false;
            datagrid.Columns["Dokter_Id"].Visible = false;
        }

    }
}
