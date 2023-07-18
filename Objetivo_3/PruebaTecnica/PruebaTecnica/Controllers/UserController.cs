using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Interfaces;
using PruebaTecnica.Models;

namespace PruebaTecnica.Controllers
{
    [Route("auth/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] User user)
        {
            User? registeredUser = await _userService.registerUser(user);

            if(registeredUser != null)
                return CreatedAtAction(nameof(RegisterUser), registeredUser);   
            return BadRequest("Mail ya en uso.");
        }

        //Este endpoint recibe el id de ususario, y por el body el resto de datos a editar, además de el token de autenticacion.
        [HttpPut("{userId}")]
        public async Task<IActionResult> EditUser([FromBody] User user, int userId)
        {
            return null;
        }
        //Retorna satisfactory si ha sido completado y sino error.


    }
}
