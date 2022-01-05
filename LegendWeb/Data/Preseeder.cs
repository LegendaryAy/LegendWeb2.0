using LegendWeb.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace LegendWeb.Data
{
    public static class Preseeder
    {
        public static void Seed(this ModelBuilder builder) 
        {
            SeedUser(builder);
            SeedAddress(builder);
            SeedProjects(builder);
            SeedSkills(builder);
        }
        private static void SeedUser(ModelBuilder builder)
        {
            var user = new Information
            {
                Id = "1",
                FirstName = "Ayobami",
                LastName = "Fadeni",
                Email = "fadeniayobami@gmail.com",
                PhoneNumber = "+234-8106322363",
                ImageUrl = "images/1.jpg",
                ImageThumbNailUrl = "images/2.jpg",
                Bio = "With experience in developing scalable applications, I am highly proficient and committed to building innovative software applications. I’m in tune with the latest technological trends and I use them to build efficient software applications.",
                Description = "I am a Software Engineer from Lagos",
                DateOfBirth = "17th of Semptember",
                Degree = "Proficient",
                WorkStatus = "Available",
                Education = "B.Sc (Hons) Biochemistry, Obafemi Awolowo University",
                Gender = "Male",
                JobTitle = "Fullstack Software Engineer",
                Age = "23"
            };
            builder.Entity<Information>().HasData(user);
        }

        private static void SeedAddress(ModelBuilder builder)
        {
            var address = new Address
            {
                Street = "2013, Adunni Oluwole Loop, Fara park 2 Estate, Lekki-Epe Expressway",
                City = "Lagos",
                Country = "Nigeria",
                UserId = "1"
            };
            builder.Entity<Address>().HasData(address);
        }
        private static void SeedSkills(ModelBuilder builder)
        {
            var a = new Skills { Name = "HTML", Progress = 100, UserId = "1" };
            var b = new Skills { Name = "CSS", Progress = 95, UserId = "1" };
            var c = new Skills { Name = "JavaScript", Progress = 89, UserId = "1" };
            var d = new Skills { Name = "C#", Progress = 90, UserId = "1" };
            var e = new Skills { Name = "SQL", Progress = 82, UserId = "1" };
            var f = new Skills { Name = "PHP", Progress = 86, UserId = "1" };
            var skillList = new List<Skills> { a, b, c, d, e, f };
            foreach (var item in skillList)
            {
                builder.Entity<Skills>().HasData(item);
            }
        }

        private static void SeedProjects(ModelBuilder builder)
        {
            var a = new Projects { Name = "Livestock247 Web App", Body = "An online marketplace for livestocks integrated with  payment gateway", ImageUrl = "images/work4.png", Url = "http://livestockfarms.herokuapp.com/", UserId = "1" };
            var b = new Projects { Name = "PlentyTechJobs", Body = "PlentyTechJobs is the one platform for finding the best technology jobs", ImageUrl = "images/PTJ.png", Url = "https://plentytechjobs.africa", UserId = "1" };
            var c = new Projects { Name = "Omney", Body = "Omney is an application that will let users buy and sell stocks", ImageUrl = "images/Omney.png", Url= "http://legendary-ay.herokuapp.com/", UserId = "1" };
            var d = new Projects { Name = "Password Generator", Body = "A Javascript application that creates random passwords", ImageUrl = "images/work1.png", Url = "https://legendaryay.github.io/PasswordGenerator/", UserId = "1" };
            var e = new Projects { Name = "ContactMangerAPI", Body = "A RESTful API for managing contacts", ImageUrl = "images/work5.png", Url = "https://github.com/LegendaryAy/ContactManagerApi", UserId = "1" };
            var f = new Projects { Name = "LegendBank", Body = "A simple Bank application that performs basic transactions", ImageUrl = "images/work6.png", Url = "https://github.com/LegendaryAy/LegendBank", UserId = "1" };
            var projects = new List<Projects> { a, b, c, d, e, f };
            foreach (var item in projects)
            {
                builder.Entity<Projects>().HasData(item);
            }
        }

    }
}
