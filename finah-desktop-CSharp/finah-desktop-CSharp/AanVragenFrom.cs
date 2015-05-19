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
        private int id = 0;
        private BindingList<Vraag> list = new BindingList<Vraag>();
        private DataGridView datagridview;

        public AanVragenFrom(DataGridView datagridview, ref BindingList<Vraag>list)
        {
            InitializeComponent();
            this.list = list;
            this.datagridview = datagridview;
        }

        public AanVragenFrom(string beschrijving, DataGridView datagridview, ref BindingList<Vraag>list, int indexVraag)
        {
            InitializeComponent();
            vraagTextBox.Text = list[indexVraag].Beschrijving;
            id = indexVraag;
            this.datagridview = datagridview;
            this.list = list;
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
            Vraag vraag = new Vraag();

            if (Convert.ToString(id) == "0")
            {
                int idd = 0;

                foreach (Vraag idvraag in list)
                {
                    if (idvraag.Id < idd)
                    {
                        idd = idvraag.Id;
                    }
                }
                idd =+ 1;

                Console.WriteLine(idd);

                vraag.Id = idd;
                vraag.Beschrijving = vraagTextBox.Text;
                list.Add(vraag);
                //List.Add(
            }
            else
            {
                list[id].Beschrijving = vraagTextBox.Text;
            }

            //datagridview.Rows.Add(vraagTextBox.Text);
            datagridview.DataSource = null;
            datagridview.DataSource = list;
            datagridview.Columns["Id"].Visible = false;
            datagridview.Columns["Beschrijving"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.Close();
        }

        private void annulerenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
    }
}
