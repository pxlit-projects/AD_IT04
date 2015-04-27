namespace net.finah
{
    partial class aanVragenFrom
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
            this.opslaanForm = new System.Windows.Forms.Button();
            this.annulerenForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vraagTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // opslaanForm
            // 
            this.opslaanForm.Location = new System.Drawing.Point(539, 312);
            this.opslaanForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opslaanForm.Name = "opslaanForm";
            this.opslaanForm.Size = new System.Drawing.Size(112, 35);
            this.opslaanForm.TabIndex = 0;
            this.opslaanForm.Text = "Opslaan";
            this.opslaanForm.UseVisualStyleBackColor = true;
            // 
            // annulerenForm
            // 
            this.annulerenForm.Location = new System.Drawing.Point(659, 312);
            this.annulerenForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.annulerenForm.Name = "annulerenForm";
            this.annulerenForm.Size = new System.Drawing.Size(112, 35);
            this.annulerenForm.TabIndex = 1;
            this.annulerenForm.Text = "Annuleren";
            this.annulerenForm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vraag :";
            // 
            // vraagTextBox
            // 
            this.vraagTextBox.Location = new System.Drawing.Point(16, 32);
            this.vraagTextBox.Multiline = true;
            this.vraagTextBox.Name = "vraagTextBox";
            this.vraagTextBox.Size = new System.Drawing.Size(385, 179);
            this.vraagTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Afbeelding : ";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(417, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(355, 179);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // aanVragenFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vraagTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annulerenForm);
            this.Controls.Add(this.opslaanForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "aanVragenFrom";
            this.Text = "aanVragenFrom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opslaanForm;
        private System.Windows.Forms.Button annulerenForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vraagTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}