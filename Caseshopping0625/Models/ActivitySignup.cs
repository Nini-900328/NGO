namespace Caseshopping0625.Models
{
    public class ActivitySignup
    {
        public int Id { get; set; }

        public string ActivityTitle { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public int PeopleCount { get; set; }

        public string? ImageUrl { get; set; }
    }
}
