
namespace Bibliotheek
{
    partial class FrmFrontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFrontPage));
            this.LblWelcome = new System.Windows.Forms.Label();
            this.BtnBezoeker = new System.Windows.Forms.Button();
            this.LblMenu = new System.Windows.Forms.Label();
            this.BtnLid = new System.Windows.Forms.Button();
            this.BtnMedewerker = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblWelcome.Location = new System.Drawing.Point(12, 9);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(583, 61);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Welkom in onze bib";
            this.LblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnBezoeker
            // 
            this.BtnBezoeker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnBezoeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBezoeker.Location = new System.Drawing.Point(12, 117);
            this.BtnBezoeker.Name = "BtnBezoeker";
            this.BtnBezoeker.Size = new System.Drawing.Size(145, 32);
            this.BtnBezoeker.TabIndex = 1;
            this.BtnBezoeker.Text = "Bezoeker";
            this.BtnBezoeker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBezoeker.UseVisualStyleBackColor = false;
            this.BtnBezoeker.Click += new System.EventHandler(this.BtnBezoeker_Click);
            // 
            // LblMenu
            // 
            this.LblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(12, 82);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(145, 32);
            this.LblMenu.TabIndex = 2;
            this.LblMenu.Text = "Menu";
            this.LblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLid
            // 
            this.BtnLid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnLid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLid.Location = new System.Drawing.Point(12, 155);
            this.BtnLid.Name = "BtnLid";
            this.BtnLid.Size = new System.Drawing.Size(145, 32);
            this.BtnLid.TabIndex = 3;
            this.BtnLid.Text = "Lid";
            this.BtnLid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLid.UseVisualStyleBackColor = false;
            this.BtnLid.Click += new System.EventHandler(this.BtnLid_Click);
            // 
            // BtnMedewerker
            // 
            this.BtnMedewerker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnMedewerker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedewerker.Location = new System.Drawing.Point(12, 193);
            this.BtnMedewerker.Name = "BtnMedewerker";
            this.BtnMedewerker.Size = new System.Drawing.Size(145, 32);
            this.BtnMedewerker.TabIndex = 4;
            this.BtnMedewerker.Text = "Medewerker";
            this.BtnMedewerker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMedewerker.UseVisualStyleBackColor = false;
            this.BtnMedewerker.Click += new System.EventHandler(this.BtnMedewerker_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 356);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnMedewerker);
            this.Controls.Add(this.BtnLid);
            this.Controls.Add(this.LblMenu);
            this.Controls.Add(this.BtnBezoeker);
            this.Controls.Add(this.LblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFrontPage";
            this.Text = "Bibliotheek";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Button BtnBezoeker;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Button BtnLid;
        private System.Windows.Forms.Button BtnMedewerker;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

