using LegendWeb.Data;
using LegendWeb.Models;
using LegendWeb.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LegendWeb.Services.Implementations
{
    public class CertificationRepository :ICertificationRepository
    {
        private readonly LegendDbContext _context;

        public CertificationRepository(LegendDbContext context)
        {
            _context = context;
        }
        public List<Certification> GetCerts(string userId)
        {
            var certs = _context.Certifications.Where(s => s.UserId == userId).ToList();
            return certs;
        }
    }
}
