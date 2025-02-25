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
    public partial class frm_lijecnicke_posjete : Form
    {
        public int ID_lijecnika;

        public frm_lijecnicke_posjete(int ID_lijecnika)
        {
            InitializeComponent();
            this.ID_lijecnika = ID_lijecnika;
        }

        //prilikom učitavanja forme izvršava se funkcija učitaj
        private void frm_nova_posjeta_Load(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //otvaranje forme nova posjeta
            Form form = new frm_nova_posjeta(ID_lijecnika);
            form.ShowDialog();
        }

        //funkcija učitaj
        public void Ucitaj()
        {
            // stvaranje novog objekta za uspostavu veze s bazom
             SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
            //otvaranje veze (konekcije)
            connection.Open();
            //odabiremo stupce iz različith tablica povezane INNER JOIN-om za koji je isti ID lijecnika
            string sql = "SELECT ID_posjete, Pacijent.Ime_pacijenta, Datum_posjete, Razlog_posjete " +
                "FROM Posjeta INNER JOIN Pacijent ON Pacijent.ID_pacijenta=Posjeta.ID_pacijenta " +
                "WHERE ID_lijecnika=@ID_lijecnika";
            //dodjeljivanje sql upita koji je definiran u varijabli sql
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            //dodavanje parametara
            sqlCommand.Parameters.Add("ID_lijecnika", ID_lijecnika);
            //izvršavanje upita
            SqlDataReader reader = sqlCommand.ExecuteReader();
            //stvaranje nove tablice
            DataTable table = new DataTable();
            table.Load(reader);
            //popunjavanje dataGridView podacima iz tablica na temelju upita
            dataGridView1.DataSource = table;
            //dodavanje stupca pod nazivom obriši u dataGridView
            dataGridView1.Columns.Add("obriši", "");
            //sakrivanje stupca ID_posjete
            dataGridView1.Columns["ID_posjete"].Visible = false;
            //dodajemo obriši za svaki redak
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dataGridView1.Rows[i].Cells["obriši"].Value = "Obriši";
            }
        }

        //pritskom na ćeliju
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kod za brisanje se pokreće ako je kliknut stupac obriši
            if (e.ColumnIndex == dataGridView1.Columns["obriši"].Index)
            {
                //Odabir točno te ćelije
                int ID_posjeta = (int) dataGridView1.Rows[e.RowIndex].Cells["ID_posjete"].Value;
                //brisnje onog reda u kojem je ćelija kliknuta
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
                connection.Open();
                //upit brisanja iz baze podataka
                string sql = "DELETE FROM Posjeta WHERE ID_posjete=@ID_posjete";
                SqlCommand sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.Parameters.AddWithValue("ID_posjete", ID_posjeta);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
