using System.ComponentModel.DataAnnotations;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LegendWeb.Models
{
    public class Experience
    {
       
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [StringLength(100)]
        [Required]
        public string Title { get; set; }
        [StringLength(100)]
        [Required]
        public string Date { get; set; }
        [StringLength(100)]
        [Required]
        public string Company { get; set; }
        [StringLength(100)]
        [Required]
        public string Logo { get; set; }
        [StringLength(500)]
        [Required]
        public string Website { get; set; }
        [StringLength(250)]
        [Required]
        public string Location { get; set; }
        [Required]
        public ICollection<ExpDescription> Description { get; set; }
        public Information User { get; set; }
        public string UserId { get; set; }
    }
}
