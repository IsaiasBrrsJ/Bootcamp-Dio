using Microsoft.AspNetCore.Mvc;
using PraticandoENTITY_APIRest.DataContext;
using PraticandoENTITY_APIRest.Entity;

namespace PraticandoENTITY_APIRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Agenda : ControllerBase
    {
        private readonly Context _context; //Injecao de dependencia
        public Agenda([FromServices] Context context)
        {
            _context = context;
        }
        [HttpPost] //Submeter pro banco
        [Route("AdcionarContato")]  //rota do cabecalho
        public async Task<IActionResult> Insert([FromBody] Contato contato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("erro ao tentar salvar as informações");
            }

            await _context.Contatos.AddAsync(contato);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(SelectId), new { id = contato.Id }, contato);
            //cria um link pra dizer onde posso consultar por ID;
        }
        [HttpGet]
        [Route("ExibirTodosOsContatos")]
        public async Task<IActionResult> SelectAsterisco()
        {
            var contatosBanco = _context.Contatos.ToList<Contato>();
            return Ok(contatosBanco);
        }

        [HttpGet]
        [Route("BuscarPorId/{id}")]
        public async Task<IActionResult> SelectId([FromRoute] int id)
        {
            var contatoBanco = await _context.Contatos.FindAsync(id);

            if (contatoBanco is null)
            {
                return NotFound();
            }

            return Ok(contatoBanco);
        }

        [HttpDelete]
        [Route("DeletarContato/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var contatoBanco = await _context.Contatos.FindAsync(id);

            if (contatoBanco is null)
            {
                return NotFound("Não encontrado");
            }

            _context.Contatos.Remove(contatoBanco);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut]
        [Route("AtualizarContato/{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Contato contato)
        {
            var contatoBanco = await _context.Contatos.FindAsync(id);

            if (contatoBanco is null)
            {
                return NotFound("Não encontrado");
            }

            contatoBanco.Name = contato.Name;
            contatoBanco.PhoneNumber = contato.PhoneNumber;
            contatoBanco.ReceiveMessage = contato.ReceiveMessage;

            _context.Contatos.Update(contatoBanco);
            await _context.SaveChangesAsync();


            return CreatedAtAction(nameof(SelectId), new { id = contatoBanco.Id }, contato);
        }

        [HttpGet]
        [Route("SelectPorNome/{nome}")]
        public async Task<IActionResult> SelectPorNome([FromRoute] string nome)
        {
            var contatoBanco = _context.Contatos.Where(c => c.Name.Contains(nome)).ToList<Contato>();

            if (contatoBanco is null)
            {
                return NotFound("Não Encontrado");
            }


            return Ok(contatoBanco);

        }

    }
}