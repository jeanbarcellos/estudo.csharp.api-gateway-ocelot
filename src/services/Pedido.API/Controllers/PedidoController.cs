using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Pedido.API.Controllers
{
    [ApiController]
    [Route("api/pedido")]
    public class PedidoController
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Pedido 1", "Pedido 2" };
        }
    }
}
