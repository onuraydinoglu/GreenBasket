namespace GreenBasket.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? FullName { get; set; }
        public long Number { get; set; }
        public string? Addres { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public int PostalCode { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }



    }
}