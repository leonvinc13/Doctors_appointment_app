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
    public partial class frm_baza_bolesti : Form
    {
        public frm_baza_bolesti()
        {
            InitializeComponent();
        }

        private void bolestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bolestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }

        private void frm_baza_bolesti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Bolest' table. You can move, or remove it, as needed.
            this.bolestTableAdapter.Fill(this.lijecnikDataSet.Bolest);

        }

        private void fillByNazivToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bolestTableAdapter.FillByNaziv(this.lijecnikDataSet.Bolest, naziv_bolestiToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definiranje varijable naziv bolesti onu koju smo upisali
            string Naziv_bolesti = textBox1.Text;
            //popunjava tablicu podacima iz tablice bolest, ali samo one koje imaju taj naziv koji smo upisali
            bolestTableAdapter.FillByNaziv(lijecnikDataSet.Bolest, Naziv_bolesti);
        }
    }
}
