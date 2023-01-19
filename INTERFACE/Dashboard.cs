using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void resetButtonMenu(Guna.UI2.WinForms.Guna2Button btn = null)
        {

            btnAdemica.Checked = false;
            btnAdmin.Checked = false;
            btnCurso.Checked = false;
            btnDashboard.Checked = false;
            btnFormacao.Checked = false;
            btnTurma.Checked = false;
            btnRelatorio.Checked = false;
            btnAdemica.Checked = false;

            guna2Button4.Checked = false;

            guna2Button11.Checked = false;
            guna2Button12.Checked = false;
            guna2Button14.Checked = false;
            guna2Button15.Checked = false;
            
            guna2Button16.Checked = false;

            guna2Button19.Checked = false;
             guna2Button20.Checked = false;
            guna2Button8.Checked = false;
            guna2Button9.Checked = false;
            


        }
        public void hideSubMenu()
        {
            submenuAcademinc.Visible = false;
            subMenuAdmin.Visible = false;
            submenuRelatorio.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (!btnDashboard.Checked)
            {
                resetButtonMenu();
                hideSubMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

                    /*
                Form2 from = new Form2();
                from.TopLevel = false;
                from.Dock = DockStyle.Fill;
                from.FormBorderStyle = FormBorderStyle.None;
                conteiner.Controls.Add(from);
                conteiner.Tag = from;
                from.BringToFront();
                from.Show();*/
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
            
            if (!btnAdemica.Checked)
            {
                 resetButtonMenu();
                if (submenuAcademinc.Visible == false)
                {
                  
                    hideSubMenu();
                    (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                    showSubmenu(submenuAcademinc);
                }
                else
                {
                    MessageBox.Show("");
                    hideSubMenu();
                }
            
            
            }
            else
            {
                hideSubMenu();
                resetButtonMenu();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!btnFormacao.Checked)
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
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
            resetButtonMenu();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            resetButtonMenu();(sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void guna2Button9_Click_1(object sender, EventArgs e)
        {
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
             
                /*
                Form2 from = new Form2();
                from.TopLevel = false;
                from.Dock = DockStyle.Fill;
                from.FormBorderStyle = FormBorderStyle.None;
             //   conteiner.Controls.Add(from);
                conteiner.Tag = from;
                from.BringToFront();
                // from.Show();*/

                if (!btnAdmin.Checked)
                {
                    resetButtonMenu();
                    if (subMenuAdmin.Visible == false)
                    {

                        hideSubMenu();
                        (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                        showSubmenu(subMenuAdmin);
                    }
                    else
                    {
                        hideSubMenu();
                    }


                }
                else
                {
                    hideSubMenu();
                    resetButtonMenu();
                }
            }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
          //  conta.Visible = !conta.Visible;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (!guna2Button4.Checked)
            {
                resetButtonMenu();
                hideSubMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

                /*
            Form2 from = new Form2();
            from.TopLevel = false;
            from.Dock = DockStyle.Fill;
            from.FormBorderStyle = FormBorderStyle.None;
            conteiner.Controls.Add(from);
            conteiner.Tag = from;
            from.BringToFront();
            from.Show();*/
            }

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            if (!guna2Button14.Checked)
            {
                resetButtonMenu();
                hideSubMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

                /*
            Form2 from = new Form2();
            from.TopLevel = false;
            from.Dock = DockStyle.Fill;
            from.FormBorderStyle = FormBorderStyle.None;
            conteiner.Controls.Add(from);
            conteiner.Tag = from;
            from.BringToFront();
            from.Show();*/
            }
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            if (!guna2Button15.Checked)
            {
                resetButtonMenu();
                hideSubMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

                /*
            Form2 from = new Form2();
            from.TopLevel = false;
            from.Dock = DockStyle.Fill;
            from.FormBorderStyle = FormBorderStyle.None;
            conteiner.Controls.Add(from);
            conteiner.Tag = from;
            from.BringToFront();
            from.Show();*/
            }
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            if (!guna2Button16.Checked)
            {
                resetButtonMenu();
                hideSubMenu();
                (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;

                /*
            Form2 from = new Form2();
            from.TopLevel = false;
            from.Dock = DockStyle.Fill;
            from.FormBorderStyle = FormBorderStyle.None;
            conteiner.Controls.Add(from);
            conteiner.Tag = from;
            from.BringToFront();
            from.Show();*/
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

            if (!btnRelatorio.Checked)
            {
                resetButtonMenu();
                if (submenuAcademinc.Visible == false)
                {

                    hideSubMenu();
                    (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
                    showSubmenu(submenuRelatorio);
                }
                else
                {
                    hideSubMenu();
                }


            }
            else
            {
                hideSubMenu();
                resetButtonMenu();
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTop_DoubleClick(object sender, EventArgs e)
        {
            
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pnlTop_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void pnlTop_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void guna2Button12_Click_2(object sender, EventArgs e)
        {
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            resetButtonMenu();
            (sender as Guna.UI2.WinForms.Guna2Button).Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
            if (guna2ShadowPanel1.Width > 0)
            {
                guna2ShadowPanel1.Width = 0;
            }
            else
            {
                guna2ShadowPanel1.Width = 323;
            }
        }
    }
}
