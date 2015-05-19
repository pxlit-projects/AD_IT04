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
        private BindingList<Patientmantelzorger> list;
        private DataGridView datagrid;
        private int Dokter_Id;
        private DbFunctions dbfunctions;

        public VoegVerzorgerForm(ref BindingList<Patientmantelzorger> list, DataGridView datagrid, int dokter_Id)
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
            dbfunctions.postMantelzorger(mantelzorger);

            this.Close();
        }

    }
}
