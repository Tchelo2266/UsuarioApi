using Microsoft.AspNetCore.Mvc;
using UsuarioAPI8.Data.Dto.Usuario;
using UsuarioAPI8.Services;

namespace UsuarioAPI8.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("/cadastro")]
        public async Task<IActionResult> CadastraUsuario([FromBody] CreateUsuarioDto dto)
        {
            await _usuarioService.CadastraAsync(dto);
            return Ok("Usuário cadastrado com sucesso!");
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login([FromBody] LoginUsuarioDto dto)
        {
            var token = await _usuarioService.Login(dto);
            return Ok(token);
        }
    }
}
