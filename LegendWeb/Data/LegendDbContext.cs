using LegendWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb.Data
{
    public class LegendDbContext : DbContext
    {
        public LegendDbContext(DbContextOptions<LegendDbContext> options): base(options)
        {

        }
        public DbSet<Information> User { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<ExpDescription> ExpDescription { get; set; }
        public DbSet<Certification> Certifications { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
