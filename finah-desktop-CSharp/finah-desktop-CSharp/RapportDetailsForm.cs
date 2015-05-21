using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace finah_desktop_CSharp
{
    public partial class RapportDetailsForm : Form
    {
        private int rapportId;
        private int patientId;
        private int mantelzorgerId;
        private int vragenlijstId;
        private DateTime datum;
        private List<Antwoord> antwoordList;
        private List<Vraag> vraagList;
        private List<RapportDetailsModel> rapportDetailsModelList;
        private DbFunctions dbfunctions;
        private String[] antwoordBeschrijvingen = new String[] { "Verloopt naar wensen", "Niet hinderlijk", "Hinderlijk voor Pätiënt", "Hinderlijk voor mantelzorger", "Hinderlijk voor beide" };
        private String[] antwoordExtraBeschrijvingen = new String[] { "", "Ja", "Nee" };

        ScreenCapture capScreen = new ScreenCapture();

        public RapportDetailsForm(int rapportId, int patientId, int mantelzorgerId, int vragenlijstId, DateTime datum)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();

            this.rapportId = rapportId;
            this.patientId = patientId;
            this.mantelzorgerId = mantelzorgerId;
            this.vragenlijstId = vragenlijstId;
            this.datum = datum;
            dbfunctions = new DbFunctions();
            rapportDetailsModelList = new List<RapportDetailsModel>();

            Patientmantelzorger patient = dbfunctions.loadPatientMantelzorger(patientId).First();
            Patientmantelzorger mantelzorger = dbfunctions.loadPatientMantelzorger(mantelzorgerId).First();
            Vragenlijst vragenlijst = dbfunctions.loadVragenlijst(vragenlijstId).First();

            patientlabel.Text = "Patiënt: " + patient.Vnaam + " " + patient.Anaam;
            mantelzorgerLabel.Text = "Mantelzorger: " + mantelzorger.Vnaam + " " + mantelzorger.Anaam;
            datumLabel.Text = "Datum: " + datum.ToString();
            VragenlijstLabel.Text = "Vragenlijst: " + vragenlijst.Beschrijving;

            antwoordList = dbfunctions.loadAntwoordenByRapportId(rapportId);
            if (antwoordList != null)
            {
                vraagList = dbfunctions.loadVragenByVragenlijstId(vragenlijstId);

                int i = 0;

                foreach (Vraag vraag in vraagList)
                {
                    RapportDetailsModel rapportDetailsModel = new RapportDetailsModel()
                    {
                        vraagBeschrijving = vraagList[i].Beschrijving,
                        antwoordPatient = antwoordBeschrijvingen[antwoordList[i].AntwoordInt - 1],
                        antwoordMantelzorger = antwoordBeschrijvingen[antwoordList[i + vraagList.Count()].AntwoordInt - 1],
                        extraAntwoordPatient = antwoordExtraBeschrijvingen[antwoordList[i].AntwoordExtra],
                        extraAntwoordMantelzorger = antwoordExtraBeschrijvingen[antwoordList[i + vraagList.Count()].AntwoordExtra],
                    };

                    rapportDetailsModelList.Add(rapportDetailsModel);

                    i++;
                }

                rapportDetailsDataGridView.DataSource = rapportDetailsModelList;
                rapportDetailsDataGridView.Columns[0].HeaderText = "Vraag";
                rapportDetailsDataGridView.Columns[1].HeaderText = "Patiënt";
                rapportDetailsDataGridView.Columns[2].HeaderText = "Mantelzorger";
                rapportDetailsDataGridView.Columns[3].HeaderText = "Wil patiënt hier aan werken?";
                rapportDetailsDataGridView.Columns[4].HeaderText = "Wil mantelzorger hier aan werken?";
            }
        }

        private void captureScreen()
        {
            try
            {
                // Call the CaptureAndSave method from the ScreenCapture class 
                // And create a temporary file in C:\Temp
                capScreen.CaptureAndSave
                (@"C:\Temp\test.png", CaptureMode.Window, ImageFormat.Png);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Call your captureScreen() function
            captureScreen();

            // Create new pdf document and page
            PdfDocument doc = new PdfDocument();
            PdfPage oPage = new PdfPage();

            // Add the page to the pdf document and add the captured image to it
            doc.Pages.Add(oPage);
            XGraphics xgr = XGraphics.FromPdfPage(oPage);
            XImage img = XImage.FromFile(@"C:\Temp\test.png");
            xgr.DrawImage(img, 0, 0);

            saveFileDialog.Filter = ("PDF File|*.pdf");
            DialogResult btnSave = saveFileDialog.ShowDialog();
            if (btnSave.Equals(DialogResult.OK))
            {
                doc.Save(saveFileDialog.FileName);
                doc.Close();
            }

            // I used the Dispose() function to be able to 
            // save the same form again, in case some values have changed.
            // When I didn't use the function, a GDI+ error occurred.
            img.Dispose();
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

        private void RapportDetails_Shown(object sender, EventArgs e)
        {
            TurnOffFormLevelDoubleBuffering();
        }
        //
        //
        //
        //
    }
}
