using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba
{
    public partial class frm_lijecnicki_lijekovi : Form
    {
        public frm_lijecnicki_lijekovi()
        {
            InitializeComponent();
        }

        private void posjeta_lijekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.posjeta_lijekBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }

        private void frm_lijecnicki_lijekovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Lijek' table. You can move, or remove it, as needed.
            this.lijekTableAdapter.Fill(this.lijecnikDataSet.Lijek);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Posjeta' table. You can move, or remove it, as needed.
            this.posjetaTableAdapter.Fill(this.lijecnikDataSet.Posjeta);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Posjeta_lijek' table. You can move, or remove it, as needed.
            this.posjeta_lijekTableAdapter.Fill(this.lijecnikDataSet.Posjeta_lijek);
            posjeta_lijekDataGridView.Columns.Add("obriši", "");
            posjeta_lijekDataGridView.Columns["ID_posjeta_lijek"].Visible = false;
            //dodajemo obriši za svaki redak
            for (int i = 0; i < posjeta_lijekDataGridView.Rows.Count - 1; i++)
            {
                posjeta_lijekDataGridView.Rows[i].Cells["obriši"].Value = "Obriši";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //otvaranje noce forme
            Form form = new frm_novi_lijek();
            form.ShowDialog();
            this.posjeta_lijekTableAdapter.Fill(this.lijecnikDataSet.Posjeta_lijek);
            //dodavanje stupva obriši
            posjeta_lijekDataGridView.Columns.Add("obriši", "");
            //dodajemo obriši za svaki redak
            for (int i = 0; i < posjeta_lijekDataGridView.Rows.Count - 1; i++)
            {
                posjeta_lijekDataGridView.Rows[i].Cells["obriši"].Value = "Obriši";
            }
        }

        private void posjeta_lijekDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kod za brisanje se pokreće ako je kliknut stupac za brisanje
            if (e.ColumnIndex == posjeta_lijekDataGridView.Columns["obriši"].Index)
            {
                //Odabir točno te ćelije
                int ID_posjeta_lijek = (int)posjeta_lijekDataGridView.Rows[e.RowIndex].Cells["ID_posjeta_lijek"].Value;
                //brisnje onog reda u kojem je ćelija kliknuta
                posjeta_lijekDataGridView.Rows.RemoveAt(e.RowIndex);
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
                connection.Open();
                //upit brisanja iz baze podataka
                string sql = "DELETE FROM Posjeta_lijek WHERE ID_posjeta_lijek=@ID_posjeta_lijek";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.Parameters.AddWithValue("ID_posjeta_lijek", ID_posjeta_lijek);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
