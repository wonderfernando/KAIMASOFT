using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFACE
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(guna2Button12.Checked.ToString());
        }

        private void menuclick(object sender, EventArgs e)
        {
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

            submenu.Visible = true;

            Form2 from = new Form2();
            from.TopLevel = false;
            from.Dock = DockStyle.Fill;
            from.FormBorderStyle = FormBorderStyle.None;
            conteiner.Controls.Add(from);
            conteiner.Tag = from;
            from.BringToFront();
            from.Show();
            
        }
        public void resetButtonMenu()
        {
            guna2Button1.Checked = false;
            guna2Button12.Checked = false;
            guna2Button3.Checked = false;
            guna2Button2.Checked = false;
        } 
    }
}
