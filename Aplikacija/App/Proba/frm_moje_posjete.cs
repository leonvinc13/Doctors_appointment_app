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
    public partial class frm_moje_posjete : Form
    {
        //konstruktor prima ID pacijenta kao argument i inicijalizira novu instancu forme frm_moje _posjete
        public frm_moje_posjete(int ID_pacijenta)
        {
            InitializeComponent();
            this.ID_pacijenta = ID_pacijenta;
        }

        //deklaracija javne varijable ID_pacijenta
        public int ID_pacijenta;

        //popunjava tablicu Posjeta podacima iz lijecnikDataSet.Posjeta i filtrira podatke prema ID_pacijenta
        private void frm_moje_posjete_Load(object sender, EventArgs e)
        {
            //popunjava podacima 'lijecnikDataSet.Lijecnik' tablicu
            this.lijecnikTableAdapter.Fill(this.lijecnikDataSet.Lijecnik);
            //popunjava podacima 'lijecnikDataSet.Pacijent' tablicu
            this.pacijentTableAdapter.Fill(this.lijecnikDataSet.Pacijent);
            this.posjetaTableAdapter.Fill(this.lijecnikDataSet.Posjeta);
            posjetaTableAdapter.FillByPosjeta(lijecnikDataSet.Posjeta, ID_pacijenta);
        }

        private void posjetaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.posjetaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);
        }

        private void fillByPosjetaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.posjetaTableAdapter.FillByPosjeta(this.lijecnikDataSet.Posjeta, new System.Nullable<int>(((int)(System.Convert.ChangeType(iD_pacijentaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
