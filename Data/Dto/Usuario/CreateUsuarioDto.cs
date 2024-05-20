using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI8.Data.Dto.Usuario
{
    public class CreateUsuarioDto
    {
        [Required]
        public required string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        [Required]
        [Compare("Password")]
        public required string RePassword { get; set; }
        [Required]
        [MaxLength(30)]
        public required string Documento { get; set; }

    }
}
