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
    public partial class frm_lijecnicka_cijepljenja : Form
    {
        public frm_lijecnicka_cijepljenja()
        {
            InitializeComponent();
        }

        private void cijepljenjeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cijepljenjeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }

        private void frm_lijecnicka_cijepljenja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Cjepivo' table. You can move, or remove it, as needed.
            this.cjepivoTableAdapter.Fill(this.lijecnikDataSet.Cjepivo);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Pacijent' table. You can move, or remove it, as needed.
            this.pacijentTableAdapter.Fill(this.lijecnikDataSet.Pacijent);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Posjeta' table. You can move, or remove it, as needed.
            this.posjetaTableAdapter.Fill(this.lijecnikDataSet.Posjeta);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Cijepljenje' table. You can move, or remove it, as needed.
            this.cijepljenjeTableAdapter.Fill(this.lijecnikDataSet.Cijepljenje);
            //dodajemo stupac naziva obriši u tablicu 
            cijepljenjeDataGridView.Columns.Add("obriši", "");
            cijepljenjeDataGridView.Columns["ID_cijepljenja"].Visible = false;
            //dodajemo obriši za svaki redak
            for (int i = 0; i < cijepljenjeDataGridView.Rows.Count - 1; i++)
            {
                cijepljenjeDataGridView.Rows[i].Cells["obriši"].Value = "Obriši";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //otvaranje nove forme za dodavanje novog cijepiva
            Form form = new frm_novo_cijepljenje();
            form.ShowDialog();
            this.cijepljenjeTableAdapter.Fill(this.lijecnikDataSet.Cijepljenje);
            cijepljenjeDataGridView.Columns.Add("obriši", "");
            //dodajemo obriši za svaki redak
            for (int i = 0; i < cijepljenjeDataGridView.Rows.Count - 1; i++)
            {
                cijepljenjeDataGridView.Rows[i].Cells["obriši"].Value = "Obriši";
            }
        }

        private void cijepljenjeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kod za brisanje se pokreće ako je kliknut stupac za brisanje
            if (e.ColumnIndex == cijepljenjeDataGridView.Columns["obriši"].Index)
            {
                //Odabir točno te ćelije
                int ID_cijepljenja = (int)cijepljenjeDataGridView.Rows[e.RowIndex].Cells["ID_cijepljenja"].Value;
                //brišemo red u tablici u kojem je ćelija na koju smo kliknuli
                cijepljenjeDataGridView.Rows.RemoveAt(e.RowIndex);
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
                connection.Open();
                //upit za brisanje cijepljenja iz baze
                string sql = "DELETE FROM Cijepljenje WHERE ID_cijepljenja=@ID_cijepljenja";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.Parameters.AddWithValue("ID_cijepljenja", ID_cijepljenja);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
