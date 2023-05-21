using Microsoft.JSInterop;

namespace Ders9._4.appsettings.jsonDosyasıNedir.Models
{
    public class ilİnfo
    {
        public string Port { get; set; }
        public string Host { get; set; }
        public EmailInfo EmailInfo { get; set; }
    }
    public class EmailInfo
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
