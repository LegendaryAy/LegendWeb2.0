using LegendWeb.Models;
using System.Collections.Generic;

namespace LegendWeb.Services.Interfaces
{
    public interface IExperienceRepository
    {
        List<Experience> GetExp(string userId);
        List<ExpDescription> GetDesc(string expId);
    }
}
