using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI8.Models
{
    public class Usuario : IdentityUser
    {
        [Required]
        [MaxLength(30)]
        public required string Documento { get; set; }
        public Usuario() : base() { }
    }
}
