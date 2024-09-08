using System.ComponentModel.DataAnnotations;

namespace GreenBasket.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string? CategoryName { get; set; }

        public string? CategoryImage { get; set; }

        public string? CategoryUrl { get; set; }

        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();

        public List<Product> Products { get; set; } = new List<Product>();

        public List<Store> Stores { get; set; } = new List<Store>();
    }
}