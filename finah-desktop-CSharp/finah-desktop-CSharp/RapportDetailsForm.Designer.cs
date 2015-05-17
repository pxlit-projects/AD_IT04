namespace finah_desktop_CSharp
{
    partial class RapportDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rapportDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.patientlabel = new System.Windows.Forms.Label();
            this.mantelzorgerLabel = new System.Windows.Forms.Label();
            this.VragenlijstLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.rapportDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rapportDetailsDataGridView
            // 
            this.rapportDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapportDetailsDataGridView.Location = new System.Drawing.Point(30, 153);
            this.rapportDetailsDataGridView.Name = "rapportDetailsDataGridView";
            this.rapportDetailsDataGridView.RowTemplate.Height = 33;
            this.rapportDetailsDataGridView.Size = new System.Drawing.Size(1490, 877);
            this.rapportDetailsDataGridView.TabIndex = 0;
            // 
            // patientlabel
            // 
            this.patientlabel.AutoSize = true;
            this.patientlabel.Location = new System.Drawing.Point(25, 38);
            this.patientlabel.Name = "patientlabel";
            this.patientlabel.Size = new System.Drawing.Size(79, 25);
            this.patientlabel.TabIndex = 1;
            this.patientlabel.Text = "Patiënt";
            // 
            // mantelzorgerLabel
            // 
            this.mantelzorgerLabel.AutoSize = true;
            this.mantelzorgerLabel.Location = new System.Drawing.Point(25, 86);
            this.mantelzorgerLabel.Name = "mantelzorgerLabel";
            this.mantelzorgerLabel.Size = new System.Drawing.Size(138, 25);
            this.mantelzorgerLabel.TabIndex = 2;
            this.mantelzorgerLabel.Text = "Mantelzorger";
            // 
            // VragenlijstLabel
            // 
            this.VragenlijstLabel.AutoSize = true;
            this.VragenlijstLabel.Location = new System.Drawing.Point(390, 86);
            this.VragenlijstLabel.Name = "VragenlijstLabel";
            this.VragenlijstLabel.Size = new System.Drawing.Size(113, 25);
            this.VragenlijstLabel.TabIndex = 3;
            this.VragenlijstLabel.Text = "Vragenlijst";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(390, 38);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(74, 25);
            this.datumLabel.TabIndex = 4;
            this.datumLabel.Text = "Datum";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(832, 56);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(180, 55);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // RapportDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 1060);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.VragenlijstLabel);
            this.Controls.Add(this.mantelzorgerLabel);
            this.Controls.Add(this.patientlabel);
            this.Controls.Add(this.rapportDetailsDataGridView);
            this.Name = "RapportDetailsForm";
            this.Text = "RapportDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.rapportDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rapportDetailsDataGridView;
        private System.Windows.Forms.Label patientlabel;
        private System.Windows.Forms.Label mantelzorgerLabel;
        private System.Windows.Forms.Label VragenlijstLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}