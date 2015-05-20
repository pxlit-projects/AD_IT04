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
        private BindingList<Vraag> list = new BindingList<Vraag>();
        private DataGridView datagridview;

        public AanVragenFrom(DataGridView datagridview, ref BindingList<Vraag> list)
        {
            InitializeComponent();
            this.list = list;
            this.datagridview = datagridview;
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            Vraag vraag = new Vraag() { Beschrijving = vraagTextBox.Text };

            list.Add(vraag);

            this.Close();
        }

        private void annulerenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
