using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Ocampo_Eliana
{
    public class ClienteXProducto
    {
        public int IdProducto { get; set; }
        public int DNICliente { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaRetiro { get; set; }
    }
}
