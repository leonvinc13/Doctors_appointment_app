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
    public partial class frm_moja_cijepljenja : Form
    {
        public frm_moja_cijepljenja(int ID_pacijenta)
        {
            InitializeComponent();
            this.ID_pacijenta = ID_pacijenta;
        }

        public int ID_pacijenta;

        private void frm_moja_cijepljenja_Load(object sender, EventArgs e)
        {

            //stvaranje novog objekta za uspostavu veze s bazom
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
            //otvaranje veze (konekcije)
            connection.Open();
            //upit uzima stupce iz različitih tablica koje se povezuju vezama (INNER JOIN)
            string sql = "SELECT Vrsta_cjepiva, Cijepljenje.Nuspojave, Cijepljenje.Datum_cjepljenja FROM Cjepivo" +
                " INNER JOIN Cijepljenje ON Cijepljenje.ID_cjepiva = Cjepivo.ID_cjepiva" +
                " INNER JOIN Pacijent ON Pacijent.ID_pacijenta = Cijepljenje.ID_pacijenta" +
                " WHERE Pacijent.ID_pacijenta = @ID_pacijenta";
            //dodjeljivanje sql upita koji je definiran u varijabli sql
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            //dodavanje parametara
            sqlCommand.Parameters.Add("ID_pacijenta", ID_pacijenta);
            //izvršavanje upita
            SqlDataReader reader = sqlCommand.ExecuteReader();
            //stvaranje nove tablice
            DataTable table = new DataTable();
            table.Load(reader);
            //popunjavanje dataGridViewa podacima iz tablice
            dataGridView1.DataSource = table;
        }
    }
}
