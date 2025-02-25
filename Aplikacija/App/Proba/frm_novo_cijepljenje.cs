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
    public partial class frm_novo_cijepljenje : Form
    {
        public frm_novo_cijepljenje()
        {
            InitializeComponent();
        }

        private void Novo_cijepljenje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Cjepivo' table. You can move, or remove it, as needed.
            this.cjepivoTableAdapter.Fill(this.lijecnikDataSet.Cjepivo);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Pacijent' table. You can move, or remove it, as needed.
            this.pacijentTableAdapter.Fill(this.lijecnikDataSet.Pacijent);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definiranje varijabli koje upisujemo
            int ID_pacijenta = Convert.ToInt32(comboBox1.SelectedIndex) + 1;
            int ID_cjepiva = Convert.ToInt32(comboBox2.SelectedIndex) + 1;
            DateTime Datum_cjepljenja = dateTimePicker1.Value;
            string Nuspojave = textBox1.Text;
            //stvaranje i otvaranje konekcije
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
            connection.Open();
            //upit ua ubacivanje vrijednosti u tablicu cijepljenja
            string sql = "INSERT INTO Cijepljenje VALUES (@ID_pacijenta, @ID_cjepiva, @Datum_cjepljenja, @Nuspojave)";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.Add("ID_pacijenta", ID_pacijenta);
            sqlCommand.Parameters.Add("ID_cjepiva", ID_cjepiva);
            sqlCommand.Parameters.Add("Datum_cjepljenja", Datum_cjepljenja);
            sqlCommand.Parameters.Add("Nuspojave", Nuspojave);
            sqlCommand.ExecuteNonQuery();
            //poruka
            MessageBox.Show("Uspješno dodano!");
            this.Close();
        }
    }
}
