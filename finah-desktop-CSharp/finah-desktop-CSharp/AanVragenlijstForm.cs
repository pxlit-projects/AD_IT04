using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finah_desktop_CSharp
{
    public partial class AanVragenlijstForm : Form
    {
        private BindingList<Vragenlijst> vragenlijstList;
        private DataGridView vragenlijstDatagrid; //verniewen van datagridview beheerFrom
        private BindingList<Vraag> toeVragenList;//toegevoegde vragen van de vragenlijst
        private List<Vraag> vragenList; //alle vragen
        private DbFunctions dbfunctions;
        private int dokterId;

        public AanVragenlijstForm(ref BindingList<Vragenlijst> vragenlijstList, DataGridView datagrid, int dokterId)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            this.vragenlijstList = vragenlijstList;
            this.vragenlijstDatagrid = datagrid;
            toeVragenList = new BindingList<Vraag>();
            dbfunctions = new DbFunctions();
            this.dokterId = dokterId;

            toeVragenDataGridView.DataSource = toeVragenList;
            toeVragenDataGridView.Columns["Id"].Visible = false;
            toeVragenDataGridView.Columns["Vragenlijst_Id"].Visible = false;
            toeVragenDataGridView.Columns["Beschrijving"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void AanVragenlijstForm_Load(object sender, EventArgs e)
        {
            vragenList = dbfunctions.loadAlleVragen();
            if (vragenList != null)
            {
                vragenDataGridView.DataSource = vragenList;
                vragenDataGridView.Columns["Id"].Visible = false;
                vragenDataGridView.Columns["Vragenlijst_Id"].Visible = false;
                vragenDataGridView.Columns["Beschrijving"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void toevoegButton_Click(object sender, EventArgs e)
        {
            try
            {
                toeVragenList.Add(vragenList[vragenDataGridView.CurrentCell.RowIndex]);
            }
            catch { }
        }

        private void verwijderButton_Click(object sender, EventArgs e)
        {
            try
            {
                int idVraag = toeVragenDataGridView.CurrentCell.RowIndex;
                toeVragenList.RemoveAt(idVraag);
            }
            catch { }
        }

        private void nieuwButton_Click(object sender, EventArgs e)
        {
            Form form = new AanVragenFrom(toeVragenDataGridView, ref toeVragenList);
            form.ShowDialog();
        }

        private void opslaanButton_Click(object sender, EventArgs e)
        {
            if (!beschrijvingTextBox.Text.Equals(""))
            {
                String beschrijving = beschrijvingTextBox.Text;

                Vragenlijst vragenlijst = new Vragenlijst() { Beschrijving = beschrijving, Dokter_Id = dokterId };

                vragenlijstList.Add(vragenlijst);

                int vragenlijstId = dbfunctions.postVragenlijst(vragenlijst);

                foreach (Vraag vraag in toeVragenList)
                {
                    vraag.Vragenlijst_Id = vragenlijstId;
                    dbfunctions.postVraag(vraag);
                }

                this.Close();
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

        private void Aanvragenform_Shown(object sender, EventArgs e)
        {
            TurnOffFormLevelDoubleBuffering();
        }
        //
        //
        //
        //
    }
}
