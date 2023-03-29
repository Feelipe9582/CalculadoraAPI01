using CalculadoraAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculadoraAPI.Controllers
{
    [ApiController]
    public class MultiplicacaoController : ControllerBase
    {
        [HttpPost]
        [Route("api/multiplicacao")]
        public ActionResult<MultiplicacaoResponse> Post([FromBody] MultiplicacaoRequest request)
        {
            if (!double.TryParse(request.Numero1, out double numero1) || !double.TryParse(request.Numero2, out double numero2))
            {
                return BadRequest("Os par�metros informados n�o s�o n�meros v�lidos");
            }

            double resultado = numero1 * numero2;

            return Ok(new MultiplicacaoResponse { Resultado = resultado.ToString() });
        }
    }

    [ApiController]
    public class MediaController : ControllerBase
    {
        [HttpPost]
        [Route("api/media")]
        public ActionResult<MediaResponse> Post([FromBody] MediaRequest request)
        {
            if (!double.TryParse(request.Numero1, out double numero1) || !double.TryParse(request.Numero2, out double numero2))
            {
                return BadRequest("Os par�metros informados n�o s�o n�meros v�lidos");
            }

            double resultado = (numero1 + numero2) / 2;

            return Ok(new MediaResponse { Resultado = resultado.ToString() });
        }
    }

    [ApiController]
    public class RaizQuadradaController : ControllerBase
    {
        [HttpPost]
        [Route("api/raizquadrada")]
        public ActionResult<RaizQuadradaResponse> Post([FromBody] RaizQuadradaRequest request)
        {
            if (!double.TryParse(request.Numero, out double numero) || numero < 0)
            {
                return BadRequest("O par�metro informado n�o � um n�mero positivo v�lido");
            }

            double resultado = Math.Sqrt(numero);

            return Ok(new RaizQuadradaResponse { Resultado = resultado.ToString() });
        }
    }
}
