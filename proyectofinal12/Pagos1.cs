using capa_de_datos;
using Guna.UI2.WinForms;
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
    public partial class Pagos1 : Form
    {
        private ProductoNegocio productoNegocio;
        

        public Pagos1(ProductoNegocio negocio)
        {
            InitializeComponent();
            productoNegocio = negocio;
            CargarDatosEnDataGridView();

        }
       
        private void CargarDatosEnDataGridView()
        {
            // Limpiar el DataGridView
            panta.Rows.Clear();

            // Agregar columnas si es necesario
            if (panta.Columns.Count == 0)
            {
                panta.Columns.Add("Producto", "Producto");
                panta.Columns.Add("Cantidad", "Cantidad");
            }

            // Llenar el DataGridView con los productos validados
            foreach (var producto in productoNegocio.ObtenerProductos())
            {
                panta.Rows.Add(producto.Item1, producto.Item2);
            }
        }

        private void Pagos1_Load(object sender, EventArgs e)
        {
            
        }
        

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncomfirmar_Click(object sender, EventArgs e)
        {
           
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }

        private void bttipodepedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btmetododepago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pagos1_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'menu13DataSet1.opciones_para_llevar' Puede moverla o quitarla según sea necesario.
            this.opciones_para_llevarTableAdapter.Fill(this.menu13DataSet1.opciones_para_llevar);
            // TODO: esta línea de código carga datos en la tabla 'menu13DataSet.metodos_pago' Puede moverla o quitarla según sea necesario.
            this.metodos_pagoTableAdapter.Fill(this.menu13DataSet.metodos_pago);

        }
    }
}
