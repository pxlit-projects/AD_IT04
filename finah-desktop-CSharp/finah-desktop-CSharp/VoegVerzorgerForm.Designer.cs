namespace finah_desktop_CSharp
{
    partial class VoegVerzorgerForm
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
            this.voegVerzorgerButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.voornaamTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voegVerzorgerButton
            // 
            this.voegVerzorgerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(255)))), ((int)(((byte)(175)))));
            this.voegVerzorgerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voegVerzorgerButton.Location = new System.Drawing.Point(242, 113);
            this.voegVerzorgerButton.Name = "voegVerzorgerButton";
            this.voegVerzorgerButton.Size = new System.Drawing.Size(130, 30);
            this.voegVerzorgerButton.TabIndex = 13;
            this.voegVerzorgerButton.Text = "Toevoegen";
            this.voegVerzorgerButton.UseVisualStyleBackColor = false;
            this.voegVerzorgerButton.Click += new System.EventHandler(this.voegVerzorgerButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(81, 58);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(291, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(81, 32);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(291, 20);
            this.naamTextBox.TabIndex = 11;
            // 
            // voornaamTextBox
            // 
            this.voornaamTextBox.Location = new System.Drawing.Point(81, 6);
            this.voornaamTextBox.Name = "voornaamTextBox";
            this.voornaamTextBox.Size = new System.Drawing.Size(291, 20);
            this.voornaamTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "e-mailadres : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naam : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Voornaam :";
            // 
            // VoegVerzorgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finah_desktop_CSharp.Properties.Resources._11264430_962915657081985_435153716_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.voegVerzorgerButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.voornaamTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoegVerzorgerForm";
            this.Text = "Voeg verzorger toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voegVerzorgerButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox voornaamTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}