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
    public partial class frm_pacijent_sve : Form
    {
        public frm_pacijent_sve()
        {
            InitializeComponent();
        }

        private void pacijentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacijentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }

        private void frm_pacijent_sve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Lijek' table. You can move, or remove it, as needed.
            this.lijekTableAdapter.Fill(this.lijecnikDataSet.Lijek);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Bolest' table. You can move, or remove it, as needed.
            this.bolestTableAdapter.Fill(this.lijecnikDataSet.Bolest);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Lijecnik' table. You can move, or remove it, as needed.
            this.lijecnikTableAdapter.Fill(this.lijecnikDataSet.Lijecnik);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Posjeta_lijek' table. You can move, or remove it, as needed.
            this.posjeta_lijekTableAdapter.Fill(this.lijecnikDataSet.Posjeta_lijek);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Posjeta_bolest' table. You can move, or remove it, as needed.
            this.posjeta_bolestTableAdapter.Fill(this.lijecnikDataSet.Posjeta_bolest);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Posjeta' table. You can move, or remove it, as needed.
            this.posjetaTableAdapter.Fill(this.lijecnikDataSet.Posjeta);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Pacijent' table. You can move, or remove it, as needed.
            this.pacijentTableAdapter.Fill(this.lijecnikDataSet.Pacijent);

        }
    }
}
