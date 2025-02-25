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
    public partial class frm_statistika : Form
    {
        public frm_statistika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //stvaranje i otvaranje konekcije
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
            connection.Open();
            //upit - odabiremo stupce Ime liječnika, Ukupno posjeta (Prebrojavanje posjeta svakog liječnika) spajanjem tablica (INNER JOIN)
            string sql = "SELECT Ime_lijecnika as 'Ime', COUNT(*) as 'Ukupno posjeta' FROM Lijecnik INNER JOIN Posjeta ON Posjeta.ID_lijecnika=Lijecnik.ID_lijecnika GROUP BY Ime_lijecnika ORDER BY 'Ukupno posjeta' DESC";
            SqlCommand comand = new SqlCommand(sql, connection);
            SqlDataReader reader = comand.ExecuteReader();
            //stvaranje nove tablcie
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            //popunjavanje grafikona podacima
            chart1.DataSource = table;
            //postavljanje x osi grafikona da bude ime liječnika
            chart1.Series["Series1"].XValueMember = "Ime";
            //postavljanje y osi grafikona da bude ukupno posjeta pojedinog liječnika
            chart1.Series["Series1"].YValueMembers = "Ukupno posjeta";
            chart1.DataBind();
        }
    }
}
