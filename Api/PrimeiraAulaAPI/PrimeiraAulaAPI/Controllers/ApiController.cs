using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimeiraAulaAPI.DataModel;

namespace PrimeiraAulaAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        #region aulaDeOntem
        //[HttpGet("nome")]
        //public string RetornaNome()
        //{
        //    return "Isaias Jb";
        //}

        //[HttpGet("idade")]
        //public int RetornaIdade()
        //{
        //    return 0;
        //}

        //[HttpPut("nome/{nome}")]
        //public string Nome([FromRoute] string nome)
        //{
        //    return nome;
        //}

        //[HttpPut("nome/{nome}/idade/{idade}")]
        //public string NomeIdade([FromRoute] string nome, [FromRoute]int idade)
        // => idade > 18 ? $"{nome} é maior de idade" : $"{nome} tem {idade}";
        #endregion

        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> getAllAsync([FromServices] Context contexto)
        {
            var pessoas = await contexto.Pessoas.AsNoTracking() // não rastreia apenas trás um copia do bd melhro desempenho, remocenda-se seu uso apenas em consultas
                .ToListAsync();

            return pessoas == null ? NotFound() : Ok(pessoas);
        }

        [HttpGet]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> getAllAsync([FromServices] Context contexto, [FromRoute] int id)
        {
            var pessoas = await contexto.Pessoas.AsNoTracking() // não rastreia apenas trás um copia do bd melhro desempenho, remocenda-se seu uso apenas em consultas
                .FirstOrDefaultAsync(p => p.Id == id);

            return pessoas == null ? NotFound() : Ok(pessoas);
        }

        [HttpPost]
        [Route("pessoas")]
        public async Task<IActionResult> PostAsync(
            [FromServices] Context contexto,
            [FromBody] Pessoa pessoa
            )
        {
            try
            {
                await contexto.Pessoas.AddAsync(pessoa);
                await contexto.SaveChangesAsync();
                return Created($"api/pessoas/{pessoa.Id}", pessoa);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] Context contexto, [FromBody] Pessoa pessoa, [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model Inválida");

            var p = await contexto.Pessoas.FirstOrDefaultAsync(x => x.Id == id);

            if (p is null)
                return NotFound("Pessoa não encontrada");
    

            try
            {
                p.Nome = pessoa.Nome;

                contexto.Pessoas.Update(p);
                await contexto.SaveChangesAsync();
                return Ok(p);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> DeleteAsync(
             [FromServices] Context contexto, [FromRoute] int id)
        {
            var p = await contexto.Pessoas.FirstOrDefaultAsync(x => x.Id==id);

            if (p is null)
                return BadRequest("Pessoa não encontrada");


            try
            {
                contexto.Pessoas.Remove(p);
                await contexto.SaveChangesAsync();
                return Ok(p);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
            


        
    }

 
}