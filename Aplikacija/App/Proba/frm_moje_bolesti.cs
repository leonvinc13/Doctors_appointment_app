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
    public partial class frm_moje_bolesti : Form
    {
        //konstruktor prima ID pacijenta kao argument i inicijalizira novu instancu forme frm_moje_bolesti
        public frm_moje_bolesti(int ID_pacijenta)
        {
            InitializeComponent();
            this.ID_pacijenta = ID_pacijenta;
        }

        //deklaracija javne varijable ID_pacijenta
        public int ID_pacijenta;

        private void frm_moje_bolesti_Load(object sender, EventArgs e)
        {
            //stvaranje novog objekta za uspostavu veze s bazom
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
            //otvaranje veze (konekcije)
            connection.Open();
            //upit uzima stupce iz različitih tablica koje se povezuju vezama (INNER JOIN)
            string sql = "SELECT Naziv_bolesti, Opis_bolesti FROM Bolest" +
                " INNER JOIN Posjeta_bolest ON Posjeta_bolest.ID_bolesti = Bolest.ID_bolesti" +
                " INNER JOIN Posjeta ON Posjeta.ID_posjete = Posjeta_bolest.ID_posjete" +
                " INNER JOIN Pacijent ON Pacijent.ID_pacijenta = Posjeta.ID_pacijenta" +
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
