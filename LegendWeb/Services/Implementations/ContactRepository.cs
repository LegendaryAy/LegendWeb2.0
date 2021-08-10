using LegendWeb.Data;
using LegendWeb.Models;
using LegendWeb.Models.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb.Models.Services.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private readonly LegendDbContext _context;

        public ContactRepository(LegendDbContext context)
        {
            _context = context;
        }
        public void CreateMessage(Contact contact)
        {
            _context.Contact.Add(contact);
            _context.SaveChanges();
        }
    }
}
