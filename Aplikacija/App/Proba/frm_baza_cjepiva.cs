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
    public partial class frm_baza_cjepiva : Form
    {
        public frm_baza_cjepiva()
        {
            InitializeComponent();
        }

        private void cjepivoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cjepivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }

        private void frm_baza_cjepiva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Cjepivo' table. You can move, or remove it, as needed.
            this.cjepivoTableAdapter.Fill(this.lijecnikDataSet.Cjepivo);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Cjepivo' table. You can move, or remove it, as needed.
            this.cjepivoTableAdapter.Fill(this.lijecnikDataSet.Cjepivo);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Cjepivo' table. You can move, or remove it, as needed.
            this.cjepivoTableAdapter.Fill(this.lijecnikDataSet.Cjepivo);

        }

        private void cjepivoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cjepivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }

        private void cjepivoBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.cjepivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }
    }
}
