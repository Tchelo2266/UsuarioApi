using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI8.Data.Dto.Usuario
{
    public class LoginUsuarioDto
    {
        [Required]
        public required string Username { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}
