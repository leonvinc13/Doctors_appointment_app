namespace Proba
{
    partial class frm_lijecnicki_lijekovi
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
            this.lijecnikDataSet = new Proba.lijecnikDataSet();
            this.posjeta_lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posjeta_lijekTableAdapter = new Proba.lijecnikDataSetTableAdapters.Posjeta_lijekTableAdapter();
            this.tableAdapterManager = new Proba.lijecnikDataSetTableAdapters.TableAdapterManager();
            this.lijekTableAdapter = new Proba.lijecnikDataSetTableAdapters.LijekTableAdapter();
            this.posjetaTableAdapter = new Proba.lijecnikDataSetTableAdapters.PosjetaTableAdapter();
            this.posjeta_lijekDataGridView = new System.Windows.Forms.DataGridView();
            this.ID_posjeta_lijek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.posjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.posjetaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_lijekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_lijekDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lijecnikDataSet
            // 
            this.lijecnikDataSet.DataSetName = "lijecnikDataSet";
            this.lijecnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posjeta_lijekBindingSource
            // 
            this.posjeta_lijekBindingSource.DataMember = "Posjeta_lijek";
            this.posjeta_lijekBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // posjeta_lijekTableAdapter
            // 
            this.posjeta_lijekTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BolestTableAdapter = null;
            this.tableAdapterManager.CijepljenjeTableAdapter = null;
            this.tableAdapterManager.CjepivoTableAdapter = null;
            this.tableAdapterManager.LijecnikTableAdapter = null;
            this.tableAdapterManager.LijekTableAdapter = this.lijekTableAdapter;
            this.tableAdapterManager.PacijentTableAdapter = null;
            this.tableAdapterManager.Posjeta_bolestTableAdapter = null;
            this.tableAdapterManager.Posjeta_lijekTableAdapter = this.posjeta_lijekTableAdapter;
            this.tableAdapterManager.PosjetaTableAdapter = this.posjetaTableAdapter;
            this.tableAdapterManager.SpecijalizacijaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proba.lijecnikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lijekTableAdapter
            // 
            this.lijekTableAdapter.ClearBeforeFill = true;
            // 
            // posjetaTableAdapter
            // 
            this.posjetaTableAdapter.ClearBeforeFill = true;
            // 
            // posjeta_lijekDataGridView
            // 
            this.posjeta_lijekDataGridView.AutoGenerateColumns = false;
            this.posjeta_lijekDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.posjeta_lijekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posjeta_lijekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_posjeta_lijek,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.posjeta_lijekDataGridView.DataSource = this.posjeta_lijekBindingSource;
            this.posjeta_lijekDataGridView.Location = new System.Drawing.Point(81, 159);
            this.posjeta_lijekDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.posjeta_lijekDataGridView.Name = "posjeta_lijekDataGridView";
            this.posjeta_lijekDataGridView.RowHeadersWidth = 51;
            this.posjeta_lijekDataGridView.Size = new System.Drawing.Size(893, 271);
            this.posjeta_lijekDataGridView.TabIndex = 1;
            this.posjeta_lijekDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.posjeta_lijekDataGridView_CellContentClick);
            // 
            // ID_posjeta_lijek
            // 
            this.ID_posjeta_lijek.DataPropertyName = "ID_posjeta_lijek";
            this.ID_posjeta_lijek.HeaderText = "ID_posjeta_lijek";
            this.ID_posjeta_lijek.MinimumWidth = 6;
            this.ID_posjeta_lijek.Name = "ID_posjeta_lijek";
            this.ID_posjeta_lijek.ReadOnly = true;
            this.ID_posjeta_lijek.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_posjete";
            this.dataGridViewTextBoxColumn2.DataSource = this.posjetaBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Razlog_posjete";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_posjete";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID_posjete";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // posjetaBindingSource
            // 
            this.posjetaBindingSource.DataMember = "Posjeta";
            this.posjetaBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_lijeka";
            this.dataGridViewTextBoxColumn3.DataSource = this.lijekBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Naziv_lijeka";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_lijeka";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_lijeka";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataMember = "Lijek";
            this.lijekBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Doza";
            this.dataGridViewTextBoxColumn4.HeaderText = "Doza";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nacin_primjene";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nacin_primjene";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(459, 459);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Izdavanje novog lijeka";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // posjetaBindingSource1
            // 
            this.posjetaBindingSource1.DataMember = "Posjeta";
            this.posjetaBindingSource1.DataSource = this.lijecnikDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 128);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proba.Properties.Resources.ambulanta1;
            this.pictureBox2.Location = new System.Drawing.Point(935, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
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
            this.label2.Location = new System.Drawing.Point(360, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "Izdani lijekovi";
            // 
            // frm_lijecnicki_lijekovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.posjeta_lijekDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_lijecnicki_lijekovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdavanje lijekova";
            this.Load += new System.EventHandler(this.frm_lijecnicki_lijekovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_lijekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_lijekDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private lijecnikDataSet lijecnikDataSet;
        private System.Windows.Forms.BindingSource posjeta_lijekBindingSource;
        private lijecnikDataSetTableAdapters.Posjeta_lijekTableAdapter posjeta_lijekTableAdapter;
        private lijecnikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView posjeta_lijekDataGridView;
        private lijecnikDataSetTableAdapters.PosjetaTableAdapter posjetaTableAdapter;
        private System.Windows.Forms.BindingSource posjetaBindingSource;
        private lijecnikDataSetTableAdapters.LijekTableAdapter lijekTableAdapter;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource posjetaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_posjeta_lijek;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}