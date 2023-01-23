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
    public partial class FrmDisciplina : Form
    {
        public FrmDisciplina()
        {
            InitializeComponent();
        }

        private void FrmDisciplina_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(5);

            guna2DataGridView1.Rows[0].Cells[0].Value = "Lingua Portuguesa";
            guna2DataGridView1.Rows[0].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[0].Cells[2].Value = "Apagar";

            guna2DataGridView1.Rows[1].Cells[0].Value = "Matematia";
            guna2DataGridView1.Rows[1].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[1].Cells[2].Value = "Apagar";

            guna2DataGridView1.Rows[2].Cells[0].Value = "Fisica";
            guna2DataGridView1.Rows[2].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[2].Cells[2].Value = "Apagar";

            guna2DataGridView1.Rows[3].Cells[0].Value = "Quimica";
            guna2DataGridView1.Rows[3].Cells[1].Value = "Editar";
            guna2DataGridView1.Rows[3].Cells[2].Value = "Apagar";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmDisciplinaCadastro frmDisciCadastro = new FrmDisciplinaCadastro();
            if (frmDisciCadastro.ShowDialog()== DialogResult.OK)
            {
                MessageBox.Show("reload datagridview");
            }
        }
    }
}
