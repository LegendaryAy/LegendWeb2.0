using LegendWeb.Data;
using LegendWeb.Models;
using LegendWeb.Models.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb.Models.Services.Implementations
{
    public class ProjectsRepository : IProjectsRepository
    {
        private readonly LegendDbContext _context;

        public ProjectsRepository(LegendDbContext context)
        {
            _context = context;
        }
        public List<Projects> GetProjects(string userId)
        {
            var projects = _context.Projects.Where(p => p.UserId == userId).ToList();
            return projects;
        }

    }
}
