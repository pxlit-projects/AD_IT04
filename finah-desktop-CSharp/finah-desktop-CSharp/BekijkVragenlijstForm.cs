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
    public partial class BekijkVragenlijstForm : Form
    {
        private int vragenlijstId;
        private String beschrijving;
        private List<Vraag> vragenList = new List<Vraag>();
        private DbFunctions dbfunctions = new DbFunctions();

        public BekijkVragenlijstForm(int vragenlijstId, String beschrijving)
        {
            InitializeComponent();
            this.vragenlijstId = vragenlijstId;
            this.beschrijving = beschrijving;

            vragenList = dbfunctions.loadVragenByVragenlijstId(vragenlijstId);

            VragenlijstBeschrijving.Text = beschrijving;

            if (vragenList != null)
            {
                bekijkVragenlijstDataGridView.DataSource = vragenList;
                bekijkVragenlijstDataGridView.Columns["Id"].Visible = false;
                bekijkVragenlijstDataGridView.Columns["Vragenlijst_Id"].Visible = false;
            }
        }
    }
}
