namespace finah_desktop_CSharp
{
    partial class AanVragenlijstForm
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
            this.opslaanButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.beschrijvingTextBox = new System.Windows.Forms.TextBox();
            this.nieuwButton = new System.Windows.Forms.Button();
            this.verwijderButton = new System.Windows.Forms.Button();
            this.toevoegButton = new System.Windows.Forms.Button();
            this.vragenDataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toeVragenDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vragenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toeVragenDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // opslaanButton
            // 
            this.opslaanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.opslaanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opslaanButton.Location = new System.Drawing.Point(1313, 997);
            this.opslaanButton.Margin = new System.Windows.Forms.Padding(6);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(240, 67);
            this.opslaanButton.TabIndex = 3;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = false;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::finah_desktop_CSharp.Properties.Resources._11264430_962915657081985_435153716_o;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.beschrijvingTextBox);
            this.tabPage2.Controls.Add(this.nieuwButton);
            this.tabPage2.Controls.Add(this.verwijderButton);
            this.tabPage2.Controls.Add(this.toevoegButton);
            this.tabPage2.Controls.Add(this.vragenDataGridView);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.toeVragenDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1554, 921);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vragen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Beschrijving";
            // 
            // beschrijvingTextBox
            // 
            this.beschrijvingTextBox.Location = new System.Drawing.Point(231, 27);
            this.beschrijvingTextBox.Name = "beschrijvingTextBox";
            this.beschrijvingTextBox.Size = new System.Drawing.Size(268, 44);
            this.beschrijvingTextBox.TabIndex = 8;
            // 
            // nieuwButton
            // 
            this.nieuwButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nieuwButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.nieuwButton.Location = new System.Drawing.Point(785, 544);
            this.nieuwButton.Margin = new System.Windows.Forms.Padding(6);
            this.nieuwButton.Name = "nieuwButton";
            this.nieuwButton.Size = new System.Drawing.Size(200, 67);
            this.nieuwButton.TabIndex = 7;
            this.nieuwButton.Text = "Nieuw";
            this.nieuwButton.UseVisualStyleBackColor = false;
            this.nieuwButton.Click += new System.EventHandler(this.nieuwButton_Click);
            // 
            // verwijderButton
            // 
            this.verwijderButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.verwijderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.verwijderButton.Location = new System.Drawing.Point(785, 357);
            this.verwijderButton.Margin = new System.Windows.Forms.Padding(6);
            this.verwijderButton.Name = "verwijderButton";
            this.verwijderButton.Size = new System.Drawing.Size(200, 67);
            this.verwijderButton.TabIndex = 5;
            this.verwijderButton.Text = "Verwijderen";
            this.verwijderButton.UseVisualStyleBackColor = false;
            this.verwijderButton.Click += new System.EventHandler(this.verwijderButton_Click);
            // 
            // toevoegButton
            // 
            this.toevoegButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toevoegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.toevoegButton.Location = new System.Drawing.Point(785, 233);
            this.toevoegButton.Margin = new System.Windows.Forms.Padding(6);
            this.toevoegButton.Name = "toevoegButton";
            this.toevoegButton.Size = new System.Drawing.Size(200, 67);
            this.toevoegButton.TabIndex = 4;
            this.toevoegButton.Text = "Toevoegen";
            this.toevoegButton.UseVisualStyleBackColor = false;
            this.toevoegButton.Click += new System.EventHandler(this.toevoegButton_Click);
            // 
            // vragenDataGridView
            // 
            this.vragenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vragenDataGridView.Location = new System.Drawing.Point(32, 147);
            this.vragenDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.vragenDataGridView.Name = "vragenDataGridView";
            this.vragenDataGridView.Size = new System.Drawing.Size(696, 750);
            this.vragenDataGridView.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 37);
            this.label9.TabIndex = 2;
            this.label9.Text = "Vragen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1015, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "Toegevoegde vragen";
            // 
            // toeVragenDataGridView
            // 
            this.toeVragenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toeVragenDataGridView.Location = new System.Drawing.Point(1022, 147);
            this.toeVragenDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.toeVragenDataGridView.Name = "toeVragenDataGridView";
            this.toeVragenDataGridView.Size = new System.Drawing.Size(480, 750);
            this.toeVragenDataGridView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1562, 971);
            this.tabControl1.TabIndex = 2;
            // 
            // AanVragenlijstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finah_desktop_CSharp.Properties.Resources._11264430_962915657081985_435153716_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1568, 1079);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AanVragenlijstForm";
            this.Text = "Vragenlijst";
            this.Load += new System.EventHandler(this.AanVragenlijstForm_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vragenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toeVragenDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button nieuwButton;
        private System.Windows.Forms.Button verwijderButton;
        private System.Windows.Forms.Button toevoegButton;
        private System.Windows.Forms.DataGridView vragenDataGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView toeVragenDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox beschrijvingTextBox;
    }
}