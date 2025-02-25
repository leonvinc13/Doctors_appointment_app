namespace Proba
{
    partial class frm_pacijent_sve
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
            System.Windows.Forms.Label iD_pacijentaLabel;
            System.Windows.Forms.Label ime_pacijentaLabel;
            System.Windows.Forms.Label prezime_pacijentaLabel;
            System.Windows.Forms.Label datum_rodjenjaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pacijent_sve));
            this.lijecnikDataSet = new Proba.lijecnikDataSet();
            this.pacijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacijentTableAdapter = new Proba.lijecnikDataSetTableAdapters.PacijentTableAdapter();
            this.tableAdapterManager = new Proba.lijecnikDataSetTableAdapters.TableAdapterManager();
            this.bolestTableAdapter = new Proba.lijecnikDataSetTableAdapters.BolestTableAdapter();
            this.lijecnikTableAdapter = new Proba.lijecnikDataSetTableAdapters.LijecnikTableAdapter();
            this.lijekTableAdapter = new Proba.lijecnikDataSetTableAdapters.LijekTableAdapter();
            this.posjeta_bolestTableAdapter = new Proba.lijecnikDataSetTableAdapters.Posjeta_bolestTableAdapter();
            this.posjeta_lijekTableAdapter = new Proba.lijecnikDataSetTableAdapters.Posjeta_lijekTableAdapter();
            this.posjetaTableAdapter = new Proba.lijecnikDataSetTableAdapters.PosjetaTableAdapter();
            this.iD_pacijentaTextBox = new System.Windows.Forms.TextBox();
            this.ime_pacijentaTextBox = new System.Windows.Forms.TextBox();
            this.prezime_pacijentaTextBox = new System.Windows.Forms.TextBox();
            this.datum_rodjenjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.posjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posjetaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pacijentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lijecnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posjeta_bolestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posjeta_bolestDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bolestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posjeta_lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posjeta_lijekDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.pacijentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pacijentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            iD_pacijentaLabel = new System.Windows.Forms.Label();
            ime_pacijentaLabel = new System.Windows.Forms.Label();
            prezime_pacijentaLabel = new System.Windows.Forms.Label();
            datum_rodjenjaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_bolestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_bolestDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_lijekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_lijekDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingNavigator)).BeginInit();
            this.pacijentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_pacijentaLabel
            // 
            iD_pacijentaLabel.AutoSize = true;
            iD_pacijentaLabel.Location = new System.Drawing.Point(249, 162);
            iD_pacijentaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iD_pacijentaLabel.Name = "iD_pacijentaLabel";
            iD_pacijentaLabel.Size = new System.Drawing.Size(67, 13);
            iD_pacijentaLabel.TabIndex = 1;
            iD_pacijentaLabel.Text = "ID pacijenta:";
            // 
            // ime_pacijentaLabel
            // 
            ime_pacijentaLabel.AutoSize = true;
            ime_pacijentaLabel.Location = new System.Drawing.Point(249, 185);
            ime_pacijentaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ime_pacijentaLabel.Name = "ime_pacijentaLabel";
            ime_pacijentaLabel.Size = new System.Drawing.Size(73, 13);
            ime_pacijentaLabel.TabIndex = 3;
            ime_pacijentaLabel.Text = "Ime pacijenta:";
            // 
            // prezime_pacijentaLabel
            // 
            prezime_pacijentaLabel.AutoSize = true;
            prezime_pacijentaLabel.Location = new System.Drawing.Point(249, 208);
            prezime_pacijentaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            prezime_pacijentaLabel.Name = "prezime_pacijentaLabel";
            prezime_pacijentaLabel.Size = new System.Drawing.Size(93, 13);
            prezime_pacijentaLabel.TabIndex = 5;
            prezime_pacijentaLabel.Text = "Prezime pacijenta:";
            // 
            // datum_rodjenjaLabel
            // 
            datum_rodjenjaLabel.AutoSize = true;
            datum_rodjenjaLabel.Location = new System.Drawing.Point(249, 232);
            datum_rodjenjaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            datum_rodjenjaLabel.Name = "datum_rodjenjaLabel";
            datum_rodjenjaLabel.Size = new System.Drawing.Size(81, 13);
            datum_rodjenjaLabel.TabIndex = 7;
            datum_rodjenjaLabel.Text = "Datum rodjenja:";
            // 
            // lijecnikDataSet
            // 
            this.lijecnikDataSet.DataSetName = "lijecnikDataSet";
            this.lijecnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacijentBindingSource
            // 
            this.pacijentBindingSource.DataMember = "Pacijent";
            this.pacijentBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // pacijentTableAdapter
            // 
            this.pacijentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BolestTableAdapter = this.bolestTableAdapter;
            this.tableAdapterManager.CijepljenjeTableAdapter = null;
            this.tableAdapterManager.CjepivoTableAdapter = null;
            this.tableAdapterManager.LijecnikTableAdapter = this.lijecnikTableAdapter;
            this.tableAdapterManager.LijekTableAdapter = this.lijekTableAdapter;
            this.tableAdapterManager.PacijentTableAdapter = this.pacijentTableAdapter;
            this.tableAdapterManager.Posjeta_bolestTableAdapter = this.posjeta_bolestTableAdapter;
            this.tableAdapterManager.Posjeta_lijekTableAdapter = this.posjeta_lijekTableAdapter;
            this.tableAdapterManager.PosjetaTableAdapter = this.posjetaTableAdapter;
            this.tableAdapterManager.SpecijalizacijaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proba.lijecnikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bolestTableAdapter
            // 
            this.bolestTableAdapter.ClearBeforeFill = true;
            // 
            // lijecnikTableAdapter
            // 
            this.lijecnikTableAdapter.ClearBeforeFill = true;
            // 
            // lijekTableAdapter
            // 
            this.lijekTableAdapter.ClearBeforeFill = true;
            // 
            // posjeta_bolestTableAdapter
            // 
            this.posjeta_bolestTableAdapter.ClearBeforeFill = true;
            // 
            // posjeta_lijekTableAdapter
            // 
            this.posjeta_lijekTableAdapter.ClearBeforeFill = true;
            // 
            // posjetaTableAdapter
            // 
            this.posjetaTableAdapter.ClearBeforeFill = true;
            // 
            // iD_pacijentaTextBox
            // 
            this.iD_pacijentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacijentBindingSource, "ID_pacijenta", true));
            this.iD_pacijentaTextBox.Location = new System.Drawing.Point(346, 160);
            this.iD_pacijentaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iD_pacijentaTextBox.Name = "iD_pacijentaTextBox";
            this.iD_pacijentaTextBox.Size = new System.Drawing.Size(151, 20);
            this.iD_pacijentaTextBox.TabIndex = 2;
            // 
            // ime_pacijentaTextBox
            // 
            this.ime_pacijentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacijentBindingSource, "Ime_pacijenta", true));
            this.ime_pacijentaTextBox.Location = new System.Drawing.Point(346, 183);
            this.ime_pacijentaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ime_pacijentaTextBox.Name = "ime_pacijentaTextBox";
            this.ime_pacijentaTextBox.Size = new System.Drawing.Size(151, 20);
            this.ime_pacijentaTextBox.TabIndex = 4;
            // 
            // prezime_pacijentaTextBox
            // 
            this.prezime_pacijentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacijentBindingSource, "Prezime_pacijenta", true));
            this.prezime_pacijentaTextBox.Location = new System.Drawing.Point(346, 206);
            this.prezime_pacijentaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prezime_pacijentaTextBox.Name = "prezime_pacijentaTextBox";
            this.prezime_pacijentaTextBox.Size = new System.Drawing.Size(151, 20);
            this.prezime_pacijentaTextBox.TabIndex = 6;
            // 
            // datum_rodjenjaDateTimePicker
            // 
            this.datum_rodjenjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacijentBindingSource, "Datum_rodjenja", true));
            this.datum_rodjenjaDateTimePicker.Location = new System.Drawing.Point(346, 228);
            this.datum_rodjenjaDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datum_rodjenjaDateTimePicker.Name = "datum_rodjenjaDateTimePicker";
            this.datum_rodjenjaDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.datum_rodjenjaDateTimePicker.TabIndex = 8;
            // 
            // posjetaBindingSource
            // 
            this.posjetaBindingSource.DataMember = "FK__Posjeta__ID_paci__403A8C7D";
            this.posjetaBindingSource.DataSource = this.pacijentBindingSource;
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
            this.posjetaDataGridView.Location = new System.Drawing.Point(79, 282);
            this.posjetaDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.posjetaDataGridView.Name = "posjetaDataGridView";
            this.posjetaDataGridView.RowHeadersWidth = 51;
            this.posjetaDataGridView.RowTemplate.Height = 24;
            this.posjetaDataGridView.Size = new System.Drawing.Size(698, 114);
            this.posjetaDataGridView.TabIndex = 9;
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
            this.dataGridViewTextBoxColumn2.DataSource = this.pacijentBindingSource1;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Ime_pacijenta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pacijent";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_pacijenta";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // pacijentBindingSource1
            // 
            this.pacijentBindingSource1.DataMember = "Pacijent";
            this.pacijentBindingSource1.DataSource = this.lijecnikDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_lijecnika";
            this.dataGridViewTextBoxColumn3.DataSource = this.lijecnikBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Prezime_lijecnika";
            this.dataGridViewTextBoxColumn3.HeaderText = "Liječnik";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_lijecnika";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // lijecnikBindingSource
            // 
            this.lijecnikBindingSource.DataMember = "Lijecnik";
            this.lijecnikBindingSource.DataSource = this.lijecnikDataSet;
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
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // posjeta_bolestBindingSource
            // 
            this.posjeta_bolestBindingSource.DataMember = "FK__Posjeta_b__ID_po__47DBAE45";
            this.posjeta_bolestBindingSource.DataSource = this.posjetaBindingSource;
            // 
            // posjeta_bolestDataGridView
            // 
            this.posjeta_bolestDataGridView.AutoGenerateColumns = false;
            this.posjeta_bolestDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.posjeta_bolestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posjeta_bolestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8});
            this.posjeta_bolestDataGridView.DataSource = this.posjeta_bolestBindingSource;
            this.posjeta_bolestDataGridView.Location = new System.Drawing.Point(79, 416);
            this.posjeta_bolestDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.posjeta_bolestDataGridView.Name = "posjeta_bolestDataGridView";
            this.posjeta_bolestDataGridView.RowHeadersWidth = 51;
            this.posjeta_bolestDataGridView.RowTemplate.Height = 24;
            this.posjeta_bolestDataGridView.Size = new System.Drawing.Size(209, 119);
            this.posjeta_bolestDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID_bolesti";
            this.dataGridViewTextBoxColumn8.DataSource = this.bolestBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Naziv_bolesti";
            this.dataGridViewTextBoxColumn8.HeaderText = "Bolest";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "ID_bolesti";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // bolestBindingSource
            // 
            this.bolestBindingSource.DataMember = "Bolest";
            this.bolestBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // posjeta_lijekBindingSource
            // 
            this.posjeta_lijekBindingSource.DataMember = "FK__Posjeta_l__ID_po__440B1D61";
            this.posjeta_lijekBindingSource.DataSource = this.posjetaBindingSource;
            // 
            // posjeta_lijekDataGridView
            // 
            this.posjeta_lijekDataGridView.AutoGenerateColumns = false;
            this.posjeta_lijekDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.posjeta_lijekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posjeta_lijekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.posjeta_lijekDataGridView.DataSource = this.posjeta_lijekBindingSource;
            this.posjeta_lijekDataGridView.Location = new System.Drawing.Point(336, 416);
            this.posjeta_lijekDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.posjeta_lijekDataGridView.Name = "posjeta_lijekDataGridView";
            this.posjeta_lijekDataGridView.RowHeadersWidth = 51;
            this.posjeta_lijekDataGridView.RowTemplate.Height = 24;
            this.posjeta_lijekDataGridView.Size = new System.Drawing.Size(441, 119);
            this.posjeta_lijekDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ID_lijeka";
            this.dataGridViewTextBoxColumn11.DataSource = this.lijekBindingSource;
            this.dataGridViewTextBoxColumn11.DisplayMember = "Naziv_lijeka";
            this.dataGridViewTextBoxColumn11.HeaderText = "Lijek";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn11.ValueMember = "ID_lijeka";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataMember = "Lijek";
            this.lijekBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Doza";
            this.dataGridViewTextBoxColumn12.HeaderText = "Doza";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Nacin_primjene";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nacin_primjene";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 104);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proba.Properties.Resources.ambulanta1;
            this.pictureBox2.Location = new System.Drawing.Point(750, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(113, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cjeloviti pregled pacijentova stanja";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pacijentBindingNavigatorSaveItem
            // 
            this.pacijentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacijentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacijentBindingNavigatorSaveItem.Image")));
            this.pacijentBindingNavigatorSaveItem.Name = "pacijentBindingNavigatorSaveItem";
            this.pacijentBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.pacijentBindingNavigatorSaveItem.Text = "Save Data";
            this.pacijentBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacijentBindingNavigatorSaveItem_Click);
            // 
            // pacijentBindingNavigator
            // 
            this.pacijentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacijentBindingNavigator.BindingSource = this.pacijentBindingSource;
            this.pacijentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacijentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacijentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pacijentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pacijentBindingNavigatorSaveItem});
            this.pacijentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacijentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacijentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacijentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacijentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacijentBindingNavigator.Name = "pacijentBindingNavigator";
            this.pacijentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacijentBindingNavigator.Size = new System.Drawing.Size(844, 27);
            this.pacijentBindingNavigator.TabIndex = 0;
            this.pacijentBindingNavigator.Text = "bindingNavigator1";
            // 
            // frm_pacijent_sve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(844, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.posjeta_lijekDataGridView);
            this.Controls.Add(this.posjeta_bolestDataGridView);
            this.Controls.Add(this.posjetaDataGridView);
            this.Controls.Add(iD_pacijentaLabel);
            this.Controls.Add(this.iD_pacijentaTextBox);
            this.Controls.Add(ime_pacijentaLabel);
            this.Controls.Add(this.ime_pacijentaTextBox);
            this.Controls.Add(prezime_pacijentaLabel);
            this.Controls.Add(this.prezime_pacijentaTextBox);
            this.Controls.Add(datum_rodjenjaLabel);
            this.Controls.Add(this.datum_rodjenjaDateTimePicker);
            this.Controls.Add(this.pacijentBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_pacijent_sve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sve o pacijentu";
            this.Load += new System.EventHandler(this.frm_pacijent_sve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_bolestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_bolestDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_lijekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_lijekDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingNavigator)).EndInit();
            this.pacijentBindingNavigator.ResumeLayout(false);
            this.pacijentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lijecnikDataSet lijecnikDataSet;
        private System.Windows.Forms.BindingSource pacijentBindingSource;
        private lijecnikDataSetTableAdapters.PacijentTableAdapter pacijentTableAdapter;
        private lijecnikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private lijecnikDataSetTableAdapters.PosjetaTableAdapter posjetaTableAdapter;
        private System.Windows.Forms.TextBox iD_pacijentaTextBox;
        private System.Windows.Forms.TextBox ime_pacijentaTextBox;
        private System.Windows.Forms.TextBox prezime_pacijentaTextBox;
        private System.Windows.Forms.DateTimePicker datum_rodjenjaDateTimePicker;
        private System.Windows.Forms.BindingSource posjetaBindingSource;
        private lijecnikDataSetTableAdapters.Posjeta_bolestTableAdapter posjeta_bolestTableAdapter;
        private System.Windows.Forms.DataGridView posjetaDataGridView;
        private System.Windows.Forms.BindingSource posjeta_bolestBindingSource;
        private lijecnikDataSetTableAdapters.Posjeta_lijekTableAdapter posjeta_lijekTableAdapter;
        private System.Windows.Forms.DataGridView posjeta_bolestDataGridView;
        private System.Windows.Forms.BindingSource posjeta_lijekBindingSource;
        private System.Windows.Forms.DataGridView posjeta_lijekDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private lijecnikDataSetTableAdapters.LijecnikTableAdapter lijecnikTableAdapter;
        private System.Windows.Forms.BindingSource pacijentBindingSource1;
        private System.Windows.Forms.BindingSource lijecnikBindingSource;
        private lijecnikDataSetTableAdapters.BolestTableAdapter bolestTableAdapter;
        private System.Windows.Forms.BindingSource bolestBindingSource;
        private lijecnikDataSetTableAdapters.LijekTableAdapter lijekTableAdapter;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
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
        private System.Windows.Forms.ToolStripButton pacijentBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator pacijentBindingNavigator;
    }
}