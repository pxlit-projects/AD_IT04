namespace finah_desktop_CSharp
{
    partial class BeheerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeheerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.patientButton = new System.Windows.Forms.Button();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.verzorgerButton = new System.Windows.Forms.Button();
            this.verzorgerDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.voegVragenlijstButton = new System.Windows.Forms.Button();
            this.bekijkVragenlijst = new System.Windows.Forms.Button();
            this.vragenlijstDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rapportDetailButton = new System.Windows.Forms.Button();
            this.rapportDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnVerstuur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVragenlijst = new System.Windows.Forms.ComboBox();
            this.comboBoxMantelzorger = new System.Windows.Forms.ComboBox();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verzorgerDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vragenlijstDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rapportDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(3656, 1513);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.patientButton);
            this.tabPage1.Controls.Add(this.patientDataGridView);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(3648, 1463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patienten";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // patientButton
            // 
            this.patientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.patientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientButton.Location = new System.Drawing.Point(1254, 850);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(350, 67);
            this.patientButton.TabIndex = 1;
            this.patientButton.Text = "Voeg patiënt toe";
            this.patientButton.UseVisualStyleBackColor = false;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.AllowUserToResizeColumns = false;
            this.patientDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.patientDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.patientDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.patientDataGridView.Location = new System.Drawing.Point(4, 4);
            this.patientDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.patientDataGridView.MultiSelect = false;
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            this.patientDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.patientDataGridView.RowTemplate.Height = 33;
            this.patientDataGridView.Size = new System.Drawing.Size(1600, 800);
            this.patientDataGridView.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.verzorgerButton);
            this.tabPage2.Controls.Add(this.verzorgerDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(3648, 1463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantelzorgers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // verzorgerButton
            // 
            this.verzorgerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.verzorgerButton.Location = new System.Drawing.Point(1254, 850);
            this.verzorgerButton.Name = "verzorgerButton";
            this.verzorgerButton.Size = new System.Drawing.Size(350, 67);
            this.verzorgerButton.TabIndex = 2;
            this.verzorgerButton.Text = "Voeg verzorger toe";
            this.verzorgerButton.UseVisualStyleBackColor = false;
            this.verzorgerButton.Click += new System.EventHandler(this.verzorgerButton_Click_1);
            // 
            // verzorgerDataGridView
            // 
            this.verzorgerDataGridView.AllowUserToAddRows = false;
            this.verzorgerDataGridView.AllowUserToDeleteRows = false;
            this.verzorgerDataGridView.AllowUserToResizeColumns = false;
            this.verzorgerDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.verzorgerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.verzorgerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.verzorgerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.verzorgerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.verzorgerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verzorgerDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::finah_desktop_CSharp.Properties.Settings.Default, "ff", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.verzorgerDataGridView.Font = global::finah_desktop_CSharp.Properties.Settings.Default.ff;
            this.verzorgerDataGridView.Location = new System.Drawing.Point(4, 4);
            this.verzorgerDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.verzorgerDataGridView.MultiSelect = false;
            this.verzorgerDataGridView.Name = "verzorgerDataGridView";
            this.verzorgerDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4);
            this.verzorgerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.verzorgerDataGridView.Size = new System.Drawing.Size(1600, 800);
            this.verzorgerDataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.voegVragenlijstButton);
            this.tabPage3.Controls.Add(this.bekijkVragenlijst);
            this.tabPage3.Controls.Add(this.vragenlijstDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage3.Size = new System.Drawing.Size(3648, 1463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vragenlijsten";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // voegVragenlijstButton
            // 
            this.voegVragenlijstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.voegVragenlijstButton.Location = new System.Drawing.Point(1254, 850);
            this.voegVragenlijstButton.Name = "voegVragenlijstButton";
            this.voegVragenlijstButton.Size = new System.Drawing.Size(350, 67);
            this.voegVragenlijstButton.TabIndex = 2;
            this.voegVragenlijstButton.Text = "Nieuwe vragenlijst";
            this.voegVragenlijstButton.UseVisualStyleBackColor = false;
            this.voegVragenlijstButton.Click += new System.EventHandler(this.voegVragenlijstButton_Click);
            // 
            // bekijkVragenlijst
            // 
            this.bekijkVragenlijst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.bekijkVragenlijst.Location = new System.Drawing.Point(851, 850);
            this.bekijkVragenlijst.Name = "bekijkVragenlijst";
            this.bekijkVragenlijst.Size = new System.Drawing.Size(350, 67);
            this.bekijkVragenlijst.TabIndex = 1;
            this.bekijkVragenlijst.Text = "Bekijk vragenlijst";
            this.bekijkVragenlijst.UseVisualStyleBackColor = false;
            this.bekijkVragenlijst.Click += new System.EventHandler(this.bekijkVragenlijst_Click);
            // 
            // vragenlijstDataGridView
            // 
            this.vragenlijstDataGridView.AllowUserToAddRows = false;
            this.vragenlijstDataGridView.AllowUserToDeleteRows = false;
            this.vragenlijstDataGridView.AllowUserToResizeColumns = false;
            this.vragenlijstDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.vragenlijstDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.vragenlijstDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vragenlijstDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.vragenlijstDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vragenlijstDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vragenlijstDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::finah_desktop_CSharp.Properties.Settings.Default, "ff", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.vragenlijstDataGridView.Font = global::finah_desktop_CSharp.Properties.Settings.Default.ff;
            this.vragenlijstDataGridView.Location = new System.Drawing.Point(4, 4);
            this.vragenlijstDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.vragenlijstDataGridView.MultiSelect = false;
            this.vragenlijstDataGridView.Name = "vragenlijstDataGridView";
            this.vragenlijstDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(4);
            this.vragenlijstDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.vragenlijstDataGridView.Size = new System.Drawing.Size(1600, 800);
            this.vragenlijstDataGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.rapportDetailButton);
            this.tabPage4.Controls.Add(this.rapportDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 46);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(3648, 1463);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rapporten";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rapportDetailButton
            // 
            this.rapportDetailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.rapportDetailButton.Location = new System.Drawing.Point(1254, 850);
            this.rapportDetailButton.Name = "rapportDetailButton";
            this.rapportDetailButton.Size = new System.Drawing.Size(350, 67);
            this.rapportDetailButton.TabIndex = 2;
            this.rapportDetailButton.Text = "Bekijk rapport";
            this.rapportDetailButton.UseVisualStyleBackColor = false;
            this.rapportDetailButton.Click += new System.EventHandler(this.rapportDetailButton_Click_1);
            // 
            // rapportDataGridView
            // 
            this.rapportDataGridView.AllowUserToAddRows = false;
            this.rapportDataGridView.AllowUserToDeleteRows = false;
            this.rapportDataGridView.AllowUserToResizeColumns = false;
            this.rapportDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.rapportDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.rapportDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rapportDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rapportDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rapportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapportDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::finah_desktop_CSharp.Properties.Settings.Default, "ff", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rapportDataGridView.Font = global::finah_desktop_CSharp.Properties.Settings.Default.ff;
            this.rapportDataGridView.Location = new System.Drawing.Point(4, 4);
            this.rapportDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.rapportDataGridView.MultiSelect = false;
            this.rapportDataGridView.Name = "rapportDataGridView";
            this.rapportDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(4);
            this.rapportDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.rapportDataGridView.Size = new System.Drawing.Size(1600, 800);
            this.rapportDataGridView.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = global::finah_desktop_CSharp.Properties.Resources._11264430_962915657081985_435153716_o;
            this.tabPage5.Controls.Add(this.btnVerstuur);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.comboBoxVragenlijst);
            this.tabPage5.Controls.Add(this.comboBoxMantelzorger);
            this.tabPage5.Controls.Add(this.comboBoxPatient);
            this.tabPage5.Location = new System.Drawing.Point(4, 46);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(3648, 1463);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Vragenlijst versturen";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnVerstuur
            // 
            this.btnVerstuur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.btnVerstuur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerstuur.Location = new System.Drawing.Point(574, 529);
            this.btnVerstuur.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerstuur.Name = "btnVerstuur";
            this.btnVerstuur.Size = new System.Drawing.Size(350, 67);
            this.btnVerstuur.TabIndex = 6;
            this.btnVerstuur.Text = "Versturen";
            this.btnVerstuur.UseVisualStyleBackColor = false;
            this.btnVerstuur.Click += new System.EventHandler(this.btnVerstuur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vragenlijst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mantelzorger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patiënt";
            // 
            // comboBoxVragenlijst
            // 
            this.comboBoxVragenlijst.FormattingEnabled = true;
            this.comboBoxVragenlijst.Location = new System.Drawing.Point(560, 372);
            this.comboBoxVragenlijst.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVragenlijst.Name = "comboBoxVragenlijst";
            this.comboBoxVragenlijst.Size = new System.Drawing.Size(364, 45);
            this.comboBoxVragenlijst.TabIndex = 2;
            // 
            // comboBoxMantelzorger
            // 
            this.comboBoxMantelzorger.FormattingEnabled = true;
            this.comboBoxMantelzorger.Location = new System.Drawing.Point(560, 279);
            this.comboBoxMantelzorger.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMantelzorger.Name = "comboBoxMantelzorger";
            this.comboBoxMantelzorger.Size = new System.Drawing.Size(364, 45);
            this.comboBoxMantelzorger.TabIndex = 1;
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(560, 189);
            this.comboBoxPatient.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(364, 45);
            this.comboBoxPatient.TabIndex = 0;
            // 
            // BeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finah_desktop_CSharp.Properties.Resources._11264430_962915657081985_435153716_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2548, 1310);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BeheerForm";
            this.Text = "Beheer";
            this.Load += new System.EventHandler(this.BeheerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verzorgerDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vragenlijstDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rapportDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView verzorgerDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView vragenlijstDataGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView rapportDataGridView;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnVerstuur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVragenlijst;
        private System.Windows.Forms.ComboBox comboBoxMantelzorger;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button voegVragenlijstButton;
        private System.Windows.Forms.Button bekijkVragenlijst;
        private System.Windows.Forms.Button verzorgerButton;
        private System.Windows.Forms.Button rapportDetailButton;
    }
}