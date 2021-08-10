using LegendWeb.Data;
using LegendWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb.Models.Services.Interfaces
{
    public interface IAddressRepository
    {
        Address GetAddress(string userId);
    }
}
