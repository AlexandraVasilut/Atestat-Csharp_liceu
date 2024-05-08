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
    public partial class Imprumuturi : Form
    {
        public Imprumuturi()
        {
            InitializeComponent();
        }

        private void iesireF4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
