using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba
{
    public partial class frm_za_pacijenta : Form
    {
        public frm_za_pacijenta(int ID_pacijenta)
        {
            InitializeComponent();
            this.ID_pacijenta = ID_pacijenta;
        }

        public int ID_pacijenta;

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new frm_moji_podaci(ID_pacijenta);
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new frm_moje_posjete(ID_pacijenta);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new frm_moje_bolesti(ID_pacijenta);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new frm_moji_lijekovi(ID_pacijenta);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new frm_moja_cijepljenja(ID_pacijenta);
            form.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form form = new frm_prijava();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }
    }
}
