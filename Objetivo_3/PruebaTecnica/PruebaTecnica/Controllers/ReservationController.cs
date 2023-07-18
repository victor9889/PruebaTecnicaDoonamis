using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;

namespace PruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        //Este metodo sirve para reservar una actividad, recibiria el objeto de reserva, con la fecha, id usuario, id actividad, y token de autenticacion.
        [HttpPost]
        public async Task<IActionResult> BookActivity([FromBody] Reservation reservation)
        {
            return null;
        }
        //Retornaria 200 y el objeto de la reserva.
    }
}
