using LegendWeb.Data;
using LegendWeb.Models;
using LegendWeb.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LegendWeb.Services.Implementations
{
    public class ExperienceRepository : IExperienceRepository
    {
        private readonly LegendDbContext _context;

        public ExperienceRepository(LegendDbContext context)
        {
            _context = context;
        }
        public List<Experience> GetExp(string userId)
        {
            var exp = _context.Experiences.Where(s => s.UserId == userId).ToList();
            foreach (var experience in exp)
            {
                experience.Description = GetDesc(experience.Id);
            }
            return exp;
        }

        public List<ExpDescription> GetDesc(string expId)
        {
            var exp = _context.ExpDescription.Where(s => s.ExperienceId == expId).ToList();
            return exp;
        }

    }
}
