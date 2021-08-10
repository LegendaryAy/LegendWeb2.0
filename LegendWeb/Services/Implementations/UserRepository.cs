using LegendWeb.Data;
using LegendWeb.Models;
using LegendWeb.Models.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb.Models.Services.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly LegendDbContext _context;

        public UserRepository(LegendDbContext context)
        {
            _context = context;
        }
        public Information GetUser(string id)
        {
            var user = _context.User.FirstOrDefault(a => a.Id == id);
            return user;
        }

       
    }
}
