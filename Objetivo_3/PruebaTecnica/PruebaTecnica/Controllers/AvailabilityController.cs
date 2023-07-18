using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using PruebaTecnica.Models;

namespace PruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {
        //Este metodo recibiria el token de autenticación y el id de la actividad a buscar la disponibilidad
        [HttpGet("{activityId}")]
        public async Task<ICollection<Availability>> GetByIdAsync(int activityId)
        {
            return null;
        }
        //Retornaria todas las fechas disponibles de la actividad deseada.
    }
}
