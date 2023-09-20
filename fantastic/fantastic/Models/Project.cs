﻿using System.ComponentModel.DataAnnotations;

namespace fantastic.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Project_Name { get; set; } = string.Empty;
        public string? Project_Description { get; set;}
        public int UserId { get; set; }
        public int OrganisationId { get; set; }

        // Navigation properties
        [Required]
        public Organisation Organisation { get; set; }
        [Required]
        public User User { get; set; }
    }
}
