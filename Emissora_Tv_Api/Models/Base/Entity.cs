using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Emissora_Tv_Api.Models.Base
{
    public class Entity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
