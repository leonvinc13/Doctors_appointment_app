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
    public partial class frm_posjete : Form
    {
        public frm_posjete()
        {
            InitializeComponent();
        }

        private void posjetaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Lijecnik' table. You can move, or remove it, as needed.
            this.lijecnikTableAdapter.Fill(this.lijecnikDataSet.Lijecnik);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Lijek' table. You can move, or remove it, as needed.
            this.lijekTableAdapter.Fill(this.lijecnikDataSet.Lijek);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Pacijent' table. You can move, or remove it, as needed.
            this.pacijentTableAdapter.Fill(this.lijecnikDataSet.Pacijent);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Posjeta' table. You can move, or remove it, as needed.
            this.posjetaTableAdapter.Fill(this.lijecnikDataSet.Posjeta);

        }

        private void fillByDatumToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.posjetaTableAdapter.FillByDatum(this.lijecnikDataSet.Posjeta, datum_posjeteToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definiranje varijable Datum_posjete iz dateTimePicker-a
            DateTime Datum_posjete = dateTimePicker1.Value;
            //popunjava tablicu podacima iz tablice posjeta s kriterijem za samo odabrani datum
            posjetaTableAdapter.FillByDatum(lijecnikDataSet.Posjeta, Datum_posjete.ToString());
        }
    }
}
