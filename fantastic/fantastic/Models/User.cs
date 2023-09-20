namespace fantastic.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;

        // Navigation properties
        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
