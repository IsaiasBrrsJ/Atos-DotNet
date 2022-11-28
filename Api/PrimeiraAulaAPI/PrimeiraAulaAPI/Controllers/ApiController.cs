using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAulaAPI.Controllers
{
    [ApiController]
    [Route("a")]
    public class ApiController : ControllerBase
    {
        [HttpGet("nome")]
        public string RetornaNome()
        {
            return "Isaias Jb";
        }

        [HttpGet("idade")]
        public int RetornaIdade()
        {
            return 0;
        }

        [HttpPut("nome/{nome}")]
        public string Nome([FromRoute] string nome)
        {
            return nome;
        }

        [HttpPut("nome/{nome}/idade/{idade}")]
        public string NomeIdade([FromRoute] string nome, [FromRoute]int idade)
         => idade > 18 ? $"{nome} é maior de idade" : $"{nome} tem {idade}";
        
    }
}