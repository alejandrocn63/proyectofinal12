using modelodenegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinal12
{
    public partial class menu12 : Form
    {
        public menu12()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        public void abrirFor(object unform)
        {

            if (unform is Form fh)
            {

                if (this.Pantallaprincipal.Controls.Count > 0)
                    this.Pantallaprincipal.Controls.RemoveAt(0);

                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.Pantallaprincipal.Controls.Add(fh);
                this.Pantallaprincipal.Tag = fh;
                fh.Show();
            }
            else
            {

                MessageBox.Show("El parámetro proporcionado no es un formulario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btncomida_Click(object sender, EventArgs e)
        {
            abrirFor(new comida_1());
        }

        private void btnpago_Click(object sender, EventArgs e)
        {
            abrirFor(new bebidas());
        }
       

        private void btnmaximizar_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pantallaprincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
