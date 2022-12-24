using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MODELAPI.Models;

namespace MODELAPI.Controllers
{
    [ApiController] //Informando q essa classe é uma API
    [Route("[controller]")] //Vai usar https://Data => que é o mesmo nome da controller
    public class DataController : ControllerBase
    {
        [HttpGet]
        [Route("ObterDataHoraAtual")]
        public IActionResult ObterData()
        {
            var dat = new
            {
                Data = DateTime.Now.ToShortDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(dat);
        }

        [HttpGet]
        [Route("Somar/{n1}/{n2}")]
        public IActionResult Somar([FromRoute] int n1, [FromRoute] int n2)
        {
            int soma = n1 + n2;
            return Ok(new { soma });
        }

        [HttpGet]
        [Route("Login/{User}/{Passowrd}")]

        public IActionResult Logar([FromRoute] string User, [FromRoute] string Passowrd)
        {
            var usuario = new Usuario();

            if (usuario.User == User && usuario.Password == Passowrd)
            {
                var Usuario = DateTime.Now.Hour >= 18 ? $"Boa noite {User}" :
                (DateTime.Now.Hour > 5 && DateTime.Now.Hour < 12) ? $"Bom dia {User}"
                : $"Boa tarde {User}";


                return Ok(new { Usuario });
            }
            else
            {

                return NotFound("Não encontrado");
            }
        }


    }
}