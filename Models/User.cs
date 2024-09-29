using System.Security.Cryptography.X509Certificates;

namespace GreenBasket.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public long Phone { get; set; }
        public string? Password { get; set; }
        public string? CurrentPassword { get; set; }
        public List<Product> products { get; set; } = new List<Product>();
        public List<Store> stores { get; set; } = new List<Store>();
        public List<Address> addresses { get; set; } = new List<Address>();
    }
}