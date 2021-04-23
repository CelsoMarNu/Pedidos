using Microsoft.AspNetCore.Mvc;
using MediatR;
using Aplicacion;
using System;
using System.Threading.Tasks;

namespace Pedidos.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]

    public class CabeceraController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CabeceraController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost]
        public async Task<ActionResult<Unit>> Insertar(InsertarCabecera.Ejecuta data)
        {
            return await _mediator.Send(data);
        }
    }

}
