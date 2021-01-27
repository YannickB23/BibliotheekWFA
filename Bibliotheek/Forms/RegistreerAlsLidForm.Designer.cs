
namespace Bibliotheek.Forms
{
    partial class RegistreerAlsLidForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistreerAlsLidForm));
            System.Windows.Forms.Label familienaamLabel;
            System.Windows.Forms.Label voornaamLabel;
            System.Windows.Forms.Label geboortedatumLabel;
            System.Windows.Forms.Label geslachtLabel;
            this.LblBezoeker = new System.Windows.Forms.Label();
            this.dBLedenDataSet = new Bibliotheek.DBLedenDataSet();
            this.ledenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ledenTableAdapter = new Bibliotheek.DBLedenDataSetTableAdapters.LedenTableAdapter();
            this.tableAdapterManager = new Bibliotheek.DBLedenDataSetTableAdapters.TableAdapterManager();
            this.ledenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ledenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.familienaamTextBox = new System.Windows.Forms.TextBox();
            this.voornaamTextBox = new System.Windows.Forms.TextBox();
            this.geboortedatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CBGGeslachtM = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            familienaamLabel = new System.Windows.Forms.Label();
            voornaamLabel = new System.Windows.Forms.Label();
            geboortedatumLabel = new System.Windows.Forms.Label();
            geslachtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBLedenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledenBindingNavigator)).BeginInit();
            this.ledenBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblBezoeker
            // 
            this.LblBezoeker.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBezoeker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblBezoeker.Location = new System.Drawing.Point(12, 9);
            this.LblBezoeker.Name = "LblBezoeker";
            this.LblBezoeker.Size = new System.Drawing.Size(357, 61);
            this.LblBezoeker.TabIndex = 2;
            this.LblBezoeker.Text = "Registreer als lid";
            this.LblBezoeker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dBLedenDataSet
            // 
            this.dBLedenDataSet.DataSetName = "DBLedenDataSet";
            this.dBLedenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ledenBindingSource
            // 
            this.ledenBindingSource.DataMember = "Leden";
            this.ledenBindingSource.DataSource = this.dBLedenDataSet;
            // 
            // ledenTableAdapter
            // 
            this.ledenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LedenTableAdapter = this.ledenTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bibliotheek.DBLedenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ledenBindingNavigator
            // 
            this.ledenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ledenBindingNavigator.BindingSource = this.ledenBindingSource;
            this.ledenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ledenBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ledenBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ledenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ledenBindingNavigatorSaveItem});
            this.ledenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ledenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ledenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ledenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ledenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ledenBindingNavigator.Name = "ledenBindingNavigator";
            this.ledenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ledenBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.ledenBindingNavigator.TabIndex = 3;
            this.ledenBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // ledenBindingNavigatorSaveItem
            // 
            this.ledenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ledenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ledenBindingNavigatorSaveItem.Image")));
            this.ledenBindingNavigatorSaveItem.Name = "ledenBindingNavigatorSaveItem";
            this.ledenBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.ledenBindingNavigatorSaveItem.Text = "Save Data";
            this.ledenBindingNavigatorSaveItem.Click += new System.EventHandler(this.ledenBindingNavigatorSaveItem_Click);
            // 
            // familienaamLabel
            // 
            familienaamLabel.AutoSize = true;
            familienaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            familienaamLabel.ForeColor = System.Drawing.Color.Maroon;
            familienaamLabel.Location = new System.Drawing.Point(20, 78);
            familienaamLabel.Name = "familienaamLabel";
            familienaamLabel.Size = new System.Drawing.Size(103, 17);
            familienaamLabel.TabIndex = 5;
            familienaamLabel.Text = "Familienaam:";
            // 
            // familienaamTextBox
            // 
            this.familienaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ledenBindingSource, "Familienaam", true));
            this.familienaamTextBox.Location = new System.Drawing.Point(162, 75);
            this.familienaamTextBox.Name = "familienaamTextBox";
            this.familienaamTextBox.Size = new System.Drawing.Size(232, 22);
            this.familienaamTextBox.TabIndex = 6;
            // 
            // voornaamLabel
            // 
            voornaamLabel.AutoSize = true;
            voornaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            voornaamLabel.ForeColor = System.Drawing.Color.Maroon;
            voornaamLabel.Location = new System.Drawing.Point(20, 106);
            voornaamLabel.Name = "voornaamLabel";
            voornaamLabel.Size = new System.Drawing.Size(86, 17);
            voornaamLabel.TabIndex = 7;
            voornaamLabel.Text = "Voornaam:";
            // 
            // voornaamTextBox
            // 
            this.voornaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ledenBindingSource, "Voornaam", true));
            this.voornaamTextBox.Location = new System.Drawing.Point(162, 103);
            this.voornaamTextBox.Name = "voornaamTextBox";
            this.voornaamTextBox.Size = new System.Drawing.Size(232, 22);
            this.voornaamTextBox.TabIndex = 8;
            // 
            // geboortedatumLabel
            // 
            geboortedatumLabel.AutoSize = true;
            geboortedatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            geboortedatumLabel.ForeColor = System.Drawing.Color.Maroon;
            geboortedatumLabel.Location = new System.Drawing.Point(20, 135);
            geboortedatumLabel.Name = "geboortedatumLabel";
            geboortedatumLabel.Size = new System.Drawing.Size(125, 17);
            geboortedatumLabel.TabIndex = 9;
            geboortedatumLabel.Text = "Geboortedatum:";
            // 
            // geboortedatumDateTimePicker
            // 
            this.geboortedatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ledenBindingSource, "Geboortedatum", true));
            this.geboortedatumDateTimePicker.Location = new System.Drawing.Point(162, 131);
            this.geboortedatumDateTimePicker.Name = "geboortedatumDateTimePicker";
            this.geboortedatumDateTimePicker.Size = new System.Drawing.Size(232, 22);
            this.geboortedatumDateTimePicker.TabIndex = 10;
            // 
            // geslachtLabel
            // 
            geslachtLabel.AutoSize = true;
            geslachtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            geslachtLabel.ForeColor = System.Drawing.Color.Maroon;
            geslachtLabel.Location = new System.Drawing.Point(20, 164);
            geslachtLabel.Name = "geslachtLabel";
            geslachtLabel.Size = new System.Drawing.Size(77, 17);
            geslachtLabel.TabIndex = 11;
            geslachtLabel.Text = "Geslacht:";
            // 
            // CBGGeslachtM
            // 
            this.CBGGeslachtM.AutoSize = true;
            this.CBGGeslachtM.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ledenBindingSource, "Geslacht", true));
            this.CBGGeslachtM.Location = new System.Drawing.Point(162, 159);
            this.CBGGeslachtM.Name = "CBGGeslachtM";
            this.CBGGeslachtM.Size = new System.Drawing.Size(41, 21);
            this.CBGGeslachtM.TabIndex = 12;
            this.CBGGeslachtM.Text = "M";
            this.CBGGeslachtM.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(222, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(39, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "V";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // RegistreerAlsLidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(familienaamLabel);
            this.Controls.Add(this.familienaamTextBox);
            this.Controls.Add(voornaamLabel);
            this.Controls.Add(this.voornaamTextBox);
            this.Controls.Add(geboortedatumLabel);
            this.Controls.Add(this.geboortedatumDateTimePicker);
            this.Controls.Add(geslachtLabel);
            this.Controls.Add(this.CBGGeslachtM);
            this.Controls.Add(this.ledenBindingNavigator);
            this.Controls.Add(this.LblBezoeker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistreerAlsLidForm";
            this.Text = "RegistreerAlsLidForm";
            this.Load += new System.EventHandler(this.RegistreerAlsLidForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBLedenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledenBindingNavigator)).EndInit();
            this.ledenBindingNavigator.ResumeLayout(false);
            this.ledenBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBezoeker;
        private DBLedenDataSet dBLedenDataSet;
        private System.Windows.Forms.BindingSource ledenBindingSource;
        private DBLedenDataSetTableAdapters.LedenTableAdapter ledenTableAdapter;
        private DBLedenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ledenBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ledenBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox familienaamTextBox;
        private System.Windows.Forms.TextBox voornaamTextBox;
        private System.Windows.Forms.DateTimePicker geboortedatumDateTimePicker;
        private System.Windows.Forms.CheckBox CBGGeslachtM;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}