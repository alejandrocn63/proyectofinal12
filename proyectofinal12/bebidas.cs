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
    public partial class bebidas : Form
    {
        public bebidas()
        {
            InitializeComponent();
        }

        // Botones de productos
        private void btnrefrescos_Click(object sender, EventArgs e)
        {
            mtrefrescos.Visible = true;
            mtrefrescos.Focus();
        }

        private void btnbebidas_Click(object sender, EventArgs e)
        {
            mtbatido.Visible = true;
            mtbatido.Focus();
        }

        private void btntefrio_Click(object sender, EventArgs e)
        {
            mttefrio.Visible = true;
            mttefrio.Focus();
        }

        private void btnjugos_Click(object sender, EventArgs e)
        {
            mtjugos.Visible = true;
            mtjugos.Focus();
        }

        private void btncerveza_Click(object sender, EventArgs e)
        {
            mtcerveza.Visible = true;
            mtcerveza.Focus();
        }

        private void btnagua_Click(object sender, EventArgs e)
        {
            mtagua.Visible = true;
            mtagua.Focus();
        }

        // Métodos de validación
        private void ValidarCantidad(MaskedTextBox maskTextBox, string producto)
        {
            if (!int.TryParse(maskTextBox.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show($"Por favor, ingresa una cantidad válida para {producto}.");
                maskTextBox.Focus();
            }
        }

        // Métodos de validación de los MaskedTextBox
        private void mtrefrescos_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ValidarCantidad(mtrefrescos, "Refrescos");
        }

        private void mtbatido_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ValidarCantidad(mtbatido, "Batidos");
        }

        private void mttefrio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ValidarCantidad(mttefrio, "Té Frío");
        }

        private void mtjugos_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ValidarCantidad(mtjugos, "Jugos");
        }

        private void mtcerveza_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ValidarCantidad(mtcerveza, "Cerveza");
        }

        private void mtagua_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ValidarCantidad(mtagua, "Agua");
        }

    }
}
