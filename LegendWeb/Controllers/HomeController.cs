using LegendWeb.Models;
using LegendWeb.Models.Services.Interfaces;
using LegendWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static Logger _nlogger = LogManager.GetLogger("log");
        private readonly IUserRepository _userRepo;
        private readonly ISkillsRepository _skillRepo;
        private readonly IProjectsRepository _projectsRepo;
        private readonly IAddressRepository _addressRepo;

        public HomeController(ILogger<HomeController> logger, IUserRepository userRepo, ISkillsRepository skillRepo, IProjectsRepository projectsRepo, IAddressRepository addressRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
            _skillRepo = skillRepo;
            _projectsRepo = projectsRepo;
            _addressRepo = addressRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var user = _userRepo.GetUser("1");
            var address = _addressRepo.GetAddress("1");
            var model = new HomeViewModel()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Description = user.Description,
                Education = user.Education,
                DateOfBirth = user.DateOfBirth,
                Degree = user.Degree,
                PhoneNumber = user.PhoneNumber,
                ProfileImageUrl = user.ImageThumbNailUrl,
                Bio = user.Bio,
                WorkStatus = user.WorkStatus,
                Age = user.Age,
                Gender = user.Gender,
                Job = user.JobTitle,
                City = $"{address.City}, {address.Country}",
                Skills = _skillRepo.GetSkills("1"),
                Projects = _projectsRepo.GetProjects("1")
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
