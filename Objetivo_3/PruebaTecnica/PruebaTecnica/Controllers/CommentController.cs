using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;

namespace PruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        //Este metodo sirve para añadir un comentario con su puntuaacion, recibe el comentario, la puntuacion, el id de ususario y actividad en el body
        //además del token de autenticacion.
        [HttpPost]
        public async Task<IActionResult> CommentActivity([FromBody] Comment comment)
        {
            return null;
        }
        //Retornaria 200 y el objeto del comentario.
    }
}
