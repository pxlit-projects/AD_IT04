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
        private DataGridView datagrid;

        public VoegVerzorgerForm(DataGridView datagrid)
        {
            InitializeComponent();
            this.datagrid = datagrid;
        }

        private void voegVerzorgerButton_Click(object sender, EventArgs e)
        {
            //datagrid.Rows.Add(new Patientmantelzorger(voornaamTextBox.Text, naamTextBox.Text, emailTextBox.Text));
            this.Close();
        }
    }
}
