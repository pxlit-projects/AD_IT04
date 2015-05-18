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
            this.rapportDetailsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rapportDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapportDetailsDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::finah_desktop_CSharp.Properties.Settings.Default, "ff", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rapportDetailsDataGridView.Font = global::finah_desktop_CSharp.Properties.Settings.Default.ff;
            this.rapportDetailsDataGridView.Location = new System.Drawing.Point(2, 75);
            this.rapportDetailsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rapportDetailsDataGridView.Name = "rapportDetailsDataGridView";
            this.rapportDetailsDataGridView.RowTemplate.Height = 33;
            this.rapportDetailsDataGridView.Size = new System.Drawing.Size(780, 380);
            this.rapportDetailsDataGridView.TabIndex = 0;
            // 
            // patientlabel
            // 
            this.patientlabel.AutoSize = true;
            this.patientlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.patientlabel.Location = new System.Drawing.Point(12, 5);
            this.patientlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientlabel.Name = "patientlabel";
            this.patientlabel.Size = new System.Drawing.Size(59, 20);
            this.patientlabel.TabIndex = 1;
            this.patientlabel.Text = "Patiënt";
            // 
            // mantelzorgerLabel
            // 
            this.mantelzorgerLabel.AutoSize = true;
            this.mantelzorgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mantelzorgerLabel.Location = new System.Drawing.Point(11, 45);
            this.mantelzorgerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mantelzorgerLabel.Name = "mantelzorgerLabel";
            this.mantelzorgerLabel.Size = new System.Drawing.Size(102, 20);
            this.mantelzorgerLabel.TabIndex = 2;
            this.mantelzorgerLabel.Text = "Mantelzorger";
            // 
            // VragenlijstLabel
            // 
            this.VragenlijstLabel.AutoSize = true;
            this.VragenlijstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VragenlijstLabel.Location = new System.Drawing.Point(299, 45);
            this.VragenlijstLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VragenlijstLabel.Name = "VragenlijstLabel";
            this.VragenlijstLabel.Size = new System.Drawing.Size(83, 20);
            this.VragenlijstLabel.TabIndex = 3;
            this.VragenlijstLabel.Text = "Vragenlijst";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datumLabel.Location = new System.Drawing.Point(299, 5);
            this.datumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(57, 20);
            this.datumLabel.TabIndex = 4;
            this.datumLabel.Text = "Datum";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExport.Location = new System.Drawing.Point(605, 5);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(175, 35);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // RapportDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finah_desktop_CSharp.Properties.Resources._11264430_962915657081985_435153716_o;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.VragenlijstLabel);
            this.Controls.Add(this.mantelzorgerLabel);
            this.Controls.Add(this.patientlabel);
            this.Controls.Add(this.rapportDetailsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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