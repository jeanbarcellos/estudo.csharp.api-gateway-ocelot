using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Catalogo.API.Controllers
{
    [ApiController]
    [Route("api/catalogo")]
    public class CatalogoController
    {
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Produto 1", "Produto 2" };
        }
    }
}
