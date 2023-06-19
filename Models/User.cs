using System.ComponentModel.DataAnnotations;

namespace ProjektRezerwacjeSal.Models
{
    public class User
    {
        public string Role { get; set; } //User lub Admin
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

}
