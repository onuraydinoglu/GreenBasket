namespace GreenBasket.Models
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; } = null!;
        public List<Product> Products { get; set; } = null!;
        public Product Product { get; set; } = null!;
        public List<SubCategory> SubCategories { get; set; } = null!;
        public List<Store> Stores { get; set; } = null!;
    }
}