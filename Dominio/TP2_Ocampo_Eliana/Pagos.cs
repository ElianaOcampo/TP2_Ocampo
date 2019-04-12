using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Ocampo_Eliana
{
    public class Pagos
    {
        public int DNICliente { get; set; }
        public DateTime Fecha { get; set; }
        public float Costo { get; set; }
        public int IdProducto { get; set; }
        public List<Producto> listadoProductos = new List<Producto>();
    }
}
