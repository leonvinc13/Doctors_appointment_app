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
    public partial class frm_novi_lijek : Form
    {
        public frm_novi_lijek()
        {
            InitializeComponent();
        }

        private void frm_novi_lijek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Lijek' table. You can move, or remove it, as needed.
            this.lijekTableAdapter.Fill(this.lijecnikDataSet.Lijek);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Posjeta' table. You can move, or remove it, as needed.
            this.posjetaTableAdapter.Fill(this.lijecnikDataSet.Posjeta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definiranje varijabli koej se upisuju
            int ID_posjete = Convert.ToInt32(comboBox1.SelectedIndex) + 1;
            int ID_lijeka = Convert.ToInt32(comboBox2.SelectedIndex) + 1;
            string  doza = textBox1.Text;
            string nacin_primjene = textBox2.Text;
            //stvaranje i otvaranje konekcije
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
            connection.Open();
            //upit za dodavanje novih podataka u tablicu Posjeta_lijek
            string sql = "INSERT INTO Posjeta_lijek VALUES (@ID_posjete, @ID_lijeka, @doza, @nacin_primjene)";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.Add("ID_posjete", ID_posjete);
            sqlCommand.Parameters.Add("ID_lijeka", ID_lijeka);
            sqlCommand.Parameters.Add("doza", doza);
            sqlCommand.Parameters.Add("nacin_primjene", nacin_primjene);
            sqlCommand.ExecuteNonQuery();
            //poruka
            MessageBox.Show("Uspješno dodano!");
            this.Close();
        }
    }
}
