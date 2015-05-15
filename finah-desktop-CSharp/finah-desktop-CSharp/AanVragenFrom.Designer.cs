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
            this.annulerenButton = new System.Windows.Forms.Button();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.verkennerButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(417, 32);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(355, 179);
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vraag :";
            // 
            // annulerenButton
            // 
            this.annulerenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.annulerenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerenButton.Location = new System.Drawing.Point(659, 312);
            this.annulerenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.annulerenButton.Name = "annulerenButton";
            this.annulerenButton.Size = new System.Drawing.Size(112, 35);
            this.annulerenButton.TabIndex = 7;
            this.annulerenButton.Text = "Annuleren";
            this.annulerenButton.UseVisualStyleBackColor = false;
            this.annulerenButton.Click += new System.EventHandler(this.annulerenButton_Click);
            // 
            // opslaanButton
            // 
            this.opslaanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.opslaanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opslaanButton.Location = new System.Drawing.Point(539, 312);
            this.opslaanButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(112, 35);
            this.opslaanButton.TabIndex = 6;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = false;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // verkennerButton
            // 
            this.verkennerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.verkennerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verkennerButton.Location = new System.Drawing.Point(501, 217);
            this.verkennerButton.Name = "verkennerButton";
            this.verkennerButton.Size = new System.Drawing.Size(167, 29);
            this.verkennerButton.TabIndex = 12;
            this.verkennerButton.Text = "Afbeelding kiezen";
            this.verkennerButton.UseVisualStyleBackColor = false;
            this.verkennerButton.Click += new System.EventHandler(this.verkennerButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(42, 278);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 13;
            this.idTextBox.Visible = false;
            // 
            // AanVragenFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finah_desktop_CSharp.Properties.Resources._11264430_962915657081985_435153716_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.verkennerButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vraagTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annulerenButton);
            this.Controls.Add(this.opslaanButton);
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
        private System.Windows.Forms.Button annulerenButton;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.Button verkennerButton;
        private System.Windows.Forms.TextBox idTextBox;
    }
}