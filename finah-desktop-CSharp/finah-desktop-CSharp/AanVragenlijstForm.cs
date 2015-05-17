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
        private DataGridView datagrid; //verniewen van datagridview beheerFrom
        private DbFunctions dbfunctions = new DbFunctions();
        private List<Vraag> toeVragenList = new List<Vraag>(); //toegevoegde vragen van de vragenlijst
        private List<Vraag> vragenList = new List<Vraag>(); //alle vragen
        private int dokterId;
        private List<Vragenlijst> vragenlijstList;

        public AanVragenlijstForm(ref List<Vragenlijst> vragenlijstList, DataGridView datagrid, int dokterId)
        {
            InitializeComponent();
            this.dokterId = dokterId;
            this.vragenlijstList = vragenlijstList;
            this.datagrid = datagrid;

            toeVragenDataGridView.DataSource = toeVragenList;
            toeVragenDataGridView.Columns["Id"].Visible = false;
            toeVragenDataGridView.Columns["Beschrijving"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;        
        }

        private void AanVragenlijstForm_Load(object sender, EventArgs e)
        {
            vragenList = dbfunctions.loadAlleVragen();
            vragenDataGridView.DataSource = vragenList;
            vragenDataGridView.Columns["Id"].Visible = false;
            vragenDataGridView.Columns["Beschrijving"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void toevoegButton_Click(object sender, EventArgs e)
        {
            try
            {
                toeVragenList.Add(vragenList[vragenDataGridView.CurrentCell.RowIndex]);
            }
            catch { }

            toeVragenDataGridView.DataSource = null;
            toeVragenDataGridView.DataSource = toeVragenList;
            toeVragenDataGridView.Columns["Id"].Visible = false;
            toeVragenDataGridView.Columns["Beschrijving"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void verwijderButton_Click(object sender, EventArgs e)
        {
            try
            {
                int idVraag = toeVragenDataGridView.CurrentCell.RowIndex;
                toeVragenList.RemoveAt(idVraag);
            }
            catch { }

            toeVragenDataGridView.DataSource = null;
            toeVragenDataGridView.DataSource = toeVragenList;
            toeVragenDataGridView.Columns["Id"].Visible = false;
            toeVragenDataGridView.Columns["Beschrijving"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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


                int vragenlijstId = dbfunctions.postVragenlijst(vragenlijst);

                foreach (Vraag vraag in toeVragenList)
                {
                    vraag.Vragenlijst_Id = vragenlijstId;
                    dbfunctions.postVraag(vraag);
                }

                vragenlijstList.Add(vragenlijst);

                this.Close();
            }
        }

        private void AanVragenlijstForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            datagrid.DataSource = null;
            datagrid.DataSource = vragenlijstList;
            datagrid.Columns["Id"].Visible = false;
            datagrid.Columns["Dokter_Id"].Visible = false;
        }

    }
}
