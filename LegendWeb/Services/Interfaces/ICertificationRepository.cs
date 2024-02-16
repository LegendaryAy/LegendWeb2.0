using LegendWeb.Models;
using System.Collections.Generic;

namespace LegendWeb.Services.Interfaces
{
    public interface ICertificationRepository
    {
        List<Certification> GetCerts(string userId);
    }
}
