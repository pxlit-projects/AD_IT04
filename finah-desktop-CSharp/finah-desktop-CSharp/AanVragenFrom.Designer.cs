namespace finah_desktop_CSharp
{
    partial class AanVragenFrom
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vraagTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.annulerenForm = new System.Windows.Forms.Button();
            this.opslaanForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(417, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(355, 179);
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Afbeelding : ";
            // 
            // vraagTextBox
            // 
            this.vraagTextBox.Location = new System.Drawing.Point(16, 32);
            this.vraagTextBox.Multiline = true;
            this.vraagTextBox.Name = "vraagTextBox";
            this.vraagTextBox.Size = new System.Drawing.Size(385, 179);
            this.vraagTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vraag :";
            // 
            // annulerenForm
            // 
            this.annulerenForm.Location = new System.Drawing.Point(659, 312);
            this.annulerenForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.annulerenForm.Name = "annulerenForm";
            this.annulerenForm.Size = new System.Drawing.Size(112, 35);
            this.annulerenForm.TabIndex = 7;
            this.annulerenForm.Text = "Annuleren";
            this.annulerenForm.UseVisualStyleBackColor = true;
            // 
            // opslaanForm
            // 
            this.opslaanForm.Location = new System.Drawing.Point(539, 312);
            this.opslaanForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opslaanForm.Name = "opslaanForm";
            this.opslaanForm.Size = new System.Drawing.Size(112, 35);
            this.opslaanForm.TabIndex = 6;
            this.opslaanForm.Text = "Opslaan";
            this.opslaanForm.UseVisualStyleBackColor = true;
            // 
            // AanVragenFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vraagTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annulerenForm);
            this.Controls.Add(this.opslaanForm);
            this.Name = "AanVragenFrom";
            this.Text = "AanVragenFrom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vraagTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button annulerenForm;
        private System.Windows.Forms.Button opslaanForm;
    }
}