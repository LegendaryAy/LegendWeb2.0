using System;
using System.ComponentModel.DataAnnotations;

namespace LegendWeb.Models
{
    public class Projects
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public string Url { get; set; }
        public Information User { get; set; }
        public string UserId { get; set; }
    }
}