
namespace Bibliotheek.Forms
{
    partial class BezoekerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BezoekerForm));
            this.LblBezoeker = new System.Windows.Forms.Label();
            this.ActionsLabel = new System.Windows.Forms.Label();
            this.SearchPB = new System.Windows.Forms.PictureBox();
            this.toonOverzichPB = new System.Windows.Forms.PictureBox();
            this.RegistreerLidBTN = new System.Windows.Forms.Button();
            this.ZoekItemBTN = new System.Windows.Forms.Button();
            this.ToonOverzichBTN = new System.Windows.Forms.Button();
            this.RegistreerLidPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toonOverzichPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistreerLidPB)).BeginInit();
            this.SuspendLayout();
            // 
            // LblBezoeker
            // 
            this.LblBezoeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBezoeker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblBezoeker.Location = new System.Drawing.Point(12, 9);
            this.LblBezoeker.Name = "LblBezoeker";
            this.LblBezoeker.Size = new System.Drawing.Size(231, 61);
            this.LblBezoeker.TabIndex = 1;
            this.LblBezoeker.Text = "Bezoeker";
            this.LblBezoeker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActionsLabel
            // 
            this.ActionsLabel.AutoSize = true;
            this.ActionsLabel.Font = new System.Drawing.Font("Gill Sans MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ActionsLabel.Location = new System.Drawing.Point(14, 82);
            this.ActionsLabel.Name = "ActionsLabel";
            this.ActionsLabel.Size = new System.Drawing.Size(487, 34);
            this.ActionsLabel.TabIndex = 4;
            this.ActionsLabel.Text = "Hieronder kan u bekijken wat u kan doen:";
            // 
            // SearchPB
            // 
            this.SearchPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchPB.Image = ((System.Drawing.Image)(resources.GetObject("SearchPB.Image")));
            this.SearchPB.Location = new System.Drawing.Point(269, 119);
            this.SearchPB.Name = "SearchPB";
            this.SearchPB.Size = new System.Drawing.Size(256, 256);
            this.SearchPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SearchPB.TabIndex = 6;
            this.SearchPB.TabStop = false;
            // 
            // toonOverzichPB
            // 
            this.toonOverzichPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toonOverzichPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toonOverzichPB.Image = ((System.Drawing.Image)(resources.GetObject("toonOverzichPB.Image")));
            this.toonOverzichPB.Location = new System.Drawing.Point(529, 119);
            this.toonOverzichPB.Name = "toonOverzichPB";
            this.toonOverzichPB.Size = new System.Drawing.Size(256, 256);
            this.toonOverzichPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.toonOverzichPB.TabIndex = 7;
            this.toonOverzichPB.TabStop = false;
            // 
            // RegistreerLidBTN
            // 
            this.RegistreerLidBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RegistreerLidBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistreerLidBTN.Location = new System.Drawing.Point(13, 377);
            this.RegistreerLidBTN.Name = "RegistreerLidBTN";
            this.RegistreerLidBTN.Size = new System.Drawing.Size(250, 49);
            this.RegistreerLidBTN.TabIndex = 8;
            this.RegistreerLidBTN.Text = "Registreer Lid";
            this.RegistreerLidBTN.UseVisualStyleBackColor = false;
            this.RegistreerLidBTN.Click += new System.EventHandler(this.RegistreerLidBTN_Click);
            // 
            // ZoekItemBTN
            // 
            this.ZoekItemBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ZoekItemBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoekItemBTN.Location = new System.Drawing.Point(269, 377);
            this.ZoekItemBTN.Name = "ZoekItemBTN";
            this.ZoekItemBTN.Size = new System.Drawing.Size(250, 49);
            this.ZoekItemBTN.TabIndex = 9;
            this.ZoekItemBTN.Text = "Zoek Item";
            this.ZoekItemBTN.UseVisualStyleBackColor = false;
            // 
            // ToonOverzichBTN
            // 
            this.ToonOverzichBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ToonOverzichBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToonOverzichBTN.Location = new System.Drawing.Point(529, 377);
            this.ToonOverzichBTN.Name = "ToonOverzichBTN";
            this.ToonOverzichBTN.Size = new System.Drawing.Size(250, 49);
            this.ToonOverzichBTN.TabIndex = 10;
            this.ToonOverzichBTN.Text = "Toon Overzicht";
            this.ToonOverzichBTN.UseVisualStyleBackColor = false;
            // 
            // RegistreerLidPB
            // 
            this.RegistreerLidPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RegistreerLidPB.Image = ((System.Drawing.Image)(resources.GetObject("RegistreerLidPB.Image")));
            this.RegistreerLidPB.Location = new System.Drawing.Point(13, 119);
            this.RegistreerLidPB.Name = "RegistreerLidPB";
            this.RegistreerLidPB.Size = new System.Drawing.Size(256, 256);
            this.RegistreerLidPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RegistreerLidPB.TabIndex = 5;
            this.RegistreerLidPB.TabStop = false;
            // 
            // BezoekerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToonOverzichBTN);
            this.Controls.Add(this.ZoekItemBTN);
            this.Controls.Add(this.RegistreerLidBTN);
            this.Controls.Add(this.toonOverzichPB);
            this.Controls.Add(this.SearchPB);
            this.Controls.Add(this.RegistreerLidPB);
            this.Controls.Add(this.ActionsLabel);
            this.Controls.Add(this.LblBezoeker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BezoekerForm";
            this.Text = "BezoekerForm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toonOverzichPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistreerLidPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBezoeker;
        private System.Windows.Forms.Label ActionsLabel;
        private System.Windows.Forms.PictureBox SearchPB;
        private System.Windows.Forms.PictureBox toonOverzichPB;
        private System.Windows.Forms.Button RegistreerLidBTN;
        private System.Windows.Forms.Button ZoekItemBTN;
        private System.Windows.Forms.Button ToonOverzichBTN;
        private System.Windows.Forms.PictureBox RegistreerLidPB;
    }
}