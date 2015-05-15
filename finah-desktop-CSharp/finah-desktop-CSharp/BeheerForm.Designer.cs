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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.voegPatientToeButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.voegVerzorgerToeButton = new System.Windows.Forms.Button();
            this.verzorgerDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.voegVragenlijstButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.vragenlijstDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rapportDataGridView = new System.Windows.Forms.DataGridView();
            this.rapportDetailButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verzorgerDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vragenlijstDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rapportDataGridView)).BeginInit();
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 560);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.patientDataGridView);
            this.tabPage1.Controls.Add(this.voegPatientToeButton);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patienten";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::finah_desktop_CSharp.Properties.Settings.Default, "ff", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.patientDataGridView.Font = global::finah_desktop_CSharp.Properties.Settings.Default.ff;
            this.patientDataGridView.Location = new System.Drawing.Point(3, 3);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            this.patientDataGridView.Size = new System.Drawing.Size(760, 471);
            this.patientDataGridView.TabIndex = 1;
            // 
            // voegPatientToeButton
            // 
            this.voegPatientToeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voegPatientToeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.voegPatientToeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voegPatientToeButton.Location = new System.Drawing.Point(626, 483);
            this.voegPatientToeButton.Name = "voegPatientToeButton";
            this.voegPatientToeButton.Size = new System.Drawing.Size(140, 35);
            this.voegPatientToeButton.TabIndex = 0;
            this.voegPatientToeButton.Text = "Voeg patient toe";
            this.voegPatientToeButton.UseVisualStyleBackColor = false;
            this.voegPatientToeButton.Click += new System.EventHandler(this.voegPatientToeButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.voegVerzorgerToeButton);
            this.tabPage2.Controls.Add(this.verzorgerDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantelzorgers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // voegVerzorgerToeButton
            // 
            this.voegVerzorgerToeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voegVerzorgerToeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.voegVerzorgerToeButton.Location = new System.Drawing.Point(591, 483);
            this.voegVerzorgerToeButton.Name = "voegVerzorgerToeButton";
            this.voegVerzorgerToeButton.Size = new System.Drawing.Size(175, 35);
            this.voegVerzorgerToeButton.TabIndex = 1;
            this.voegVerzorgerToeButton.Text = "Voeg verzorger toe";
            this.voegVerzorgerToeButton.UseVisualStyleBackColor = false;
            this.voegVerzorgerToeButton.Click += new System.EventHandler(this.voegVerzorgerToeButton_Click);
            // 
            // verzorgerDataGridView
            // 
            this.verzorgerDataGridView.AllowUserToAddRows = false;
            this.verzorgerDataGridView.AllowUserToDeleteRows = false;
            this.verzorgerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verzorgerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verzorgerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.verzorgerDataGridView.Name = "verzorgerDataGridView";
            this.verzorgerDataGridView.ReadOnly = true;
            this.verzorgerDataGridView.Size = new System.Drawing.Size(759, 467);
            this.verzorgerDataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.voegVragenlijstButton);
            this.tabPage3.Controls.Add(this.detailsButton);
            this.tabPage3.Controls.Add(this.vragenlijstDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(772, 527);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vragenlijsten";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // voegVragenlijstButton
            // 
            this.voegVragenlijstButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voegVragenlijstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.voegVragenlijstButton.Location = new System.Drawing.Point(6, 486);
            this.voegVragenlijstButton.Name = "voegVragenlijstButton";
            this.voegVragenlijstButton.Size = new System.Drawing.Size(175, 35);
            this.voegVragenlijstButton.TabIndex = 2;
            this.voegVragenlijstButton.Text = "Vragenlijst aanmaken";
            this.voegVragenlijstButton.UseVisualStyleBackColor = false;
            this.voegVragenlijstButton.Click += new System.EventHandler(this.voegVragenlijstButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.detailsButton.Location = new System.Drawing.Point(589, 486);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(177, 35);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "Vragenlijst bewerken";
            this.detailsButton.UseVisualStyleBackColor = false;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // vragenlijstDataGridView
            // 
            this.vragenlijstDataGridView.AllowUserToAddRows = false;
            this.vragenlijstDataGridView.AllowUserToDeleteRows = false;
            this.vragenlijstDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vragenlijstDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vragenlijstDataGridView.Location = new System.Drawing.Point(6, 3);
            this.vragenlijstDataGridView.Name = "vragenlijstDataGridView";
            this.vragenlijstDataGridView.ReadOnly = true;
            this.vragenlijstDataGridView.Size = new System.Drawing.Size(756, 473);
            this.vragenlijstDataGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.rapportDataGridView);
            this.tabPage4.Controls.Add(this.rapportDetailButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(772, 527);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rapporten";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rapportDataGridView
            // 
            this.rapportDataGridView.AllowUserToAddRows = false;
            this.rapportDataGridView.AllowUserToDeleteRows = false;
            this.rapportDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rapportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapportDataGridView.Location = new System.Drawing.Point(3, 3);
            this.rapportDataGridView.Name = "rapportDataGridView";
            this.rapportDataGridView.ReadOnly = true;
            this.rapportDataGridView.Size = new System.Drawing.Size(760, 474);
            this.rapportDataGridView.TabIndex = 1;
            // 
            // rapportDetailButton
            // 
            this.rapportDetailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rapportDetailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.rapportDetailButton.Location = new System.Drawing.Point(619, 485);
            this.rapportDetailButton.Name = "rapportDetailButton";
            this.rapportDetailButton.Size = new System.Drawing.Size(150, 35);
            this.rapportDetailButton.TabIndex = 0;
            this.rapportDetailButton.Text = "Meer informatie";
            this.rapportDetailButton.UseVisualStyleBackColor = false;
            this.rapportDetailButton.Click += new System.EventHandler(this.rapportDetailButton_Click);
            // 
            // BeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finah_desktop_CSharp.Properties.Resources._11264430_962915657081985_435153716_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Button voegPatientToeButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button voegVerzorgerToeButton;
        private System.Windows.Forms.DataGridView verzorgerDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button voegVragenlijstButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.DataGridView vragenlijstDataGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView rapportDataGridView;
        private System.Windows.Forms.Button rapportDetailButton;
    }
}