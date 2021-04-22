using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Detalle
    {

        public int CodPedido { get; set; }
        public string Descripcion { get; set; }
        public string Cantidad { get; set; }
        public string Precio { get; set; }
        public float TotalLinea { get; set; }
        public Cabecera Cabecera { get; set; }

    }
}
