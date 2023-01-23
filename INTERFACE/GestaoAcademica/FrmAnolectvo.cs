using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACE.GestaoAcademica
{
    public partial class FrmAnolectvo : Form
    {
        public FrmAnolectvo()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            FrmAnoLetivoCadastro frmAnoLetivoCadastro = new FrmAnoLetivoCadastro();
            if (frmAnoLetivoCadastro.ShowDialog()== DialogResult.OK)
            {
                MessageBox.Show("reload dataGridView");
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
