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
    public partial class frm_baza_lijekova : Form
    {
        public frm_baza_lijekova()
        {
            InitializeComponent();
        }

        private void lijekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lijekBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }

        private void frm_baza_lijekova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Lijek' table. You can move, or remove it, as needed.
            this.lijekTableAdapter.Fill(this.lijecnikDataSet.Lijek);

        }

        private void fillByNazivToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lijekTableAdapter.FillByNaziv(this.lijecnikDataSet.Lijek, naziv_lijekaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definiranje varijable naziv lijeka onu koju smo upisali
            string Naziv_lijeka = textBox1.Text;
            //popunjava tablicu podacima iz tablice lijek, ali samo one koje imaju taj naziv koji smo upisali
            lijekTableAdapter.FillByNaziv(lijecnikDataSet.Lijek, Naziv_lijeka);
        }
    }
}
