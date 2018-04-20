using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CungbanShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}