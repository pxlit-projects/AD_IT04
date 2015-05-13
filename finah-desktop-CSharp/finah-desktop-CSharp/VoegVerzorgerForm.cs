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

        public VoegVerzorgerForm(ref List<Patientmantelzorger> list, DataGridView datagrid)
        {
            InitializeComponent();
            this.list = list;
            this.datagrid = datagrid;

            int idd= 0;

            foreach (Patientmantelzorger id in list)
	        {
		         if(id.Id > idd)
                    {
                    idd = id.Id;
                }
	        }
            idd+=1;
            idTextBox.Text = idd.ToString();
        }

        private void voegVerzorgerButton_Click(object sender, EventArgs e)
        {
            Patientmantelzorger patient = new Patientmantelzorger();

            patient.Id = Convert.ToInt32(idTextBox.Text);
            patient.Vnaam = voornaamTextBox.Text;
            patient.Anaam = naamTextBox.Text;
            patient.Email = emailTextBox.Text;

            list.Add(patient);


            //toevoegen aan database

            this.Close();
        }

        private void VoegVerzorgerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            datagrid.DataSource = null;
            datagrid.DataSource = list;
            datagrid.Columns["Verzorger"].Visible = false;
            datagrid.Columns["Dokter_Id"].Visible = false;
        }

    }
}
