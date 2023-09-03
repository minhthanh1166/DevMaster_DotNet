namespace Lap02.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public string Address { get; set; }
        public string Bio { get; set; }
        public int Gender { get; set; } = 0;
        public DateTime Birthday { get; set; }
    }
}
