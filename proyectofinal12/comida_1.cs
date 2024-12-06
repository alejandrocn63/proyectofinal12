using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using modelodenegocios;
using TheArtOfDevHtmlRenderer.Adapters;


namespace proyectofinal12
{
    public partial class comida_1 : Form
    {
        private ProductoNegocio productoNegocio;
        private menu12 menu1;
        private HashSet<string> productosAgregados;

        public comida_1()
        {
            InitializeComponent();
            productoNegocio = new ProductoNegocio();
            menu1 = new menu12();
            productosAgregados = new HashSet<string>();

            var productos = new Dictionary<string, MaskedTextBox>
        {
            { "Hamburguesa", mthamburguesa },
            { "Pizza", mtpizza },
            { "Hot Dogs", mthotdogs },
            { "Tacos", mttacos },
            { "Sandwich", mtsandwisch },
            { "Picapollo", mtpicapollo }
        };

            foreach (var producto in productos)
            {
                producto.Value.Visible = false;
            }

            btnAgregarProducto.Click += btnAgregarProducto_Click;
        }

        private void ValidarCantidad(MaskedTextBox maskTextBox, string producto)
        {
            if (!int.TryParse(maskTextBox.Text, out int cantidad))
            {
                
                return;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var productos = new Dictionary<string, MaskedTextBox>
            {
             { "Hamburguesa", mthamburguesa },
             { "Pizza", mtpizza },
             { "Hot Dogs", mthotdogs },
             { "Tacos", mttacos },
             { "Sandwich", mtsandwisch },
             { "Picapollo", mtpicapollo }
            };

            foreach (var producto in productos)
            {
                if (producto.Value.Visible && !string.IsNullOrWhiteSpace(producto.Value.Text))
                {
                    // Validar la cantidad sin mostrar mensajes
                    ValidarCantidad(producto.Value, producto.Key);

                    // Solo proceder si el producto no ha sido agregado
                    if (!productosAgregados.Contains(producto.Key))
                    {
                        // Aquí puedes agregar la lógica para validar el producto
                        string mensaje = productoNegocio.ValidarProducto(producto.Key, int.Parse(producto.Value.Text));
                        MessageBox.Show(mensaje, "Información"); // Mensaje de agregado
                        productosAgregados.Add(producto.Key); // Marcar como agregado
                    }
                    
                }
            }
        }

        // Los métodos de evento para los botones de los productos
        private void btnhamburguesa_Click(object sender, EventArgs e) => MostrarMaskedTextBox(mthamburguesa);
        private void btnpizza_Click(object sender, EventArgs e) => MostrarMaskedTextBox(mtpizza);
        private void btnHotdogs_Click(object sender, EventArgs e) => MostrarMaskedTextBox(mthotdogs);
        private void btntacos_Click(object sender, EventArgs e) => MostrarMaskedTextBox(mttacos);
        private void btnsandwich_Click_1(object sender, EventArgs e) => MostrarMaskedTextBox(mtsandwisch);
        private void btnPicapollo_Click(object sender, EventArgs e) => MostrarMaskedTextBox(mtpicapollo);

        private void MostrarMaskedTextBox(MaskedTextBox maskTextBox)
        {
            maskTextBox.Visible = true;
            maskTextBox.Focus();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            if (productoNegocio.HayProductos())
            {
                foreach (var producto in productoNegocio.ObtenerProductos())
                {
                    Console.WriteLine($"Producto: {producto.Item1}, Cantidad: {producto.Item2}");
                }
                Pagos1 pagos00 = new Pagos1(productoNegocio);
                pagos00.Show();
            }
            else
            {
                MessageBox.Show("No hay productos agregados. Por favor, valida las cantidades antes de continuar.");
            }
        }
    }
}
