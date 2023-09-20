namespace fantastic.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; } 
        public string Password { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
