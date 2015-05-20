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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.rapportDetailsDataGridView.AllowUserToAddRows = false;
            this.rapportDetailsDataGridView.AllowUserToDeleteRows = false;
            this.rapportDetailsDataGridView.AllowUserToResizeColumns = false;
            this.rapportDetailsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.rapportDetailsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rapportDetailsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rapportDetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rapportDetailsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rapportDetailsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rapportDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapportDetailsDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::finah_desktop_CSharp.Properties.Settings.Default, "ff", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rapportDetailsDataGridView.Font = global::finah_desktop_CSharp.Properties.Settings.Default.ff;
            this.rapportDetailsDataGridView.Location = new System.Drawing.Point(4, 144);
            this.rapportDetailsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.rapportDetailsDataGridView.Name = "rapportDetailsDataGridView";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            this.rapportDetailsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.rapportDetailsDataGridView.RowTemplate.Height = 33;
            this.rapportDetailsDataGridView.Size = new System.Drawing.Size(1800, 800);
            this.rapportDetailsDataGridView.TabIndex = 0;
            // 
            // patientlabel
            // 
            this.patientlabel.AutoSize = true;
            this.patientlabel.BackColor = System.Drawing.Color.Transparent;
            this.patientlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.patientlabel.Location = new System.Drawing.Point(24, 10);
            this.patientlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientlabel.Name = "patientlabel";
            this.patientlabel.Size = new System.Drawing.Size(116, 37);
            this.patientlabel.TabIndex = 1;
            this.patientlabel.Text = "Patiënt";
            // 
            // mantelzorgerLabel
            // 
            this.mantelzorgerLabel.AutoSize = true;
            this.mantelzorgerLabel.BackColor = System.Drawing.Color.Transparent;
            this.mantelzorgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mantelzorgerLabel.Location = new System.Drawing.Point(22, 87);
            this.mantelzorgerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mantelzorgerLabel.Name = "mantelzorgerLabel";
            this.mantelzorgerLabel.Size = new System.Drawing.Size(203, 37);
            this.mantelzorgerLabel.TabIndex = 2;
            this.mantelzorgerLabel.Text = "Mantelzorger";
            // 
            // VragenlijstLabel
            // 
            this.VragenlijstLabel.AutoSize = true;
            this.VragenlijstLabel.BackColor = System.Drawing.Color.Transparent;
            this.VragenlijstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VragenlijstLabel.Location = new System.Drawing.Point(598, 87);
            this.VragenlijstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VragenlijstLabel.Name = "VragenlijstLabel";
            this.VragenlijstLabel.Size = new System.Drawing.Size(167, 37);
            this.VragenlijstLabel.TabIndex = 3;
            this.VragenlijstLabel.Text = "Vragenlijst";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.BackColor = System.Drawing.Color.Transparent;
            this.datumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datumLabel.Location = new System.Drawing.Point(598, 10);
            this.datumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(112, 37);
            this.datumLabel.TabIndex = 4;
            this.datumLabel.Text = "Datum";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExport.Location = new System.Drawing.Point(1454, 37);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(350, 67);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // RapportDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finah_desktop_CSharp.Properties.Resources._11264430_962915657081985_435153716_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2548, 1079);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.VragenlijstLabel);
            this.Controls.Add(this.mantelzorgerLabel);
            this.Controls.Add(this.patientlabel);
            this.Controls.Add(this.rapportDetailsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
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