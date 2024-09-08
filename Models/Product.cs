using System.ComponentModel.DataAnnotations;

namespace GreenBasket.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string? ProductName { get; set; }

        public string? ProductImage { get; set; }

        public int ProductPrice { get; set; }

        public string? ProductUrl { get; set; }

        public string? CategoryName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public List<Category> Categories { get; set; } = new List<Category>();

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; } = null!;

    }
}