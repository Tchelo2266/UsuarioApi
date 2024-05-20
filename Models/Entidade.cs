using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsuarioAPI8.Models
{
    public class Entidade
    {
        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EntidadeId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(100)]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "O tipo é obrigatório")]
        public required int IdTipoEntidade { get; set; }
    }
}
