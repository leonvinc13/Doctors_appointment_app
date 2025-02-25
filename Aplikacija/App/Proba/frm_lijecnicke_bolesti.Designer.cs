namespace Proba
{
    partial class frm_lijecnicke_bolesti
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
            this.posjeta_bolestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posjeta_bolestTableAdapter = new Proba.lijecnikDataSetTableAdapters.Posjeta_bolestTableAdapter();
            this.tableAdapterManager = new Proba.lijecnikDataSetTableAdapters.TableAdapterManager();
            this.bolestTableAdapter = new Proba.lijecnikDataSetTableAdapters.BolestTableAdapter();
            this.posjetaTableAdapter = new Proba.lijecnikDataSetTableAdapters.PosjetaTableAdapter();
            this.posjeta_bolestDataGridView = new System.Windows.Forms.DataGridView();
            this.posjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_posjeta_bolest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_bolestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_bolestDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lijecnikDataSet
            // 
            this.lijecnikDataSet.DataSetName = "lijecnikDataSet";
            this.lijecnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posjeta_bolestBindingSource
            // 
            this.posjeta_bolestBindingSource.DataMember = "Posjeta_bolest";
            this.posjeta_bolestBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // posjeta_bolestTableAdapter
            // 
            this.posjeta_bolestTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Posjeta_bolestTableAdapter = this.posjeta_bolestTableAdapter;
            this.tableAdapterManager.Posjeta_lijekTableAdapter = null;
            this.tableAdapterManager.PosjetaTableAdapter = this.posjetaTableAdapter;
            this.tableAdapterManager.SpecijalizacijaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proba.lijecnikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bolestTableAdapter
            // 
            this.bolestTableAdapter.ClearBeforeFill = true;
            // 
            // posjetaTableAdapter
            // 
            this.posjetaTableAdapter.ClearBeforeFill = true;
            // 
            // posjeta_bolestDataGridView
            // 
            this.posjeta_bolestDataGridView.AutoGenerateColumns = false;
            this.posjeta_bolestDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.posjeta_bolestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posjeta_bolestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_posjeta_bolest,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.posjeta_bolestDataGridView.DataSource = this.posjeta_bolestBindingSource;
            this.posjeta_bolestDataGridView.Location = new System.Drawing.Point(216, 161);
            this.posjeta_bolestDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.posjeta_bolestDataGridView.Name = "posjeta_bolestDataGridView";
            this.posjeta_bolestDataGridView.RowHeadersWidth = 51;
            this.posjeta_bolestDataGridView.Size = new System.Drawing.Size(689, 271);
            this.posjeta_bolestDataGridView.TabIndex = 1;
            this.posjeta_bolestDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.posjeta_bolestDataGridView_CellContentClick);
            // 
            // posjetaBindingSource
            // 
            this.posjetaBindingSource.DataMember = "Posjeta";
            this.posjetaBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // bolestBindingSource
            // 
            this.bolestBindingSource.DataMember = "Bolest";
            this.bolestBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(433, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dijagnosticiranje nove bolesti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 128);
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
            this.label2.Location = new System.Drawing.Point(448, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bolesti ";
            // 
            // ID_posjeta_bolest
            // 
            this.ID_posjeta_bolest.DataPropertyName = "ID_posjeta_bolest";
            this.ID_posjeta_bolest.HeaderText = "ID_posjeta_bolest";
            this.ID_posjeta_bolest.MinimumWidth = 6;
            this.ID_posjeta_bolest.Name = "ID_posjeta_bolest";
            this.ID_posjeta_bolest.ReadOnly = true;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_bolesti";
            this.dataGridViewTextBoxColumn3.DataSource = this.bolestBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Naziv_bolesti";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_bolesti";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_bolesti";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // frm_lijecnicke_bolesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.posjeta_bolestDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_lijecnicke_bolesti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolesti kod posjeta";
            this.Load += new System.EventHandler(this.frm_lijecnicke_bolesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_bolestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjeta_bolestDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolestBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private lijecnikDataSet lijecnikDataSet;
        private System.Windows.Forms.BindingSource posjeta_bolestBindingSource;
        private lijecnikDataSetTableAdapters.Posjeta_bolestTableAdapter posjeta_bolestTableAdapter;
        private lijecnikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView posjeta_bolestDataGridView;
        private System.Windows.Forms.Button button1;
        private lijecnikDataSetTableAdapters.PosjetaTableAdapter posjetaTableAdapter;
        private System.Windows.Forms.BindingSource posjetaBindingSource;
        private lijecnikDataSetTableAdapters.BolestTableAdapter bolestTableAdapter;
        private System.Windows.Forms.BindingSource bolestBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_posjeta_bolest;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}