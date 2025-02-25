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
    public partial class frm_nova_bolest : Form
    {
        public frm_nova_bolest()
        {
            InitializeComponent();
        }

        private void frm_nova_bolest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Bolest' table. You can move, or remove it, as needed.
            this.bolestTableAdapter.Fill(this.lijecnikDataSet.Bolest);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Posjeta' table. You can move, or remove it, as needed.
            this.posjetaTableAdapter.Fill(this.lijecnikDataSet.Posjeta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definiranje varijabli upisa
            int ID_posjete = Convert.ToInt32(comboBox1.SelectedIndex) + 1;
            int ID_bolesti = Convert.ToInt32(comboBox2.SelectedIndex) + 1;
            //stvaranje i otvaranjen konekcije
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString);
            connection.Open();
            //upit kojim ubacujemo podatke ID_posjete i ID_bolesti u tablicu Posjeta_bolest
            string sql = "INSERT INTO Posjeta_bolest VALUES (@ID_posjete, @ID_bolesti)";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.Add("ID_posjete", ID_posjete);
            sqlCommand.Parameters.Add("ID_bolesti", ID_bolesti);
            sqlCommand.ExecuteNonQuery();
            //poruka 
            MessageBox.Show("Uspješno dodano!");
            this.Close();
        }
    }
}
