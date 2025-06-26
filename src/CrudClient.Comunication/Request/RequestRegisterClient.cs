using System.Globalization;

namespace CrudClient.Comunication.Request
{
    public class RequestRegisterClient
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public required string Description { get; set; } = string.Empty;
    }
}
