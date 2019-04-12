using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Ocampo_Eliana
{
    public class Producto : Catalogo
    {
        public string Descripcion { get; set; }
        Marca marca;
        Ubicacion ubicacion;
    }
}
