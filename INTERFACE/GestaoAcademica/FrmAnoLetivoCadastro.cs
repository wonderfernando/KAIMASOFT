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
    public partial class FrmAnoLetivoCadastro : Form
    {
        public FrmAnoLetivoCadastro()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmCursoCadastrar frmCurso = new FrmCursoCadastrar();
            frmCurso.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
