using System.ComponentModel.DataAnnotations;
using System;

namespace LegendWeb.Models
{
    public class Certification
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [StringLength(150)]
        [Required]
        public string Name { get; set; }
        [StringLength(150)]
        [Required]
        public string Issuer { get; set; }
        public string ImageUrl { get; set; }
        public Information User { get; set; }
        public string UserId { get; set; }
    }
}
