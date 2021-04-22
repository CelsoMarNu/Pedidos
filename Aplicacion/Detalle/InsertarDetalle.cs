using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistencia;
using Dominio;

namespace Aplicacion
{
    public class InsertarDetalle
    {
        public class Ejecuta : IRequest
        {
            public int CodPedido { get; set; }
            public string Descripcion { get; set; }
            public string Cantidad { get; set; }
            public string Precio { get; set; }
            public float TotalLinea { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly Conexion _context;
            public Manejador(Conexion context)
            {

            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var Detalle = new Detalle
                {
                    CodPedido = request.CodPedido,                  
                    Descripcion = request.Descripcion,
                    Cantidad = request.Cantidad,
                    Precio = request.Precio,
                    TotalLinea = request.TotalLinea
                };

                _context.Detalle.Add(Detalle);
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
