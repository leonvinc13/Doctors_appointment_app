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
    public partial class frm_lijecnicke_bolesti : Form
    {
        public frm_lijecnicke_bolesti()
        {
            InitializeComponent();
        }

        private void posjeta_bolestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.posjeta_bolestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }

        private void frm_lijecnicke_bolesti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Bolest' table. You can move, or remove it, as needed.
            this.bolestTableAdapter.Fill(this.lijecnikDataSet.Bolest);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Posjeta' table. You can move, or remove it, as needed.
            this.posjetaTableAdapter.Fill(this.lijecnikDataSet.Posjeta);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Posjeta_bolest' table. You can move, or remove it, as needed.
            this.posjeta_bolestTableAdapter.Fill(this.lijecnikDataSet.Posjeta_bolest);
            //dodavanje stupca pod nazivom obriši u dataGridView
            posjeta_bolestDataGridView.Columns.Add("obriši", "");
            //dodajemo obriši za svaki redak
            for (int i = 0; i < posjeta_bolestDataGridView.Rows.Count - 1; i++)
            {
                posjeta_bolestDataGridView.Rows[i].Cells["obriši"].Value = "Obriši";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //otvaranje nove forme
            Form form = new frm_nova_bolest();
            form.ShowDialog();
            //popunjavanje tablice podacima 
            this.posjeta_bolestTableAdapter.Fill(this.lijecnikDataSet.Posjeta_bolest);
            posjeta_bolestDataGridView.Columns.Add("obriši", "");
            //dodajemo obriši za svaki redak
            for (int i = 0; i < posjeta_bolestDataGridView.Rows.Count - 1; i++)
            {
                posjeta_bolestDataGridView.Rows[i].Cells["obriši"].Value = "Obriši";
            }
        }

        private void posjeta_bolestDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kod za brisanje se pokreće ako je kliknut stupac za brisanje
            if (e.ColumnIndex == posjeta_bolestDataGridView.Columns["obriši"].Index)
            {
                //Odabir točno te ćelije
                int ID_posjeta_bolest = (int)posjeta_bolestDataGridView.Rows[e.RowIndex].Cells["ID_posjeta_bolest"].Value;
                //brisnje onog reda u kojem je ćelija kliknuta
                posjeta_bolestDataGridView.Rows.RemoveAt(e.RowIndex);
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
                connection.Open();
                //upit brisanja iz baze podataka
                string sql = "DELETE FROM Posjeta_bolest WHERE ID_posjeta_bolest=@ID_posjeta_bolest";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.Parameters.AddWithValue("ID_posjeta_bolest", ID_posjeta_bolest);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
