using Backend.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
    
{
    [Route("api/[controller])")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpPost]
        public async Task<IActionResult> Post(Usuario usuario)
        {
            try
            {
                await _usuarioService.SaveUser(usuario);

                return Ok(new { message = "Usuario registrado con exito" });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }





        }
    }
}
