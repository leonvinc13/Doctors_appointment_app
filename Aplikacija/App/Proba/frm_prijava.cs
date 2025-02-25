using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba
{
    public partial class frm_prijava : Form
    {
        public frm_prijava()
        {
            InitializeComponent();
        }

        public int ID_pacijenta;
        public int ID_lijecnika;
        int brojac = 0;
        int brojPokusaja = 3;

        private void button1_Click(object sender, EventArgs e)
        {
            //stvaranje novog objekta za uspostavu veze s bazom
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.lijecnikConnectionString); 
            string korisnicko = textBox1.Text;
            string lozinka = textBox2.Text;
            //otvaranje veze (konekcije)
            connection.Open();
            //upit 1
            string sql = "SELECT * FROM Lijecnik WHERE  Email=@email AND Lozinka=@lozinka";
            //upit 2
            string sql1 = "SELECT * FROM Pacijent WHERE  Email=@email AND Lozinka=@lozinka";
            //dodjeljivanje sql upita koji je definiran u varijabli sql/sql1
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlCommand sqlCommand1 = new SqlCommand(sql1, connection);
            //dodavanje parametara
            sqlCommand.Parameters.Add("email", korisnicko);
            sqlCommand.Parameters.Add("lozinka", lozinka);
            sqlCommand1.Parameters.Add("email", korisnicko);
            sqlCommand1.Parameters.Add("lozinka", lozinka);
            //izvršavanje upita 1
            SqlDataReader reader = sqlCommand.ExecuteReader();
            bool flag = false;
            //provjerava postoji li i jedan redak u rezultatu upita
            if (reader.Read())
            {
                ID_lijecnika = reader.GetInt32(0);
            }
            //ako ima redaka
            if (reader.HasRows)
            {
                //otvaranje nove forme (forme za liječnika)
                Form form = new frm_za_lijecnika(ID_lijecnika);
                form.Show();
                MessageBox.Show("Uspješna prijava", "Dobro došli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                //događaj za zatvaranje forme
                form.FormClosed += (s, args) => this.Close();
                flag = true; //postavlja flag na true
            }
            //zatvaranje objekta
            reader.Close();

            //izvršavanje upita 2
            SqlDataReader reader1 = sqlCommand1.ExecuteReader();
            //provjerava postoji li i jedan redak u rezultatu upita
            if (reader1.Read())
            {
                ID_pacijenta = reader1.GetInt32(0);
            }
            //ako ima redaka
            if (reader1.HasRows)
            {
                //otvaranje nove forme (forme za pacijenta)
                Form form = new frm_za_pacijenta(ID_pacijenta);
                form.Show();
                MessageBox.Show("Uspješna prijava", "Dobro došli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                form.FormClosed += (s, args) => this.Close();
                flag = true;
            }
            reader1.Close();

            //provjeravanje vrijednosti varijable flag
            if (!flag)
            {
                //ako je flag false (neuspješna prijava)
                brojac++;
                brojPokusaja--;
                if (brojac == 3)
                {
                    brojac = 0;
                    brojPokusaja = 3;
                    MessageBox.Show("Zaključavanje forme na 10 sekundi", "Neuspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Thread.Sleep(10000);
                }
                else
                {
                    MessageBox.Show("Pogrešni podaci! , imate još " + brojPokusaja + " pokušaja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
