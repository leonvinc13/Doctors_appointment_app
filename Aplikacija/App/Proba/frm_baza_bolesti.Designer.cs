namespace Proba
{
    partial class frm_baza_bolesti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_baza_bolesti));
            this.bolestDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijecnikDataSet = new Proba.lijecnikDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fillByNazivToolStrip = new System.Windows.Forms.ToolStrip();
            this.naziv_bolestiToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.naziv_bolestiToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNazivToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bolestBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bolestBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bolestTableAdapter = new Proba.lijecnikDataSetTableAdapters.BolestTableAdapter();
            this.tableAdapterManager = new Proba.lijecnikDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bolestDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.fillByNazivToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingNavigator)).BeginInit();
            this.bolestBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bolestDataGridView
            // 
            this.bolestDataGridView.AutoGenerateColumns = false;
            this.bolestDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.bolestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bolestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.bolestDataGridView.DataSource = this.bolestBindingSource;
            this.bolestDataGridView.Location = new System.Drawing.Point(255, 268);
            this.bolestDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bolestDataGridView.Name = "bolestDataGridView";
            this.bolestDataGridView.RowHeadersWidth = 51;
            this.bolestDataGridView.Size = new System.Drawing.Size(615, 271);
            this.bolestDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_bolesti";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_bolesti";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv_bolesti";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv_bolesti";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Opis_bolesti";
            this.dataGridViewTextBoxColumn3.HeaderText = "Opis_bolesti";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // bolestBindingSource
            // 
            this.bolestBindingSource.DataMember = "Bolest";
            this.bolestBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // lijecnikDataSet
            // 
            this.lijecnikDataSet.DataSetName = "lijecnikDataSet";
            this.lijecnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 199);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(661, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Traži";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(288, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv bolesti:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 132);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proba.Properties.Resources.ambulanta1;
            this.pictureBox2.Location = new System.Drawing.Point(961, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(400, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sve bolesti";
            // 
            // fillByNazivToolStrip
            // 
            this.fillByNazivToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fillByNazivToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByNazivToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naziv_bolestiToolStripLabel,
            this.naziv_bolestiToolStripTextBox,
            this.fillByNazivToolStripButton});
            this.fillByNazivToolStrip.Location = new System.Drawing.Point(0, 533);
            this.fillByNazivToolStrip.Name = "fillByNazivToolStrip";
            this.fillByNazivToolStrip.Size = new System.Drawing.Size(1091, 31);
            this.fillByNazivToolStrip.TabIndex = 10;
            this.fillByNazivToolStrip.Text = "fillByNazivToolStrip";
            this.fillByNazivToolStrip.Visible = false;
            // 
            // naziv_bolestiToolStripLabel
            // 
            this.naziv_bolestiToolStripLabel.Name = "naziv_bolestiToolStripLabel";
            this.naziv_bolestiToolStripLabel.Size = new System.Drawing.Size(100, 28);
            this.naziv_bolestiToolStripLabel.Text = "Naziv_bolesti:";
            // 
            // naziv_bolestiToolStripTextBox
            // 
            this.naziv_bolestiToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.naziv_bolestiToolStripTextBox.Name = "naziv_bolestiToolStripTextBox";
            this.naziv_bolestiToolStripTextBox.Size = new System.Drawing.Size(132, 31);
            // 
            // fillByNazivToolStripButton
            // 
            this.fillByNazivToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNazivToolStripButton.Name = "fillByNazivToolStripButton";
            this.fillByNazivToolStripButton.Size = new System.Drawing.Size(85, 28);
            this.fillByNazivToolStripButton.Text = "FillByNaziv";
            this.fillByNazivToolStripButton.Click += new System.EventHandler(this.fillByNazivToolStripButton_Click);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
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
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bolestBindingNavigator
            // 
            this.bolestBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bolestBindingNavigator.BindingSource = this.bolestBindingSource;
            this.bolestBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bolestBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bolestBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bolestBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bolestBindingNavigatorSaveItem});
            this.bolestBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bolestBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bolestBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bolestBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bolestBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bolestBindingNavigator.Name = "bolestBindingNavigator";
            this.bolestBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bolestBindingNavigator.Size = new System.Drawing.Size(1091, 27);
            this.bolestBindingNavigator.TabIndex = 0;
            this.bolestBindingNavigator.Text = "bindingNavigator1";
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
            // bolestBindingNavigatorSaveItem
            // 
            this.bolestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bolestBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bolestBindingNavigatorSaveItem.Image")));
            this.bolestBindingNavigatorSaveItem.Name = "bolestBindingNavigatorSaveItem";
            this.bolestBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bolestBindingNavigatorSaveItem.Text = "Save Data";
            this.bolestBindingNavigatorSaveItem.Click += new System.EventHandler(this.bolestBindingNavigatorSaveItem_Click);
            // 
            // bolestTableAdapter
            // 
            this.bolestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BolestTableAdapter = this.bolestTableAdapter;
            this.tableAdapterManager.CijepljenjeTableAdapter = null;
            this.tableAdapterManager.CjepivoTableAdapter = null;
            this.tableAdapterManager.LijecnikTableAdapter = null;
            this.tableAdapterManager.LijekTableAdapter = null;
            this.tableAdapterManager.PacijentTableAdapter = null;
            this.tableAdapterManager.Posjeta_bolestTableAdapter = null;
            this.tableAdapterManager.Posjeta_lijekTableAdapter = null;
            this.tableAdapterManager.PosjetaTableAdapter = null;
            this.tableAdapterManager.SpecijalizacijaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proba.lijecnikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frm_baza_bolesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1091, 582);
            this.Controls.Add(this.fillByNazivToolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bolestDataGridView);
            this.Controls.Add(this.bolestBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_baza_bolesti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza bolesti";
            this.Load += new System.EventHandler(this.frm_baza_bolesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bolestDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.fillByNazivToolStrip.ResumeLayout(false);
            this.fillByNazivToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingNavigator)).EndInit();
            this.bolestBindingNavigator.ResumeLayout(false);
            this.bolestBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lijecnikDataSet lijecnikDataSet;
        private System.Windows.Forms.BindingSource bolestBindingSource;
        private lijecnikDataSetTableAdapters.BolestTableAdapter bolestTableAdapter;
        private lijecnikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bolestDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip fillByNazivToolStrip;
        private System.Windows.Forms.ToolStripLabel naziv_bolestiToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox naziv_bolestiToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByNazivToolStripButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bolestBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator bolestBindingNavigator;
    }
}