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
    public partial class FrmAreaFormacao : Form
    {
        public FrmAreaFormacao()
        {
            InitializeComponent();
        }

        private void FrmAreaFormacao_Load(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper scroll = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(guna2DataGridView1, guna2VScrollBar1, false);
            scroll.UpdateScrollBar();
            guna2DataGridView1.Rows.Add(7);
            guna2DataGridView1.Rows[0].Cells[0].Value = "Informatica";
            guna2DataGridView1.Rows[0].Cells[1].Value = "Area Tecnica";
            guna2DataGridView1.Rows[0].Cells[2].Value = "Editar";
            guna2DataGridView1.Rows[0].Cells[3].Value = "Deletar";

            guna2DataGridView1.Rows[1].Cells[0].Value = "Eletronica e Telecomunicacoes";
            guna2DataGridView1.Rows[1].Cells[1].Value = "Area Tecnica";
            guna2DataGridView1.Rows[1].Cells[2].Value = "Editar";
            guna2DataGridView1.Rows[1].Cells[3].Value = "Deletar";

            guna2DataGridView1.Rows[2].Cells[0].Value = "Mecatronica";
            guna2DataGridView1.Rows[2].Cells[1].Value = "Area Tecnica";
            guna2DataGridView1.Rows[2].Cells[2].Value = "Editar";
            guna2DataGridView1.Rows[2].Cells[3].Value = "Deletar";

            guna2DataGridView1.Rows[3].Cells[0].Value = "Enfermagem";
            guna2DataGridView1.Rows[3].Cells[1].Value = "Area Saude";
            guna2DataGridView1.Rows[3].Cells[2].Value = "Editar";
            guna2DataGridView1.Rows[3].Cells[3].Value = "Deletar";

            guna2DataGridView1.Rows[3].Cells[0].Value = "Enfermagem";
            guna2DataGridView1.Rows[3].Cells[1].Value = "Area Saude";
            guna2DataGridView1.Rows[3].Cells[2].Value = "Editar";
            guna2DataGridView1.Rows[3].Cells[3].Value = "Deletar";

            guna2DataGridView1.Rows[4].Cells[0].Value = "Enfermagem";
            guna2DataGridView1.Rows[4].Cells[1].Value = "Area Saude";
            guna2DataGridView1.Rows[4].Cells[2].Value = "Editar";
            guna2DataGridView1.Rows[4].Cells[3].Value = "Deletar";

            guna2DataGridView1.Rows[5].Cells[0].Value = "Enfermagem";
            guna2DataGridView1.Rows[5].Cells[1].Value = "Area Saude";
            guna2DataGridView1.Rows[5].Cells[2].Value = "Editar";
            guna2DataGridView1.Rows[5].Cells[3].Value = "Deletar";

            guna2DataGridView1.Rows[6].Cells[0].Value = "Enfermagem";
            guna2DataGridView1.Rows[6].Cells[1].Value = "Area Saude";
            guna2DataGridView1.Rows[6].Cells[2].Value = "Editar";
            guna2DataGridView1.Rows[6].Cells[3].Value = "Deletar";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new FrmAreaFormacaoCadastro().ShowDialog();
        }
    }
}
