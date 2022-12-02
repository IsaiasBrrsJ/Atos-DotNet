using APIExercicio.DataModels;
using APIExercicio.DTO;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace APIExercicio.Controllers
{
    
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        [Route("Alunos")]
        public async Task<IActionResult> GetlAllAsync([FromServices] Context context)
        {
            try
            {
                var aluno = await context.Alunos.Include(m => m.Matriculas).Include(c => c.Cursos).AsNoTracking().ToListAsync();

                if (aluno == null) { return NotFound("Não encotrado alunos"); }


                return Ok(aluno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("Aluno/{alunoId}")]
        public async Task<IActionResult> GetAsync([FromServices] Context context, [FromRoute] int alunoId)
        {
            try
            {
                var user = await context.Alunos
                           .Where(p => p.Id == alunoId)
                           .Include(m => m.Matriculas)
                           .Include(c => c.Cursos)
                           .AsNoTracking().ToListAsync();

                if (user == null) { return NotFound(); }


                return Ok(user);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
         }
        [HttpGet]
        [Route("Cursos")]
        public async Task<IActionResult> GelAllAsyncCursos([FromServices] Context context)
        {
            var cursos = await context.Cursos.ToListAsync();

            if(cursos == null) { return BadRequest(); }


            return Ok(cursos);
        }

        [HttpPost]
        [Route("AdcionarAluno")]
        public async Task<IActionResult> PostAluno([FromServices] Context context, [FromBody] AlunoDTO requestA)
        {

            try
            {

                var aluno = new Aluno
                {
                    Cpf = requestA.Cpf,
                    Nome = requestA.Nome,
                    Email = requestA.Email,
                    Telefone = requestA.Telefone,
                };

                await context.AddAsync(aluno);
                await context.SaveChangesAsync();


                return Ok(aluno);
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpPost]
        [Route("AdcionarCurso")]
        public async Task<IActionResult> PostCurso([FromServices] Context context, [FromBody] CadastrarCursoDTO request)
        {
            try
            {
                var curso = new Curso
                {
                    NomeCurso = request.NomeCurso,
                    Turno = request.Turno,
                    CargaHoraria = request.CargaHoraria,
                };

                await context.AddAsync(curso);
                await context.SaveChangesAsync();


                return Ok(curso);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("AlunoCurso")]
        public async Task<IActionResult> PostCurso([FromServices] Context context, [FromBody] VincularAlunoAoCursoDTO request)
        {
            try
            {
                var aluno = await context.Alunos
                    .Where(p => p.Id == request.AlunoId)
                    .Include(c => c.Cursos).FirstOrDefaultAsync();

                if(aluno == null) { return NotFound("Aluno não encontrado"); }


                var curso = await context.Cursos.FindAsync(request.CursoId);
                
                if(curso== null) { return NotFound("Curso não encontrado"); }


               aluno.Cursos.Add(curso);

                await context.SaveChangesAsync();

                var matricula = new Matricula
                {
                    Ra = new Random().Next(0, 40) + $"{aluno.Cpf[new Random().Next(1, 5)]}",
                    AlunoId = request.AlunoId
                };

                await context.AddAsync(matricula);
                await context.SaveChangesAsync();

                return Ok(aluno);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("AtualizarAluno/{id}")]
        
        public async Task<IActionResult> PutAluno([FromServices] Context context,[FromBody] AlunoDTO request, [FromRoute] int id)
        {
            try
            {
                var aluno = await context.Alunos.Where(p => p.Id == id).FirstOrDefaultAsync();

                if (aluno == null) { return BadRequest(); }

                aluno.Nome = request.Nome;
                aluno.Email = request.Email;
                aluno.Telefone = request.Telefone;
                aluno.Cpf = request.Cpf;


                context.Alunos.Update(aluno);
                await context.SaveChangesAsync();

                return Ok(aluno);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("AtualizarCurso/{id}")]
        public async Task<IActionResult> PutCurso([FromServices] Context context, [FromBody] CadastrarCursoDTO request, [FromRoute] int id)
        {
            try
            {
                var curso = await context.Cursos.Where(c => c.Id == id).FirstOrDefaultAsync();

                if (curso != null) { BadRequest(); }


                curso.NomeCurso = request.NomeCurso;
                curso.CargaHoraria = request.CargaHoraria;
                curso.Turno = request.Turno;


                context.Cursos.Update(curso);
                await context.SaveChangesAsync();

                return Ok(curso);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("DeleteAluno/{id}")]
        public async Task<IActionResult> RemoveAluno([FromServices] Context context, [FromRoute] int id)
        {
            try
            {
                var aluno = await context.Alunos
                            .Where(p => p.Id == id)
                            .Include(p => p.Matriculas)
                            .Include(p => p.Cursos)
                            .FirstOrDefaultAsync();


                if (aluno == null) { return NotFound(); }


                context.Alunos.Remove(aluno);

                await context.SaveChangesAsync();


                return Ok("Removido com sucesso");
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
