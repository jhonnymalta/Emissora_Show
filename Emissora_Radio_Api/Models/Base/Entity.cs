using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Emissora_Radio_Api.Models.Base
{
    public class Entity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
