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
    public partial class frm_moji_podaci : Form
    {
        //konstruktor prima ID pacijenta kao argument i inicijalizira novu instancu forme frm_moji_podaci
        public frm_moji_podaci(int ID_pacijenta)
        {
            InitializeComponent();
            this.ID_pacijenta = ID_pacijenta;
        }

       //deklaracija javne varijable ID_pacijenta
        public int ID_pacijenta;

        private void pacijentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacijentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }

        //popunjava tablicu Pacijent podacima iz lijecnikDataSet.Pacijent i filtrira podatke prema ID_pacijenta
        private void mojipodaci_Load(object sender, EventArgs e)
        {
            this.pacijentTableAdapter.Fill(this.lijecnikDataSet.Pacijent);
            pacijentTableAdapter.FillBy(lijecnikDataSet.Pacijent, ID_pacijenta);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacijentTableAdapter.FillBy(this.lijecnikDataSet.Pacijent, ((int)(System.Convert.ChangeType(iD_pacijentaToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
