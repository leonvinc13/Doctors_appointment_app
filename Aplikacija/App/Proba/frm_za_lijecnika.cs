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
    public partial class frm_za_lijecnika : Form
    {
        public frm_za_lijecnika(int ID_lijecnika)
        {
            InitializeComponent();
            this.ID_lijecnika = ID_lijecnika;
        }

        public int ID_lijecnika;

        private void bolestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void lijecnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new frm_pacijenti();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new frm_posjete();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new frm_pacijenti();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new frm_posjete();
            form.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form form = new frm_prijava();
            form.Show();    
            //zatvaranje trenutne forme
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form form = new frm_statistika();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new frm_lijecnici();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form = new frm_lijecnicke_posjete(ID_lijecnika);
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form form = new frm_lijecnicki_lijekovi();
            form.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form form = new frm_lijecnicke_bolesti();
            form.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form form = new frm_lijecnicka_cijepljenja();
            form.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form form = new frm_baza_bolesti();
            form.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form form = new frm_baza_lijekova();
            form.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form form = new frm_baza_cjepiva();
            form.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form form = new frm_pacijent_sve();
            form.ShowDialog();
        }
    }
}
