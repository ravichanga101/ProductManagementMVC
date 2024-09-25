using System.ComponentModel.DataAnnotations;

namespace ProductManagementMVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 100 characters.")]
        public string Name { get; set; }

        [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10,000.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [StringLength(200, ErrorMessage = "Description can't be longer than 200 characters.")]
        public string Description { get; set; }
    }
}
