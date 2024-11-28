using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Product
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="üRÜN Adı Gereklidir.")]
        [StringLength(100)]

        public string Name { get; set; }

        [Range(0,10000)]

        public decimal Price { get; set; }
    }
}
