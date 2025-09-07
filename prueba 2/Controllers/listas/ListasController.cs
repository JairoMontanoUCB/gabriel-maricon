using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prueba_2.Modells;

namespace prueba_2.Controllers.listas
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListasController : ControllerBase
    {
        #region Listas
        [HttpGet("generica")]
        public IActionResult ListaGenerica()
        {
            var personas = new List<persona>()
            {
                new persona { Id = 1, Nombre = "Juan", Edad = 20 },
                new persona { Id = 2, Nombre = "Maria", Edad = 40 }
            };

            return Ok(personas);
        }
        #endregion
    }
}
