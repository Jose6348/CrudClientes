namespace CrudClient.Domain.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreatedDate { get; set; }

        public Client(string name, string email, DateTime birthday)
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
            Name = name;
            Email = email;
            Birthday = birthday;
        }
    }


}
