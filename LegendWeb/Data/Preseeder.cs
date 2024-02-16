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
            SeedCertifications(builder);
            SeedExperience(builder);
            SeedDescriptions(builder);
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
                DateOfBirth = "17th of September",
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
            var g = new Projects { Name = "Hospice Solution", Body = "An online home care system for hospice patients in the US.", ImageUrl = "images/work7.png", Url = "https://www.axxess.com/hospice-software/", UserId = "1" };
            var h = new Projects { Name = "Legend Travels", Body = "A boilerplate for a travel website", ImageUrl = "images/work2.png", Url = "https://legendaryay.github.io/LegendTravels/", UserId = "1" };
            var i = new Projects { Name = "Legend Health ", Body = "A boilerplate for an health blog", ImageUrl = "images/work3.png", Url = "https://legendaryay.github.io/LegendHealth/", UserId = "1" };
            var projects = new List<Projects> { a, b, c, d, e, f, g, h, i };
            foreach (var item in projects)
            {
                builder.Entity<Projects>().HasData(item);
            }
        }

        private static void SeedCertifications(ModelBuilder builder)
        {
           var a = new Certification { Name = "AWS Certified Cloud Practitioner", Issuer = "AWS", UserId = "1", ImageUrl = "images/aws.png"};
            var b = new Certification { Name = "Advanced Styling with Responsive Design", Issuer = "University of Michigan", UserId = "1", ImageUrl = "images/mcstyling.png" };
            var c = new Certification { Name = "Introduction to CSS3", Issuer = "University of Michigan", UserId = "1", ImageUrl = "images/mccss.png" };
            var d = new Certification { Name = "Scrum Fundamentals Certified", Issuer="ScrumStudy", UserId = "1", ImageUrl = "images/scrum.png" };
            var e = new Certification { Name = "Introduction to HTML5", Issuer = "University of Michigan", UserId = "1", ImageUrl = "images/mchtml.png" };
            var f = new Certification { Name = "Responsive Web Design", Issuer="FreeCodeCamp", UserId = "1", ImageUrl = "images/web.png" };
            var g = new Certification { Name = "Javascript Algorithms and Data Structures", Issuer = "FreeCodeCamp", UserId = "1", ImageUrl = "images/javascriptfc.png" };
            var h = new Certification { Name = "Communication Skills for Beginners", Issuer="Udemy", UserId = "1", ImageUrl = "images/comm.png" };
            var i = new Certification { Name = "Google Digital Skills for Africa", Issuer = "Google & Konverge Media", UserId = "1", ImageUrl = "images/google.png" };
            var j = new Certification { Name = "Interactivity with Javascript", Issuer = "University of Michigan", UserId = "1", ImageUrl = "images/mcjavascript.png" };
            var k = new Certification { Name = "Software Engineering and Leadship Training", Issuer= "Decagon", UserId = "1", ImageUrl = "images/decagon.jpg" };
            var certifications = new List<Certification> { a, b, c, d, e, f, g, h, i, j, k };
            foreach (var item in certifications)
            {
                builder.Entity<Certification>().HasData(item);
            }
        }

        private static void SeedExperience(ModelBuilder builder)
        {
            var a = new Experience { Id = "1", Company = "Cavista, Axess", Location = "Dallas, Texax, USA", Date = "April 2022 - February 2024", Website = "https://www.cavistatech.com/", Title = "Software Engineer", Logo="images/cavista.png", UserId = "1" };
            var b = new Experience { Id = "2", Company = "Decagon", Location = "Lagos, Nigeria", Date = "March 2021 - April 2022", Website = "https://decagonhq.com/", Title = "Software Engineer", Logo= "images/decagonlogo.png", UserId = "1" };
            var c = new Experience { Id = "3", Company = "Cousant", Location = "Lagos, Nigeria", Date = "July 2019 - March 2021", Website = "https://cousant.com/", Title = "Consultant Fullstack Developer", Logo = "images/cousant.png", UserId = "1" };
            var exps = new List<Experience> { a, b, c};
            foreach (var item in exps)
            {
                builder.Entity<Experience>().HasData(item);
            }
        }

        private static void SeedDescriptions(ModelBuilder builder)
        {
            var a = new ExpDescription { ExperienceId = "1", Description = "Collaborated with product managers, business analysts, and stakeholders to gather and understand software requirements" };
            var b = new ExpDescription { ExperienceId = "1", Description = "Performed root cause analysis to understand the cause of bugs and implement appropriate fixes." };
            var c = new ExpDescription { ExperienceId = "1", Description = "Worked with DevOps teams to deploy applications to various environments, automate deployment processes." };
            var d = new ExpDescription { ExperienceId = "1", Description = "Participated in the ongoing development of applications that meet the needs of our customers." };
            var e = new ExpDescription { ExperienceId = "1", Description = "Delivered new functionality and change requests for existing applications." };
            var f = new ExpDescription { ExperienceId = "2", Description = "Used Agile Methodologies (SCRUM) while developing applications." };
            var g = new ExpDescription { ExperienceId = "2", Description = "Wrote clean, efficient code based on specifications." };
            var h = new ExpDescription { ExperienceId = "2", Description = "Architected and designed software systems, databases, and APIs." };
            var i = new ExpDescription { ExperienceId = "2", Description = "Responsible for integrating software components and third-party programs." };
            var j = new ExpDescription { ExperienceId = "2", Description = "Worked with other developers and other team members to establish objectives and design more functional, cohesive codes to enhance the user experience." };
            var l = new ExpDescription { ExperienceId = "3", Description = "Developed ideas for new programs, products, or features by monitoring industry developments and trends." };
            var m = new ExpDescription { ExperienceId = "3", Description = "Worked on projects using C#, .NET Core, EF Core, HTML, CSS, React.js, and JavaScript." };
            var n = new ExpDescription { ExperienceId = "3", Description = "Troubleshot, debugged, and upgraded existing software to meet already established requirements." };
            var o = new ExpDescription { ExperienceId = "3", Description = "Performed complete testing of Web applications, units, and systems, engaging users as necessary." };
            var p = new ExpDescription { ExperienceId = "3", Description = "Developed database-driven Web interfaces for rapid, real-time information sharing." };
            var exps = new List<ExpDescription> { a, b, c, d, e, f, g, h, i, j,l, m, n, o, p };
            foreach (var item in exps)
            {
                builder.Entity<ExpDescription>().HasData(item);
            }
        }

    }
}
