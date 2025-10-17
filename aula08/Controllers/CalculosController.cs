using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aula08.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculosController : ControllerBase
    {
        [HttpGet("Somar/{num1}/{num2}")]

        public ActionResult Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            return Ok($"A soma de {num1} + {num2} = {resultado}");
        }

        [HttpGet("divisao/{num1}/{num2}")]

        public ActionResult dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            return Ok($"A divisão de {num1} / {num2} = {resultado}");
        }

        [HttpGet("Subtrair/{num1}/{num2}")]

        public ActionResult Subtração(int num1, int num2)
        {
            int resultado = num1 - num2;
            return Ok($"A subttração de {num1} - {num2} = {resultado}");
        }

        [HttpGet("multiplicar/{num1}/{num2}")]

        public ActionResult multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            return Ok($"A multiplicação de {num1}* {num2} = {resultado}");
        }
    }
}
