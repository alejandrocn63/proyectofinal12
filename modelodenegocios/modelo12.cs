
using capa_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelodenegocios
{
    
    public class ProductoNegocio
    {
        private List<Tuple<string, int>> productosValidados;

        public ProductoNegocio()
        {
            productosValidados = new List<Tuple<string, int>>();
        }

        // Método para validar y agregar productos
        public string ValidarProducto(string producto, int cantidad)
        {
            if (cantidad > 0)
            {
                var existente = productosValidados.FirstOrDefault(p => p.Item1 == producto);
                if (existente != null)
                {
                    productosValidados.Remove(existente);
                }

                productosValidados.Add(new Tuple<string, int>(producto, cantidad));
                return $"Se agregó {cantidad} unidad(es) de {producto}.";
            }
            return $"Por favor, ingresa una cantidad válida para {producto}.";
        }

        // Método para obtener productos validados
        public List<Tuple<string, int>> ObtenerProductos()
        {
            return productosValidados;
        }

        // Método para verificar si hay productos
        public bool HayProductos()
        {
            return productosValidados.Any();
        }
    }
    public class BusinessLogic
    {
        private DataAccess dataAccess = new DataAccess();

        public void AgregarNombre(string nombre)
        {
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                dataAccess.InsertarNombre(nombre);
            }
            else
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }
        }
    }

}
