
namespace Bibliotheek.Forms
{
    partial class RegistreerLidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistreerLidForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.VoornaamLbl = new System.Windows.Forms.Label();
            this.FamilienaamLbl = new System.Windows.Forms.Label();
            this.GeboortedatumLbl = new System.Windows.Forms.Label();
            this.LblBezoeker = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(217, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 22);
            this.textBox3.TabIndex = 2;
            // 
            // VoornaamLbl
            // 
            this.VoornaamLbl.AutoSize = true;
            this.VoornaamLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoornaamLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.VoornaamLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VoornaamLbl.Location = new System.Drawing.Point(77, 134);
            this.VoornaamLbl.Name = "VoornaamLbl";
            this.VoornaamLbl.Size = new System.Drawing.Size(112, 24);
            this.VoornaamLbl.TabIndex = 3;
            this.VoornaamLbl.Text = "Voornaam:";
            // 
            // FamilienaamLbl
            // 
            this.FamilienaamLbl.AutoSize = true;
            this.FamilienaamLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilienaamLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FamilienaamLbl.Location = new System.Drawing.Point(54, 211);
            this.FamilienaamLbl.Name = "FamilienaamLbl";
            this.FamilienaamLbl.Size = new System.Drawing.Size(135, 24);
            this.FamilienaamLbl.TabIndex = 4;
            this.FamilienaamLbl.Text = "Familienaam:";
            // 
            // GeboortedatumLbl
            // 
            this.GeboortedatumLbl.AutoSize = true;
            this.GeboortedatumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeboortedatumLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GeboortedatumLbl.Location = new System.Drawing.Point(29, 294);
            this.GeboortedatumLbl.Name = "GeboortedatumLbl";
            this.GeboortedatumLbl.Size = new System.Drawing.Size(160, 24);
            this.GeboortedatumLbl.TabIndex = 5;
            this.GeboortedatumLbl.Text = "Geboortedatum:";
            // 
            // LblBezoeker
            // 
            this.LblBezoeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBezoeker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblBezoeker.Location = new System.Drawing.Point(50, 24);
            this.LblBezoeker.Name = "LblBezoeker";
            this.LblBezoeker.Size = new System.Drawing.Size(330, 71);
            this.LblBezoeker.TabIndex = 6;
            this.LblBezoeker.Text = "Registreer als lid\r\nVul hieronder uw gegevens in:\r\n\r\n";
            this.LblBezoeker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(465, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // RegistreerLidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblBezoeker);
            this.Controls.Add(this.GeboortedatumLbl);
            this.Controls.Add(this.FamilienaamLbl);
            this.Controls.Add(this.VoornaamLbl);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistreerLidForm";
            this.Text = "Registreer als lid";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label VoornaamLbl;
        private System.Windows.Forms.Label FamilienaamLbl;
        private System.Windows.Forms.Label GeboortedatumLbl;
        private System.Windows.Forms.Label LblBezoeker;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}