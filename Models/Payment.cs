namespace GreenBasket.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public long CardNumber { get; set; }
        public int CVV { get; set; }
        public string? Method { get; set; }
        public User? User { get; set; }
    }
}