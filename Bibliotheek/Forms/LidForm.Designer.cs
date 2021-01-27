
namespace Bibliotheek.Forms
{
    partial class LidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LidForm));
            this.LblBezoeker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblBezoeker
            // 
            this.LblBezoeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBezoeker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblBezoeker.Location = new System.Drawing.Point(12, 9);
            this.LblBezoeker.Name = "LblBezoeker";
            this.LblBezoeker.Size = new System.Drawing.Size(77, 61);
            this.LblBezoeker.TabIndex = 2;
            this.LblBezoeker.Text = "Lid";
            this.LblBezoeker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblBezoeker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LidForm";
            this.Text = "LidForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblBezoeker;
    }
}