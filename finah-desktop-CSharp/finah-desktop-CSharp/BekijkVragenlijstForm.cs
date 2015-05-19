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
        private List<Vraag> vragenList;
        private DbFunctions dbfunctions;

        public BekijkVragenlijstForm(int vragenlijstId, String beschrijving)
        {
            InitializeComponent();
            this.vragenlijstId = vragenlijstId;
            this.beschrijving = beschrijving;
            dbfunctions = new DbFunctions();

            vragenList = dbfunctions.loadVragenByVragenlijstId(vragenlijstId);

            VragenlijstBeschrijving.Text = beschrijving;

            if (vragenList != null)
            {
                bekijkVragenlijstDataGridView.DataSource = vragenList;
                bekijkVragenlijstDataGridView.Columns["Id"].Visible = false;
                bekijkVragenlijstDataGridView.Columns["Vragenlijst_Id"].Visible = false;
            }
        }

        //
        // Piece of code I found online for preventing screen flickering
        //
        //
        int originalExStyle = -1;
        bool enableFormLevelDoubleBuffering = true;

        protected override CreateParams CreateParams
        {
            get
            {
                if (originalExStyle == -1)
                    originalExStyle = base.CreateParams.ExStyle;

                CreateParams cp = base.CreateParams;
                if (enableFormLevelDoubleBuffering)
                    cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                else
                    cp.ExStyle = originalExStyle;

                return cp;
            }
        }

        private void TurnOffFormLevelDoubleBuffering()
        {
            enableFormLevelDoubleBuffering = false;
            this.MaximizeBox = true;
        }

        private void BekijkVragenlijstForm_Shown(object sender, EventArgs e)
        {
            TurnOffFormLevelDoubleBuffering();
        }
        //
        //
        //
        //
    }
}
