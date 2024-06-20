using Emissora_Tv_Api.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Emissora_Tv_Api.Models
{
    [Table("Programa")]
    public class Programa : Entity
    {
        [Required(ErrorMessage ="O campo {0} é obrigatório.")]
        [StringLength(100,ErrorMessage ="O campo {0} deve conter entre {2} e {1} caracteres.",MinimumLength = 5)]
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public string Classificacao { get; set; }

        public DateTime DataInicial { get; set; }
        public  bool Ativo { get; set; }

    }
}
