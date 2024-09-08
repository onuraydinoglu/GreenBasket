using System.ComponentModel.DataAnnotations;

namespace GreenBasket.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        public string? StoreName { get; set; }
    }
}