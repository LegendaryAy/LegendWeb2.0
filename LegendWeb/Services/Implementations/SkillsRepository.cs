using LegendWeb.Data;
using LegendWeb.Models;
using LegendWeb.Models.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb.Models.Services.Implementations
{
    public class SkillsRepository : ISkillsRepository
    {
        private readonly LegendDbContext _context;

        public SkillsRepository(LegendDbContext context)
        {
            _context = context;
        }
        public List<Skills> GetSkills(string userId)
        {
            var skills = _context.Skills.Where(s => s.UserId == userId).ToList();
            return skills;
        }

    }
}
