using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace prueba_2.Controllers.basico
{
    [Route("api/[controller]")]
    [ApiController]
    public class basicoController : ControllerBase
    {
        #region HolaMundo
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("hola mundo!");
        }
        #endregion
        #region saludar
        [HttpGet("{resp}")]
        public IActionResult Get(string resp)
        {
            return Ok($"hola {resp}");
        }
        #endregion
        #region suma
        [HttpGet("sumar/{a}/{b}")]
        public IActionResult Sumar(int a, int b)
        {
            int resultado = a + b;
            return Ok($"La suma de {a}+{b} es {resultado}");

        }

        #endregion

        #region ParImpar
        [HttpGet("par-impar/{numero}")]
        public IActionResult VerificarParImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                return Ok($"El numero es par");
            }
            else
            {
                return Ok($"El numero es impar");
            }



        }

        #endregion
        #region Tamanio
        /*[HttpGet("tamanio/{numero}")]
        public IActionResult mostrartamanio(int numero)
        {
            Ok(int.MaxValue);

        }
        */
        #endregion
        #region Lista deFrutas
        private static readonly List<string> frutas = new()
        {
        "manzana",
        "banana",
        "fresa",
        "naranja",
        "adrian maricon"
        };
        [HttpGet("frutas")]
        public IActionResult ObtenerFrutas()
        {


            return Ok(frutas);

        }
        #endregion
        #region Lista Numeros
        private static readonly List<string> numeros = new()
        {
        "manzana",
        "banana",
        "fresa",
        "naranja",
        "adrian maricon"
        };
        [HttpGet("filtrarpares")]
        public IActionResult FiltrarPares(List<int> numeros)
        {
            List<int> pares = new();
            foreach(int num in numeros)
            {
                if(num % 2 == 0)
                {
                    pares.Add(num);
                }
            }

            return Ok(pares);

        }
        #endregion
    }
}
