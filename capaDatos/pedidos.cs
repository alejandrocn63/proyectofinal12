//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace capaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedidos
    {
        public int id_pedido { get; set; }
        public string nombre_cliente { get; set; }
        public int id_alimento { get; set; }
        public int id_bebida { get; set; }
        public int id_metodo { get; set; }
        public bool para_llevar { get; set; }
    
        public virtual alimentos alimentos { get; set; }
        public virtual bebidas bebidas { get; set; }
        public virtual metodos_pago metodos_pago { get; set; }
    }
}