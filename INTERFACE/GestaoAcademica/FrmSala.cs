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
    public partial class FrmSala : Form
    {
        public FrmSala()
        {
            InitializeComponent();
        }

        private void FrmSala_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(4);
            guna2DataGridView1.Rows[0].Cells[0].Value = "Auditorio";
            guna2DataGridView1.Rows[0].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[0].Cells[2].Value = "Apagar";

            guna2DataGridView1.Rows[1].Cells[0].Value = "Sala 1";
            guna2DataGridView1.Rows[1].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[1].Cells[2].Value = "Apagar";

            guna2DataGridView1.Rows[2].Cells[0].Value = "Sala 2";
            guna2DataGridView1.Rows[2].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[2].Cells[2].Value = "Apagar";

            guna2DataGridView1.Rows[3].Cells[0].Value = "Sala 3";
            guna2DataGridView1.Rows[3].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[3].Cells[2].Value = "Apagar";




        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmSalaCadastro frm = new FrmSalaCadastro();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Reload datagridview");
            }
        }
    }
}
