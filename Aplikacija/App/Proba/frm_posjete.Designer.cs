namespace Proba
{
    partial class frm_posjete
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
            this.posjetaDataGridView = new System.Windows.Forms.DataGridView();
            this.pacijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijecnikDataSet = new Proba.lijecnikDataSet();
            this.lijecnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posjetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.fillByDatumToolStrip = new System.Windows.Forms.ToolStrip();
            this.datum_posjeteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.datum_posjeteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByDatumToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.posjetaTableAdapter = new Proba.lijecnikDataSetTableAdapters.PosjetaTableAdapter();
            this.tableAdapterManager = new Proba.lijecnikDataSetTableAdapters.TableAdapterManager();
            this.lijecnikTableAdapter = new Proba.lijecnikDataSetTableAdapters.LijecnikTableAdapter();
            this.lijekTableAdapter = new Proba.lijecnikDataSetTableAdapters.LijekTableAdapter();
            this.pacijentTableAdapter = new Proba.lijecnikDataSetTableAdapters.PacijentTableAdapter();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.fillByDatumToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.posjetaDataGridView.Location = new System.Drawing.Point(33, 141);
            this.posjetaDataGridView.Name = "posjetaDataGridView";
            this.posjetaDataGridView.RowHeadersWidth = 51;
            this.posjetaDataGridView.Size = new System.Drawing.Size(673, 294);
            this.posjetaDataGridView.TabIndex = 1;
            // 
            // pacijentBindingSource
            // 
            this.pacijentBindingSource.DataMember = "Pacijent";
            this.pacijentBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // lijecnikDataSet
            // 
            this.lijecnikDataSet.DataSetName = "lijecnikDataSet";
            this.lijecnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lijecnikBindingSource
            // 
            this.lijecnikBindingSource.DataMember = "Lijecnik";
            this.lijecnikBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // posjetaBindingSource
            // 
            this.posjetaBindingSource.DataMember = "Posjeta";
            this.posjetaBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 101);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proba.Properties.Resources.ambulanta1;
            this.pictureBox2.Location = new System.Drawing.Point(816, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(396, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Posjete";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(749, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(752, 246);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(745, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pretraži po datumu:";
            // 
            // fillByDatumToolStrip
            // 
            this.fillByDatumToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datum_posjeteToolStripLabel,
            this.datum_posjeteToolStripTextBox,
            this.fillByDatumToolStripButton});
            this.fillByDatumToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByDatumToolStrip.Name = "fillByDatumToolStrip";
            this.fillByDatumToolStrip.Size = new System.Drawing.Size(904, 25);
            this.fillByDatumToolStrip.TabIndex = 7;
            this.fillByDatumToolStrip.Text = "fillByDatumToolStrip";
            this.fillByDatumToolStrip.Visible = false;
            // 
            // datum_posjeteToolStripLabel
            // 
            this.datum_posjeteToolStripLabel.Name = "datum_posjeteToolStripLabel";
            this.datum_posjeteToolStripLabel.Size = new System.Drawing.Size(89, 22);
            this.datum_posjeteToolStripLabel.Text = "Datum_posjete:";
            // 
            // datum_posjeteToolStripTextBox
            // 
            this.datum_posjeteToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datum_posjeteToolStripTextBox.Name = "datum_posjeteToolStripTextBox";
            this.datum_posjeteToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByDatumToolStripButton
            // 
            this.fillByDatumToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByDatumToolStripButton.Name = "fillByDatumToolStripButton";
            this.fillByDatumToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.fillByDatumToolStripButton.Text = "FillByDatum";
            this.fillByDatumToolStripButton.Click += new System.EventHandler(this.fillByDatumToolStripButton_Click);
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
            this.tableAdapterManager.LijecnikTableAdapter = this.lijecnikTableAdapter;
            this.tableAdapterManager.LijekTableAdapter = this.lijekTableAdapter;
            this.tableAdapterManager.PacijentTableAdapter = this.pacijentTableAdapter;
            this.tableAdapterManager.Posjeta_bolestTableAdapter = null;
            this.tableAdapterManager.Posjeta_lijekTableAdapter = null;
            this.tableAdapterManager.PosjetaTableAdapter = this.posjetaTableAdapter;
            this.tableAdapterManager.SpecijalizacijaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proba.lijecnikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lijecnikTableAdapter
            // 
            this.lijecnikTableAdapter.ClearBeforeFill = true;
            // 
            // lijekTableAdapter
            // 
            this.lijekTableAdapter.ClearBeforeFill = true;
            // 
            // pacijentTableAdapter
            // 
            this.pacijentTableAdapter.ClearBeforeFill = true;
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataMember = "Lijek";
            this.lijekBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_posjete";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_posjete";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Datum_posjete";
            this.dataGridViewTextBoxColumn4.HeaderText = "Datum_posjete";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Razlog_posjete";
            this.dataGridViewTextBoxColumn5.HeaderText = "Razlog_posjete";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // frm_posjete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(911, 507);
            this.Controls.Add(this.fillByDatumToolStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.posjetaDataGridView);
            this.Name = "frm_posjete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posjete";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posjetaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.fillByDatumToolStrip.ResumeLayout(false);
            this.fillByDatumToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lijecnikDataSet lijecnikDataSet;
        private System.Windows.Forms.BindingSource posjetaBindingSource;
        private lijecnikDataSetTableAdapters.PosjetaTableAdapter posjetaTableAdapter;
        private lijecnikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView posjetaDataGridView;
        private lijecnikDataSetTableAdapters.PacijentTableAdapter pacijentTableAdapter;
        private System.Windows.Forms.BindingSource pacijentBindingSource;
        private lijecnikDataSetTableAdapters.LijekTableAdapter lijekTableAdapter;
        private System.Windows.Forms.BindingSource lijekBindingSource;
        private lijecnikDataSetTableAdapters.LijecnikTableAdapter lijecnikTableAdapter;
        private System.Windows.Forms.BindingSource lijecnikBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip fillByDatumToolStrip;
        private System.Windows.Forms.ToolStripLabel datum_posjeteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox datum_posjeteToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByDatumToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}