using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MODULOAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new  //Tipo Anonimo
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };
            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar([FromRoute] string nome)
        {

            var msg =
                DateTime.Now.Hour >= 18 ? "Boa Noite" :
                (DateTime.Now.Hour < 12 && DateTime.Now.Hour > 5 ? "Bom dia" : "Boa tarde");


            var mensagem = $"Olá, {msg} {nome}, seja bem-vindo!";

            return Ok(new
            {
                mensagem
            });
        }
    }
}