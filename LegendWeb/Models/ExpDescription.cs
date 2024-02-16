using System.ComponentModel.DataAnnotations;
using System;

namespace LegendWeb.Models
{
    public class ExpDescription
    {

        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        
        [StringLength(150)]
        [Required]
        public string Description { get; set; }

        public Experience Experience { get; set; }
        public string ExperienceId { get; set; }

    }
}
