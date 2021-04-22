using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistencia;
using Dominio;

namespace Aplicacion
{
    public class InsertarCabecera
    {
        public class Ejecuta : IRequest
        {
            public int CodPedido { get; set; }
            public int Codcliente { get; set; }
            public string Nombre { get; set; }
            public DateTime FechaPedido { get; set; }
            public DateTime FechaEntrega { get; set; }
            public string Vendedor { get; set; }
            public string Moneda { get; set; }
            public float Total { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly Conexion _context;
            public Manejador(Conexion context)
            {

            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var Cabecera = new Cabecera {
                    CodPedido = request.CodPedido,
                    Codcliente = request.Codcliente,
                    Nombre = request.Nombre,
                    FechaPedido = request.FechaPedido,
                    FechaEntrega = request.FechaEntrega,
                    Vendedor = request.Vendedor,
                    Moneda = request.Moneda,
                    Total = request.Total
                };

                _context.Cabecera.Add(Cabecera);
                var valor = await _context.SaveChangesAsync();
                if (valor > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("No se pudo insertar los datos");
            }
        }
    }
}
