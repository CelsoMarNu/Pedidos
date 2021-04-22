using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Cabecera
    {
        public int CodPedido { get; set; }
        public int Codcliente { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Vendedor { get; set; }
        public string Moneda { get; set; }
        public float Total { get; set; }
        public ICollection<Detalle>Detalle { get; set; }
    }
}
