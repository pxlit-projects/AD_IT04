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
    public partial class AanVragenFrom : Form
    {
        private DataGridView datagridview;

        public AanVragenFrom(DataGridView datagridview)
        {
            InitializeComponent();
            this.datagridview = datagridview;
        }

        public AanVragenFrom(string beschrijving, DataGridView datagridview)
        {
            InitializeComponent();
            vraagTextBox.Text = beschrijving;
            this.datagridview = datagridview;

        }

        private void AanVragenFrom_Load(object sender, EventArgs e)
        {

        }

        private void verkennerButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(dialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            datagridview.Rows.Add(vraagTextBox.Text);
            this.Close();
        }

        private void annulerenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
    }
}
