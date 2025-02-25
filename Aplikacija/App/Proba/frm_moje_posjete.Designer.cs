namespace Proba
{
    partial class frm_moje_posjete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_moje_posjete));
            this.posjetaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.posjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijecnikDataSet = new Proba.lijecnikDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.posjetaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.posjetaDataGridView = new System.Windows.Forms.DataGridView();
            this.pacijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijecnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByPosjetaToolStrip = new System.Windows.Forms.ToolStrip();
            this.iD_pacijentaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iD_pacijentaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByPosjetaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.posjetaTableAdapter = new Proba.lijecnikDataSetTableAdapters.PosjetaTableAdapter();
            this.tableAdapterManager = new Proba.lijecnikDataSetTableAdapters.TableAdapterManager();
            this.pacijentTableAdapter = new Proba.lijecnikDataSetTableAdapters.PacijentTableAdapter();
            this.lijecnikTableAdapter = new Proba.lijecnikDataSetTableAdapters.LijecnikTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingNavigator)).BeginInit();
            this.posjetaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikBindingSource)).BeginInit();
            this.fillByPosjetaToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // posjetaBindingNavigator
            // 
            this.posjetaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.posjetaBindingNavigator.BindingSource = this.posjetaBindingSource;
            this.posjetaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.posjetaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.posjetaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.posjetaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.posjetaBindingNavigatorSaveItem});
            this.posjetaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.posjetaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.posjetaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.posjetaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.posjetaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.posjetaBindingNavigator.Name = "posjetaBindingNavigator";
            this.posjetaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.posjetaBindingNavigator.Size = new System.Drawing.Size(1067, 27);
            this.posjetaBindingNavigator.TabIndex = 0;
            this.posjetaBindingNavigator.Text = "bindingNavigator1";
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
            // posjetaBindingSource
            // 
            this.posjetaBindingSource.DataMember = "Posjeta";
            this.posjetaBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // lijecnikDataSet
            // 
            this.lijecnikDataSet.DataSetName = "lijecnikDataSet";
            this.lijecnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // posjetaBindingNavigatorSaveItem
            // 
            this.posjetaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.posjetaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("posjetaBindingNavigatorSaveItem.Image")));
            this.posjetaBindingNavigatorSaveItem.Name = "posjetaBindingNavigatorSaveItem";
            this.posjetaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.posjetaBindingNavigatorSaveItem.Text = "Save Data";
            this.posjetaBindingNavigatorSaveItem.Click += new System.EventHandler(this.posjetaBindingNavigatorSaveItem_Click);
            // 
            // posjetaDataGridView
            // 
            this.posjetaDataGridView.AutoGenerateColumns = false;
            this.posjetaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.posjetaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posjetaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.posjetaDataGridView.DataSource = this.posjetaBindingSource;
            this.posjetaDataGridView.Location = new System.Drawing.Point(35, 177);
            this.posjetaDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.posjetaDataGridView.Name = "posjetaDataGridView";
            this.posjetaDataGridView.RowHeadersWidth = 51;
            this.posjetaDataGridView.Size = new System.Drawing.Size(999, 271);
            this.posjetaDataGridView.TabIndex = 1;
            // 
            // pacijentBindingSource
            // 
            this.pacijentBindingSource.DataMember = "Pacijent";
            this.pacijentBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // lijecnikBindingSource
            // 
            this.lijecnikBindingSource.DataMember = "Lijecnik";
            this.lijecnikBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // fillByPosjetaToolStrip
            // 
            this.fillByPosjetaToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByPosjetaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iD_pacijentaToolStripLabel,
            this.iD_pacijentaToolStripTextBox,
            this.fillByPosjetaToolStripButton});
            this.fillByPosjetaToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillByPosjetaToolStrip.Name = "fillByPosjetaToolStrip";
            this.fillByPosjetaToolStrip.Size = new System.Drawing.Size(1067, 27);
            this.fillByPosjetaToolStrip.TabIndex = 2;
            this.fillByPosjetaToolStrip.Text = "fillByPosjetaToolStrip";
            // 
            // iD_pacijentaToolStripLabel
            // 
            this.iD_pacijentaToolStripLabel.Name = "iD_pacijentaToolStripLabel";
            this.iD_pacijentaToolStripLabel.Size = new System.Drawing.Size(94, 24);
            this.iD_pacijentaToolStripLabel.Text = "ID_pacijenta:";
            // 
            // iD_pacijentaToolStripTextBox
            // 
            this.iD_pacijentaToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iD_pacijentaToolStripTextBox.Name = "iD_pacijentaToolStripTextBox";
            this.iD_pacijentaToolStripTextBox.Size = new System.Drawing.Size(132, 27);
            // 
            // fillByPosjetaToolStripButton
            // 
            this.fillByPosjetaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByPosjetaToolStripButton.Name = "fillByPosjetaToolStripButton";
            this.fillByPosjetaToolStripButton.Size = new System.Drawing.Size(95, 24);
            this.fillByPosjetaToolStripButton.Text = "FillByPosjeta";
            this.fillByPosjetaToolStripButton.Click += new System.EventHandler(this.fillByPosjetaToolStripButton_Click);
            // 
            // posjetaTableAdapter
            // 
            this.posjetaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BolestTableAdapter = null;
            this.tableAdapterManager.CijepljenjeTableAdapter = null;
            this.tableAdapterManager.CjepivoTableAdapter = null;
            this.tableAdapterManager.LijecnikTableAdapter = null;
            this.tableAdapterManager.LijekTableAdapter = null;
            this.tableAdapterManager.PacijentTableAdapter = null;
            this.tableAdapterManager.Posjeta_bolestTableAdapter = null;
            this.tableAdapterManager.Posjeta_lijekTableAdapter = null;
            this.tableAdapterManager.PosjetaTableAdapter = this.posjetaTableAdapter;
            this.tableAdapterManager.SpecijalizacijaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proba.lijecnikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacijentTableAdapter
            // 
            this.pacijentTableAdapter.ClearBeforeFill = true;
            // 
            // lijecnikTableAdapter
            // 
            this.lijecnikTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 124);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proba.Properties.Resources.ambulanta1;
            this.pictureBox2.Location = new System.Drawing.Point(940, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(403, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "Moje posjete";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_posjete";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_posjete";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_pacijenta";
            this.dataGridViewTextBoxColumn2.DataSource = this.pacijentBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Ime_pacijenta";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_pacijenta";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_pacijenta";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_lijecnika";
            this.dataGridViewTextBoxColumn3.DataSource = this.lijecnikBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Prezime_lijecnika";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_lijecnika";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_lijecnika";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Datum_posjete";
            this.dataGridViewTextBoxColumn4.HeaderText = "Datum_posjete";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Razlog_posjete";
            this.dataGridViewTextBoxColumn5.HeaderText = "Razlog_posjete";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // frm_moje_posjete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fillByPosjetaToolStrip);
            this.Controls.Add(this.posjetaDataGridView);
            this.Controls.Add(this.posjetaBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_moje_posjete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moje posjete";
            this.Load += new System.EventHandler(this.frm_moje_posjete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingNavigator)).EndInit();
            this.posjetaBindingNavigator.ResumeLayout(false);
            this.posjetaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikBindingSource)).EndInit();
            this.fillByPosjetaToolStrip.ResumeLayout(false);
            this.fillByPosjetaToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lijecnikDataSet lijecnikDataSet;
        private System.Windows.Forms.BindingSource posjetaBindingSource;
        private lijecnikDataSetTableAdapters.PosjetaTableAdapter posjetaTableAdapter;
        private lijecnikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator posjetaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton posjetaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView posjetaDataGridView;
        private System.Windows.Forms.ToolStrip fillByPosjetaToolStrip;
        private System.Windows.Forms.ToolStripLabel iD_pacijentaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iD_pacijentaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByPosjetaToolStripButton;
        private System.Windows.Forms.BindingSource pacijentBindingSource;
        private lijecnikDataSetTableAdapters.PacijentTableAdapter pacijentTableAdapter;
        private System.Windows.Forms.BindingSource lijecnikBindingSource;
        private lijecnikDataSetTableAdapters.LijecnikTableAdapter lijecnikTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}