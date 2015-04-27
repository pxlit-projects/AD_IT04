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
    public partial class voegPatientForm : Form
    {
        public voegPatientForm()
        {
            InitializeComponent();
        }

        private void voegVerzorgerButton_Click(object sender, EventArgs e)
        {
            Form verzorgerForm = new voegVerzorgerForm();
            verzorgerForm.ShowDialog();
        }

        private void voegPatientButton_Click(object sender, EventArgs e)
        {
            // het opslaan van het patient
        }


    }
}
