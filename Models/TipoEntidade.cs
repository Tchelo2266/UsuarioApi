using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsuarioAPI8.Models
{
    public class TipoEntidade
    {
        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoEntidadeId { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [MaxLength(100)]
        public required string Descricao { get; set; }
    }
}
