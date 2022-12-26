using Microsoft.AspNetCore.Mvc;
using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var tarefaBanco = _context.Tarefas.Find(id);

                if (tarefaBanco is null)
                    return NotFound();

                return Ok(tarefaBanco);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            try
            {
                var tarefasNoBanco = _context.Tarefas.ToList<Tarefa>();


                if (tarefasNoBanco is null)
                    return NotFound();

                return Ok(tarefasNoBanco);
            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {

            try
            {
                var obterPorTitulo = _context.Tarefas.Where(t => t.Titulo == titulo);

                if (obterPorTitulo is null)
                {
                    return NotFound(new { Erro = "Não Encontrado" });
                }

                return Ok(obterPorTitulo);

            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            try
            {
                var tarefa = _context.Tarefas.Where(x => x.Data.Date == data.Date);

                if (tarefa == null)
                {
                    return NotFound(new { Erro = "Tarefa não encontrada" });
                }
                return Ok(new { Data = tarefa });
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {

            var tarefa = _context.Tarefas.Where(x => x.Status == status);

            return Ok(tarefa);
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            try
            {
                if (tarefa.Data == DateTime.MinValue)
                    return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

                // TODO: Adicionar a tarefa recebida no EF e salvar as mudanças (save changes)
                _context.Tarefas.Add(tarefa);
                _context.SaveChanges();

                return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            try
            {
                var tarefaBanco = _context.Tarefas.Find(id);

                if (tarefaBanco == null)
                    return NotFound();

                if (tarefa.Data == DateTime.MinValue)
                    return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });


                tarefaBanco.Status = tarefa.Status;
                tarefaBanco.Descricao = tarefa.Descricao;
                tarefaBanco.Titulo = tarefa.Titulo;
                tarefaBanco.Data = tarefa.Data;

                _context.Tarefas.Update(tarefaBanco);
                _context.SaveChanges();

                return CreatedAtAction(nameof(ObterPorId), new { id = tarefaBanco.Id }, tarefa);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                var tarefaBanco = _context.Tarefas.Find(id);

                if (tarefaBanco == null)
                    return NotFound();


                _context.Tarefas.Remove(tarefaBanco);
                _context.SaveChanges();
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
