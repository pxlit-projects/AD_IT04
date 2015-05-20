namespace finah_desktop_CSharp
{
    partial class BekijkVragenlijstForm
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
            this.bekijkVragenlijstDataGridView = new System.Windows.Forms.DataGridView();
            this.VragenlijstBeschrijving = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bekijkVragenlijstDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bekijkVragenlijstDataGridView
            // 
            this.bekijkVragenlijstDataGridView.AllowUserToResizeColumns = false;
            this.bekijkVragenlijstDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.bekijkVragenlijstDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bekijkVragenlijstDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bekijkVragenlijstDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bekijkVragenlijstDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bekijkVragenlijstDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bekijkVragenlijstDataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::finah_desktop_CSharp.Properties.Settings.Default, "ff", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bekijkVragenlijstDataGridView.Font = global::finah_desktop_CSharp.Properties.Settings.Default.ff;
            this.bekijkVragenlijstDataGridView.Location = new System.Drawing.Point(12, 87);
            this.bekijkVragenlijstDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bekijkVragenlijstDataGridView.Name = "bekijkVragenlijstDataGridView";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            this.bekijkVragenlijstDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.bekijkVragenlijstDataGridView.RowTemplate.Height = 33;
            this.bekijkVragenlijstDataGridView.Size = new System.Drawing.Size(2338, 777);
            this.bekijkVragenlijstDataGridView.TabIndex = 0;
            // 
            // VragenlijstBeschrijving
            // 
            this.VragenlijstBeschrijving.AutoSize = true;
            this.VragenlijstBeschrijving.BackColor = System.Drawing.Color.Transparent;
            this.VragenlijstBeschrijving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VragenlijstBeschrijving.Location = new System.Drawing.Point(22, 17);
            this.VragenlijstBeschrijving.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VragenlijstBeschrijving.Name = "VragenlijstBeschrijving";
            this.VragenlijstBeschrijving.Size = new System.Drawing.Size(338, 37);
            this.VragenlijstBeschrijving.TabIndex = 1;
            this.VragenlijstBeschrijving.Text = "VragenlijstBeschrijving";
            // 
            // BekijkVragenlijstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finah_desktop_CSharp.Properties.Resources._11264430_962915657081985_435153716_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2356, 873);
            this.Controls.Add(this.VragenlijstBeschrijving);
            this.Controls.Add(this.bekijkVragenlijstDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BekijkVragenlijstForm";
            this.Text = "BekijkVragenlijstForm";
            ((System.ComponentModel.ISupportInitialize)(this.bekijkVragenlijstDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bekijkVragenlijstDataGridView;
        private System.Windows.Forms.Label VragenlijstBeschrijving;
    }
}