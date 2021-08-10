using LegendWeb.Data;
using LegendWeb.Models;
using LegendWeb.Models.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb.Models.Services.Implementations
{
    public class AddressRepository : IAddressRepository
    {
        private readonly LegendDbContext _context;

        public AddressRepository(LegendDbContext context)
        {
            _context = context;
        }
        public Address GetAddress(string userId)
        {
            var address = _context.Address.FirstOrDefault(a => a.UserId == userId);
            return address;
        }

    }
}
