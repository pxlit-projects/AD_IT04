namespace net.finah
{
    partial class voegPatientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.voornaamTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.verzorgerComboBox = new System.Windows.Forms.ComboBox();
            this.voegPatientButton = new System.Windows.Forms.Button();
            this.voegVerzorgerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "e-mail : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mantelzorger : ";
            // 
            // voornaamTextBox
            // 
            this.voornaamTextBox.Location = new System.Drawing.Point(95, 12);
            this.voornaamTextBox.Name = "voornaamTextBox";
            this.voornaamTextBox.Size = new System.Drawing.Size(277, 20);
            this.voornaamTextBox.TabIndex = 4;
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(95, 38);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(277, 20);
            this.naamTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(95, 64);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(277, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // verzorgerComboBox
            // 
            this.verzorgerComboBox.FormattingEnabled = true;
            this.verzorgerComboBox.Location = new System.Drawing.Point(95, 90);
            this.verzorgerComboBox.Name = "verzorgerComboBox";
            this.verzorgerComboBox.Size = new System.Drawing.Size(277, 21);
            this.verzorgerComboBox.TabIndex = 7;
            // 
            // voegPatientButton
            // 
            this.voegPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voegPatientButton.Location = new System.Drawing.Point(258, 129);
            this.voegPatientButton.Name = "voegPatientButton";
            this.voegPatientButton.Size = new System.Drawing.Size(114, 30);
            this.voegPatientButton.TabIndex = 9;
            this.voegPatientButton.Text = "Toevoegen";
            this.voegPatientButton.UseVisualStyleBackColor = true;
            this.voegPatientButton.Click += new System.EventHandler(this.voegPatientButton_Click);
            // 
            // voegVerzorgerButton
            // 
            this.voegVerzorgerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voegVerzorgerButton.Location = new System.Drawing.Point(12, 129);
            this.voegVerzorgerButton.Name = "voegVerzorgerButton";
            this.voegVerzorgerButton.Size = new System.Drawing.Size(155, 30);
            this.voegVerzorgerButton.TabIndex = 10;
            this.voegVerzorgerButton.Text = "Voeg verzorger toe";
            this.voegVerzorgerButton.UseVisualStyleBackColor = true;
            this.voegVerzorgerButton.Click += new System.EventHandler(this.voegVerzorgerButton_Click);
            // 
            // voegPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 171);
            this.Controls.Add(this.voegVerzorgerButton);
            this.Controls.Add(this.voegPatientButton);
            this.Controls.Add(this.verzorgerComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.voornaamTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "voegPatientForm";
            this.Text = "Patient toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox voornaamTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox verzorgerComboBox;
        private System.Windows.Forms.Button voegPatientButton;
        private System.Windows.Forms.Button voegVerzorgerButton;
    }
}