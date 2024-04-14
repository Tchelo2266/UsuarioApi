using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI8.Data.Dto.Usuario
{
    public class CreateUsuarioDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
        [Required]
        [MaxLength(30)]
        public string Documento { get; set; }

    }
}
