using Microsoft.AspNetCore.Mvc;
using MediatR;
using Aplicacion;
using System;
using System.Threading.Tasks;

namespace Pedidos.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DetalleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost]
        public async Task<ActionResult<Unit>> Insertar(InsertarDetalle.Ejecuta data)
        {
            return await _mediator.Send(data);
        }
    }

}
