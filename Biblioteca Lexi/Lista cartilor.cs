using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Lexi
{
    public partial class Lista_cartilor : Form
    {
        public Lista_cartilor()
        {
            InitializeComponent();
        }

        private void iesireF2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cartiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cartiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cartiDataSet);

        }

        private void Lista_cartilor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cartiDataSet.Carti' table. You can move, or remove it, as needed.
            this.cartiTableAdapter.Fill(this.cartiDataSet.Carti);

        }

        private void edituraLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
