namespace fantastic.Models
{
    public class Organisation
    {
        public int OrganisationId { get; set; }
        public string OrganisationName { get; set; } = string.Empty;

        // Navigation properties
        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
