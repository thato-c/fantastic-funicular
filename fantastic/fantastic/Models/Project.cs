namespace fantastic.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Project_Name { get; set; }
        public string Project_Description { get; set;}
        public int UserId { get; set; }
        public int OrganisationId { get; set; }

        // Navigation properties
        public Organisation Organisation { get; set; }
        public User User { get; set; }
    }
}
