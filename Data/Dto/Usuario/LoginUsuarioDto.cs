using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI8.Data.Dto.Usuario
{
    public class LoginUsuarioDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
