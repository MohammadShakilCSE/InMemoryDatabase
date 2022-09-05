namespace WebApi.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }  
        public long phone { get; set; }
        public List<Addresses>? Addresses { get; set; }
    }
}
