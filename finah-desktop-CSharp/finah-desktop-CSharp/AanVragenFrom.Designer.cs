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
            this.vraagTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.annulerenButton = new System.Windows.Forms.Button();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vraagTextBox
            // 
            this.vraagTextBox.Location = new System.Drawing.Point(31, 92);
            this.vraagTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.vraagTextBox.Multiline = true;
            this.vraagTextBox.Name = "vraagTextBox";
            this.vraagTextBox.Size = new System.Drawing.Size(766, 264);
            this.vraagTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vraag";
            // 
            // annulerenButton
            // 
            this.annulerenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.annulerenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerenButton.Location = new System.Drawing.Point(299, 401);
            this.annulerenButton.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.annulerenButton.Name = "annulerenButton";
            this.annulerenButton.Size = new System.Drawing.Size(224, 67);
            this.annulerenButton.TabIndex = 7;
            this.annulerenButton.Text = "Annuleren";
            this.annulerenButton.UseVisualStyleBackColor = false;
            this.annulerenButton.Click += new System.EventHandler(this.annulerenButton_Click);
            // 
            // opslaanButton
            // 
            this.opslaanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.opslaanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opslaanButton.Location = new System.Drawing.Point(573, 401);
            this.opslaanButton.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(224, 67);
            this.opslaanButton.TabIndex = 6;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = false;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // AanVragenFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finah_desktop_CSharp.Properties.Resources._11264430_962915657081985_435153716_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 514);
            this.Controls.Add(this.vraagTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.annulerenButton);
            this.Controls.Add(this.opslaanButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AanVragenFrom";
            this.Text = "AanVragenFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vraagTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button annulerenButton;
        private System.Windows.Forms.Button opslaanButton;
    }
}