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
    public partial class frm_lijecnici : Form
    {
        public frm_lijecnici()
        {
            InitializeComponent();
        }

        private void pacijentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lijecnikDataSet.Specijalizacija' table. You can move, or remove it, as needed.
            this.specijalizacijaTableAdapter.Fill(this.lijecnikDataSet.Specijalizacija);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Lijecnik' table. You can move, or remove it, as needed.
            this.lijecnikTableAdapter.Fill(this.lijecnikDataSet.Lijecnik);
            // TODO: This line of code loads data into the 'lijecnikDataSet.Lijecnik' table. You can move, or remove it, as needed.
            this.lijecnikTableAdapter.Fill(this.lijecnikDataSet.Lijecnik);
        }

        private void lijecnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lijecnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);
        }

        private void lijecnikBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lijecnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lijecnikDataSet);

        }
    }
}
