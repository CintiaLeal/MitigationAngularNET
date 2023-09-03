using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Prueba2.Models;
using Microsoft.AspNetCore.Cors;

namespace Prueba2.Controllers
{

        
        [EnableCors("ReglasCors")]
        [Route("usuario")]
        [ApiController]
        public class UsuarioController : ControllerBase
        {
            [HttpGet]
            [Route("listar")]
            public dynamic listaUsuarios()
            {

                List<Usuario> usu = new List<Usuario>
            {
                new Usuario
                {
                    Id = 1,
                    Name = "CINTIA",
                    Correo = "cintia@gmail.com",
                    Edad = 23
                },
                new Usuario
                {
                    Id = 2,
                    Name = "ANA",
                    Correo = "ana@gmail.com",
                    Edad = 23
                }
            };
                return usu;

            }

        
    }
}



