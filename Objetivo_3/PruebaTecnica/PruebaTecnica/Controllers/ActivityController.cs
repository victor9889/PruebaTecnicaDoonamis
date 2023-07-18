using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;

namespace PruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        //Este metodo recibiria el token de autenticación y opcionalmente distancia y categoria para filtrar.
        [HttpGet("getAll")]
        public async Task<ICollection<Activity>> GetAllAsync([FromQuery] double? distance, [FromQuery] string category)
        {
            return null;
        }
        //Retornaria la lista de las actividades que cumplen con los filtros si los hay, o todas.

        //Este metodo recibiria el token de autenticación y el id de la actividad a mostrar en detalle
        [HttpGet("{activityId}")]
        public async Task<IActionResult> GetByIdAsync(int activityId)
        {
            return null;
        }
        //Retornaria todos los detalles de la actividad deseada.
    }
}
