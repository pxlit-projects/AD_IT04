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
            this.bekijkVragenlijstDataGridView = new System.Windows.Forms.DataGridView();
            this.VragenlijstBeschrijving = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bekijkVragenlijstDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bekijkVragenlijstDataGridView
            // 
            this.bekijkVragenlijstDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bekijkVragenlijstDataGridView.Location = new System.Drawing.Point(12, 87);
            this.bekijkVragenlijstDataGridView.Name = "bekijkVragenlijstDataGridView";
            this.bekijkVragenlijstDataGridView.RowTemplate.Height = 33;
            this.bekijkVragenlijstDataGridView.Size = new System.Drawing.Size(1019, 777);
            this.bekijkVragenlijstDataGridView.TabIndex = 0;
            // 
            // VragenlijstBeschrijving
            // 
            this.VragenlijstBeschrijving.AutoSize = true;
            this.VragenlijstBeschrijving.Location = new System.Drawing.Point(12, 41);
            this.VragenlijstBeschrijving.Name = "VragenlijstBeschrijving";
            this.VragenlijstBeschrijving.Size = new System.Drawing.Size(230, 25);
            this.VragenlijstBeschrijving.TabIndex = 1;
            this.VragenlijstBeschrijving.Text = "VragenlijstBeschrijving";
            // 
            // BekijkVragenlijstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 876);
            this.Controls.Add(this.VragenlijstBeschrijving);
            this.Controls.Add(this.bekijkVragenlijstDataGridView);
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