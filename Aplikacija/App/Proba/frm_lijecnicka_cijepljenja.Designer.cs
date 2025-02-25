namespace Proba
{
    partial class frm_lijecnicka_cijepljenja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lijecnikDataSet = new Proba.lijecnikDataSet();
            this.cijepljenjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cijepljenjeTableAdapter = new Proba.lijecnikDataSetTableAdapters.CijepljenjeTableAdapter();
            this.tableAdapterManager = new Proba.lijecnikDataSetTableAdapters.TableAdapterManager();
            this.pacijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cjepivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.posjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posjetaTableAdapter = new Proba.lijecnikDataSetTableAdapters.PosjetaTableAdapter();
            this.pacijentTableAdapter = new Proba.lijecnikDataSetTableAdapters.PacijentTableAdapter();
            this.cjepivoTableAdapter = new Proba.lijecnikDataSetTableAdapters.CjepivoTableAdapter();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_cijepljenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijepljenjeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cijepljenjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjepivoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cijepljenjeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lijecnikDataSet
            // 
            this.lijecnikDataSet.DataSetName = "lijecnikDataSet";
            this.lijecnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cijepljenjeBindingSource
            // 
            this.cijepljenjeBindingSource.DataMember = "Cijepljenje";
            this.cijepljenjeBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // cijepljenjeTableAdapter
            // 
            this.cijepljenjeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BolestTableAdapter = null;
            this.tableAdapterManager.CijepljenjeTableAdapter = this.cijepljenjeTableAdapter;
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
            // pacijentBindingSource
            // 
            this.pacijentBindingSource.DataMember = "Pacijent";
            this.pacijentBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // cjepivoBindingSource
            // 
            this.cjepivoBindingSource.DataMember = "Cjepivo";
            this.cjepivoBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(439, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Novo cijepljenje";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 1);
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
            this.label2.Location = new System.Drawing.Point(387, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cijepljenja";
            // 
            // posjetaBindingSource
            // 
            this.posjetaBindingSource.DataMember = "Posjeta";
            this.posjetaBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // posjetaTableAdapter
            // 
            this.posjetaTableAdapter.ClearBeforeFill = true;
            // 
            // pacijentTableAdapter
            // 
            this.pacijentTableAdapter.ClearBeforeFill = true;
            // 
            // cjepivoTableAdapter
            // 
            this.cjepivoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nuspojave";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nuspojave";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Datum_cjepljenja";
            this.dataGridViewTextBoxColumn4.HeaderText = "Datum_cjepljenja";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_cjepiva";
            this.dataGridViewTextBoxColumn3.DataSource = this.cjepivoBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Vrsta_cjepiva";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_cjepiva";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_cjepiva";
            this.dataGridViewTextBoxColumn3.Width = 125;
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
            // ID_cijepljenja
            // 
            this.ID_cijepljenja.DataPropertyName = "ID_cijepljenja";
            this.ID_cijepljenja.HeaderText = "ID_cijepljenja";
            this.ID_cijepljenja.MinimumWidth = 6;
            this.ID_cijepljenja.Name = "ID_cijepljenja";
            this.ID_cijepljenja.ReadOnly = true;
            this.ID_cijepljenja.Width = 125;
            // 
            // cijepljenjeDataGridView
            // 
            this.cijepljenjeDataGridView.AutoGenerateColumns = false;
            this.cijepljenjeDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cijepljenjeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cijepljenjeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cijepljenjeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_cijepljenja,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.cijepljenjeDataGridView.DataSource = this.cijepljenjeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cijepljenjeDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.cijepljenjeDataGridView.Location = new System.Drawing.Point(98, 170);
            this.cijepljenjeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.cijepljenjeDataGridView.Name = "cijepljenjeDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cijepljenjeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cijepljenjeDataGridView.RowHeadersWidth = 51;
            this.cijepljenjeDataGridView.Size = new System.Drawing.Size(859, 237);
            this.cijepljenjeDataGridView.TabIndex = 1;
            this.cijepljenjeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cijepljenjeDataGridView_CellContentClick);
            // 
            // frm_lijecnicka_cijepljenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cijepljenjeDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_lijecnicka_cijepljenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cijepljenja";
            this.Load += new System.EventHandler(this.frm_lijecnicka_cijepljenja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cijepljenjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjepivoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cijepljenjeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private lijecnikDataSet lijecnikDataSet;
        private System.Windows.Forms.BindingSource cijepljenjeBindingSource;
        private lijecnikDataSetTableAdapters.CijepljenjeTableAdapter cijepljenjeTableAdapter;
        private lijecnikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource posjetaBindingSource;
        private lijecnikDataSetTableAdapters.PosjetaTableAdapter posjetaTableAdapter;
        private System.Windows.Forms.BindingSource pacijentBindingSource;
        private lijecnikDataSetTableAdapters.PacijentTableAdapter pacijentTableAdapter;
        private System.Windows.Forms.BindingSource cjepivoBindingSource;
        private lijecnikDataSetTableAdapters.CjepivoTableAdapter cjepivoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_cijepljenja;
        private System.Windows.Forms.DataGridView cijepljenjeDataGridView;
    }
}