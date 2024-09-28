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
    }
}