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
            
        }

        private void menuclick(object sender, EventArgs e)
        {

        }

        public void resetButtonMenu()
        {
           /* guna2Button1.Checked = false;
            guna2Button12.Checked = false;
            guna2Button3.Checked = false;
            guna2Button2.Checked = false;
            guna2Button9.Checked = false;
            guna2Button6.Checked = false;
            guna2Button7.Checked = false;*/
        }
        public void hideSubMenu()
        {
            submenuAdmin.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (!guna2Button2.Checked)
            {
                resetButtonMenu();
                hideSubMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

                Form2 from = new Form2();
                from.TopLevel = false;
                from.Dock = DockStyle.Fill;
                from.FormBorderStyle = FormBorderStyle.None;
                conteiner.Controls.Add(from);
                conteiner.Tag = from;
                from.BringToFront();
                from.Show();
            }
            else
            {
                resetButtonMenu();
            }
            
        }

        private void guna2Button12_Click_1(object sender, EventArgs e)
        {
            /*
            if (!guna2Button12.Checked)
            {
                resetButtonMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                submenu.Visible = true;
                Form2 from = new Form2();
                from.TopLevel = false;
                from.Dock = DockStyle.Fill;
                from.FormBorderStyle = FormBorderStyle.None;
               // conteiner.Controls.Add(from);
                conteiner.Tag = from;
                from.BringToFront();
                //from.Show();
            }
            else
            {
                hideMenu();
                guna2Button12.Checked = false;
            }*/
              
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        { 
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            /*
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
            from.Show();*/
        }
        public void showSubmenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                submenu.Visible = true;
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!guna2Button1.Checked)
            {
                resetButtonMenu();
                hideSubMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                showSubmenu(submenuAdmin);
                /*
                Form2 from = new Form2();
                from.TopLevel = false;
                from.Dock = DockStyle.Fill;
                from.FormBorderStyle = FormBorderStyle.None;
             //   conteiner.Controls.Add(from);
                conteiner.Tag = from;
                from.BringToFront();
                // from.Show();*/
            }
            else
            {
                resetButtonMenu();
                hideSubMenu();
                guna2Button1.Checked = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!guna2Button2.Checked)
            {
                resetButtonMenu();
                hideSubMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

                Form2 from = new Form2();
                from.TopLevel = false;
                from.Dock = DockStyle.Fill;
                from.FormBorderStyle = FormBorderStyle.None;
                //   conteiner.Controls.Add(from);
                conteiner.Tag = from;
                from.BringToFront();
                // from.Show();
            }
        }

        private void conteiner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void guna2Button9_Click_1(object sender, EventArgs e)
        {
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
