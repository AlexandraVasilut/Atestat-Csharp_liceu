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
    public partial class Lista_clientilor : Form
    {
        public Lista_clientilor()
        {
            InitializeComponent();
        }

        private void iesireF3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cartiDataSet);

        }

        private void Lista_clientilor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cartiDataSet.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.cartiDataSet.Clienti);

        }
    }
}
