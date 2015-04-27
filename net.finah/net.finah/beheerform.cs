using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net.finah
{
    public partial class beheerform : Form
    {
        public beheerform()
        {
            InitializeComponent();
        }

        private void voegPatientToeButton_Click(object sender, EventArgs e)
        {
            Form patientForm = new voegPatientForm();
            patientForm.ShowDialog();
        }

        private void voegVerzorgerToeButton_Click(object sender, EventArgs e)
        {
            Form verzorgerForm = new voegVerzorgerForm();
            verzorgerForm.ShowDialog();
        }

        private void voegVragenlijstButton_Click(object sender, EventArgs e)
        {
            Form vragenlijstForm = new aanVragenlijstForm();
            vragenlijstForm.ShowDialog();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
