namespace Web.Models
{
    public class Package
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public decimal price { get; set; }
        public int duration { get; set; }
        public string? image { get; set; }
    }
}
