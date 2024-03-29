﻿// <auto-generated />
using LegendWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LegendWeb.Migrations
{
    [DbContext(typeof(LegendDbContext))]
    partial class LegendDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("LegendWeb.Models.Address", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = "1c1ecee7-08cc-4dd9-9980-008ce048028b",
                            City = "Lagos",
                            Country = "Nigeria",
                            Street = "2013, Adunni Oluwole Loop, Fara park 2 Estate, Lekki-Epe Expressway",
                            UserId = "1"
                        });
                });

            modelBuilder.Entity("LegendWeb.Models.Certification", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Issuer")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Certifications");

                    b.HasData(
                        new
                        {
                            Id = "59634931-b36b-437c-8425-0069838fe11f",
                            ImageUrl = "images/aws.png",
                            Issuer = "AWS",
                            Name = "AWS Certified Cloud Practitioner",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "72027f4b-974b-428d-83a5-81e6528e288c",
                            ImageUrl = "images/mcstyling.png",
                            Issuer = "University of Michigan",
                            Name = "Advanced Styling with Responsive Design",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "923c27ff-b2ed-4ed1-911b-71beb719f260",
                            ImageUrl = "images/mccss.png",
                            Issuer = "University of Michigan",
                            Name = "Introduction to CSS3",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "61ee821a-e106-48ee-ba02-ea4241d474e7",
                            ImageUrl = "images/scrum.png",
                            Issuer = "ScrumStudy",
                            Name = "Scrum Fundamentals Certified",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "75111b9a-1c07-448b-ac8c-8b45495c6604",
                            ImageUrl = "images/mchtml.png",
                            Issuer = "University of Michigan",
                            Name = "Introduction to HTML5",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "72a9e636-55ad-477c-85f7-2147428ddf70",
                            ImageUrl = "images/web.png",
                            Issuer = "FreeCodeCamp",
                            Name = "Responsive Web Design",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "d49f9569-3213-4aed-9ddc-7f3b5c9da987",
                            ImageUrl = "images/javascriptfc.png",
                            Issuer = "FreeCodeCamp",
                            Name = "Javascript Algorithms and Data Structures",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "2012e0ac-ea3a-4307-9687-bb3530c06879",
                            ImageUrl = "images/comm.png",
                            Issuer = "Udemy",
                            Name = "Communication Skills for Beginners",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "b30508d3-3e05-490d-8526-bcc605e17f42",
                            ImageUrl = "images/google.png",
                            Issuer = "Google & Konverge Media",
                            Name = "Google Digital Skills for Africa",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "1de74db5-a0c4-4acc-9f6f-e0200804cad9",
                            ImageUrl = "images/mcjavascript.png",
                            Issuer = "University of Michigan",
                            Name = "Interactivity with Javascript",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "781c83ce-2359-4e75-9ce7-0261670a1500",
                            ImageUrl = "images/decagon.png",
                            Issuer = "Decagon",
                            Name = "Software Engineering and Leadship Training",
                            UserId = "1"
                        });
                });

            modelBuilder.Entity("LegendWeb.Models.Contact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("LegendWeb.Models.ExpDescription", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("ExperienceId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.ToTable("ExpDescription");

                    b.HasData(
                        new
                        {
                            Id = "027bddf9-a860-4325-8cad-350509d50bbc",
                            Description = "Collaborated with product managers, business analysts, and stakeholders to gather and understand software requirements",
                            ExperienceId = "1"
                        },
                        new
                        {
                            Id = "e4088ad9-c220-41e1-bc17-cd9f2e36fb9a",
                            Description = "Performed root cause analysis to understand the cause of bugs and implement appropriate fixes.",
                            ExperienceId = "1"
                        },
                        new
                        {
                            Id = "8be1c423-3fa6-4a86-beca-922bb6eb44ad",
                            Description = "Worked with DevOps teams to deploy applications to various environments, automate deployment processes.",
                            ExperienceId = "1"
                        },
                        new
                        {
                            Id = "d586c679-0e63-4535-a934-5aa5be2909d5",
                            Description = "Participated in the ongoing development of applications that meet the needs of our customers.",
                            ExperienceId = "1"
                        },
                        new
                        {
                            Id = "ffdf3055-6506-4b24-9189-aaed9672e340",
                            Description = "Delivered new functionality and change requests for existing applications.",
                            ExperienceId = "1"
                        },
                        new
                        {
                            Id = "82670936-8247-446c-b1b5-d438b2f0e3f6",
                            Description = "Used Agile Methodologies (SCRUM) while developing applications.",
                            ExperienceId = "2"
                        },
                        new
                        {
                            Id = "3da354f1-ca46-4336-bd02-fd7de1c39cf8",
                            Description = "Wrote clean, efficient code based on specifications.",
                            ExperienceId = "2"
                        },
                        new
                        {
                            Id = "5f06b11f-0850-4fed-9016-dcb4f8561cc5",
                            Description = "Architected and designed software systems, databases, and APIs.",
                            ExperienceId = "2"
                        },
                        new
                        {
                            Id = "9c5286b7-75a9-4c10-bb21-a6b0ef65287b",
                            Description = "Responsible for integrating software components and third-party programs.",
                            ExperienceId = "2"
                        },
                        new
                        {
                            Id = "94922087-6b20-42a3-bcdd-a0643da2f71b",
                            Description = "Worked with other developers and other team members to establish objectives and design more functional, cohesive codes to enhance the user experience.",
                            ExperienceId = "2"
                        },
                        new
                        {
                            Id = "a97d4437-060d-49e2-b4ce-976ed0da4363",
                            Description = "Developed ideas for new programs, products, or features by monitoring industry developments and trends.",
                            ExperienceId = "3"
                        },
                        new
                        {
                            Id = "b0e4981c-fd4e-46d0-8eff-45b5c3c94396",
                            Description = "Worked on projects using C#, .NET Core, EF Core, HTML, CSS, React.js, and JavaScript.",
                            ExperienceId = "3"
                        },
                        new
                        {
                            Id = "49f4355c-8f29-4d05-914b-36da48ff24c9",
                            Description = "Troubleshot, debugged, and upgraded existing software to meet already established requirements.",
                            ExperienceId = "3"
                        },
                        new
                        {
                            Id = "8e698d76-d784-428e-8556-2436870ba8be",
                            Description = "Performed complete testing of Web applications, units, and systems, engaging users as necessary.",
                            ExperienceId = "3"
                        },
                        new
                        {
                            Id = "d1a53cda-5be8-4fc5-bddb-d59326187a61",
                            Description = "Developed database-driven Web interfaces for rapid, real-time information sharing.",
                            ExperienceId = "3"
                        });
                });

            modelBuilder.Entity("LegendWeb.Models.Experience", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Company = "Cavista, Axess",
                            Date = "April 2022 - February 2024",
                            Location = "Dallas, Texax, USA",
                            Logo = "images/cavista.png",
                            Title = "Software Engineer",
                            UserId = "1",
                            Website = "https://www.cavistatech.com/"
                        },
                        new
                        {
                            Id = "2",
                            Company = "Decagon",
                            Date = "March 2021 - April 2022",
                            Location = "Lagos, Nigeria",
                            Logo = "images/decagonlogo.png",
                            Title = "Software Engineer",
                            UserId = "1",
                            Website = "https://decagonhq.com/"
                        },
                        new
                        {
                            Id = "3",
                            Company = "Cousant",
                            Date = "July 2019 - March 2021",
                            Location = "Lagos, Nigeria",
                            Logo = "images/cousant.png",
                            Title = "Consultant Fullstack Developer",
                            UserId = "1",
                            Website = "https://cousant.com/"
                        });
                });

            modelBuilder.Entity("LegendWeb.Models.Information", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Age")
                        .HasColumnType("TEXT");

                    b.Property<string>("Bio")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Degree")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Education")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageThumbNailUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkStatus")
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Age = "23",
                            Bio = "With experience in developing scalable applications, I am highly proficient and committed to building innovative software applications. I’m in tune with the latest technological trends and I use them to build efficient software applications.",
                            DateOfBirth = "17th of September",
                            Degree = "Proficient",
                            Description = "I am a Software Engineer from Lagos",
                            Education = "B.Sc (Hons) Biochemistry, Obafemi Awolowo University",
                            Email = "fadeniayobami@gmail.com",
                            FirstName = "Ayobami",
                            Gender = "Male",
                            ImageThumbNailUrl = "images/2.jpg",
                            ImageUrl = "images/1.jpg",
                            JobTitle = "Fullstack Software Engineer",
                            LastName = "Fadeni",
                            PhoneNumber = "+234-8106322363",
                            WorkStatus = "Available"
                        });
                });

            modelBuilder.Entity("LegendWeb.Models.Projects", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = "bcc34a46-6f6c-4738-99df-0d8cf0367c12",
                            Body = "An online marketplace for livestocks integrated with  payment gateway",
                            ImageUrl = "images/work4.png",
                            Name = "Livestock247 Web App",
                            Url = "http://livestockfarms.herokuapp.com/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "c28d7375-afdd-4100-81db-17d03b6c01a5",
                            Body = "PlentyTechJobs is the one platform for finding the best technology jobs",
                            ImageUrl = "images/PTJ.png",
                            Name = "PlentyTechJobs",
                            Url = "https://plentytechjobs.africa",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "aa8728e0-8a6b-4665-b41d-97d1bcb48fa0",
                            Body = "Omney is an application that will let users buy and sell stocks",
                            ImageUrl = "images/Omney.png",
                            Name = "Omney",
                            Url = "http://legendary-ay.herokuapp.com/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "570d599f-1338-4eac-a49d-a9f674eab0fa",
                            Body = "A Javascript application that creates random passwords",
                            ImageUrl = "images/work1.png",
                            Name = "Password Generator",
                            Url = "https://legendaryay.github.io/PasswordGenerator/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "04912f8b-4ff2-4190-b856-d7ffaf328b5c",
                            Body = "A RESTful API for managing contacts",
                            ImageUrl = "images/work5.png",
                            Name = "ContactMangerAPI",
                            Url = "https://github.com/LegendaryAy/ContactManagerApi",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "e66dfe61-d139-4560-9a8d-6f707fba07c0",
                            Body = "A simple Bank application that performs basic transactions",
                            ImageUrl = "images/work6.png",
                            Name = "LegendBank",
                            Url = "https://github.com/LegendaryAy/LegendBank",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "db1c463e-e021-4b3e-9af4-20968f0175b2",
                            Body = "An online home care system for hospice patients in the US.",
                            ImageUrl = "images/work7.png",
                            Name = "Hospice Solution",
                            Url = "https://www.axxess.com/hospice-software/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "e7c9cb35-7ff7-45c7-9f0f-9425e9494c0d",
                            Body = "A boilerplate for a travel website",
                            ImageUrl = "images/work2.png",
                            Name = "Legend Travels",
                            Url = "https://legendaryay.github.io/LegendTravels/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "5d094425-16d9-48dd-ae1c-cd9e19487ba9",
                            Body = "A boilerplate for an health blog",
                            ImageUrl = "images/work3.png",
                            Name = "Legend Health ",
                            Url = "https://legendaryay.github.io/LegendHealth/",
                            UserId = "1"
                        });
                });

            modelBuilder.Entity("LegendWeb.Models.Skills", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Progress")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = "ded796e0-668a-40c9-a11e-39280f49762d",
                            Name = "HTML",
                            Progress = 100,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "4a80aecd-55c3-4221-9905-6b1bb7467d3c",
                            Name = "CSS",
                            Progress = 95,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "ba82394c-c6d7-4fc4-8c1a-3502c15db292",
                            Name = "JavaScript",
                            Progress = 89,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "9e6e7dfb-27c6-4e52-8e3e-b958740114c6",
                            Name = "C#",
                            Progress = 90,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "18861412-b69d-41b5-bb31-330e1d987f9a",
                            Name = "SQL",
                            Progress = 82,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "d56c9e9b-2e2d-48d2-9895-7d837f634acd",
                            Name = "PHP",
                            Progress = 86,
                            UserId = "1"
                        });
                });

            modelBuilder.Entity("LegendWeb.Models.Address", b =>
                {
                    b.HasOne("LegendWeb.Models.Information", "User")
                        .WithOne("Address")
                        .HasForeignKey("LegendWeb.Models.Address", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LegendWeb.Models.Certification", b =>
                {
                    b.HasOne("LegendWeb.Models.Information", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LegendWeb.Models.ExpDescription", b =>
                {
                    b.HasOne("LegendWeb.Models.Experience", "Experience")
                        .WithMany("Description")
                        .HasForeignKey("ExperienceId");

                    b.Navigation("Experience");
                });

            modelBuilder.Entity("LegendWeb.Models.Experience", b =>
                {
                    b.HasOne("LegendWeb.Models.Information", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LegendWeb.Models.Projects", b =>
                {
                    b.HasOne("LegendWeb.Models.Information", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LegendWeb.Models.Skills", b =>
                {
                    b.HasOne("LegendWeb.Models.Information", "User")
                        .WithMany("Skills")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LegendWeb.Models.Experience", b =>
                {
                    b.Navigation("Description");
                });

            modelBuilder.Entity("LegendWeb.Models.Information", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Projects");

                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
