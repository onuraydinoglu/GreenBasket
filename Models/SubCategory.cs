using System.ComponentModel.DataAnnotations;

namespace GreenBasket.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        public string? SubCategoryName { get; set; }

        public string? SubCategoryUrl { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public List<Product> Products { get; set; } = new List<Product>();

        public List<Store> Stores { get; set; } = new List<Store>();
    }
}