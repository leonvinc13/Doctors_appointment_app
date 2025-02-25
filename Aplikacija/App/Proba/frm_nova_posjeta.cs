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
    public partial class frm_nova_posjeta : Form
    {
        public int ID_lijecnika;

        public frm_nova_posjeta(int ID_lijecnika)
        {
            InitializeComponent();
            this.ID_lijecnika = ID_lijecnika;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definiramo varijable pacijenta, datuma i razloga
            int ID_pacijenta = Convert.ToInt32(comboBox1.SelectedIndex)+1;
            DateTime datum = dateTimePicker1.Value;
            string razlog = textBox1.Text;
            //stvaranje nove konekcije
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
            //otvaranje konekcije
            connection.Open();
            //upit kojim umećemo vrijednosti gore definiranih varijabli u tablicu Posjeta
            string sql = "INSERT INTO Posjeta VALUES (@ID_pacijenta, @ID_lijecnika, @datum, @razlog)";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.Add("ID_pacijenta", ID_pacijenta);
            sqlCommand.Parameters.Add("datum", datum);
            sqlCommand.Parameters.Add("razlog", razlog);
            sqlCommand.Parameters.Add("ID_lijecnika", ID_lijecnika);
            sqlCommand.ExecuteNonQuery();
            //skočni izbornik s porukom uspješno dodano
            MessageBox.Show("Uspješno dodano!");
            //zatvaranje trenutne forme i otvaranje prošle
            this.Close();
            frm_lijecnicke_posjete frmPosjete = Application.OpenForms["frm_lijecnicke_posjete"] as frm_lijecnicke_posjete;
            //ako je forma otvorena 
            if (frmPosjete != null)
            {
                //pozovi metodu ucitaj na toj formi
                frmPosjete.Ucitaj();
            }
        }

        private void frm_nova_posjeta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Pacijent' table. You can move, or remove it, as needed.
            this.pacijentTableAdapter.Fill(this.lijecnikDataSet.Pacijent);
        }
    }
}
