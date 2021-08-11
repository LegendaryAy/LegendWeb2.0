﻿// <auto-generated />
using LegendWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LegendWeb.Migrations
{
    [DbContext(typeof(LegendDbContext))]
    [Migration("20210811103731_date")]
    partial class date
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = "0aecf5a5-a11d-4dab-b080-123ce7c1a51c",
                            City = "Lagos",
                            Country = "Nigeria",
                            Street = "No 8, Alaba Obe Street, Off Ajuwon Road",
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
                            DateOfBirth = "17th of Semptember",
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
                            Id = "759cd101-fdbe-4cc7-812b-92311f4733e5",
                            Body = "An online marketplace for livestocks integrated with  payment gateway",
                            ImageUrl = "images/work4.png",
                            Name = "Livestock247 Web App",
                            Url = "http://livestockfarms.herokuapp.com/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "1a412695-b0a3-4fa4-a10d-59a82ce45c50",
                            Body = "A Travel website template showing different cities and means to travel",
                            ImageUrl = "images/work2.png",
                            Name = "LegendTravels",
                            Url = "https://legendaryay.github.io/LegendTravels/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "f278fd68-ee21-476d-a803-f22e4564e98b",
                            Body = "An Health website template showing different means of achieving good health",
                            ImageUrl = "images/work3.png",
                            Name = "LegendHealth",
                            Url = "https://legendaryay.github.io/LegendHealth/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "d078639e-066f-45ab-97c6-ddbdf97235de",
                            Body = "A Javascript application that creates random passwords",
                            ImageUrl = "images/work1.png",
                            Name = "Password Generator",
                            Url = "https://legendaryay.github.io/PasswordGenerator/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "08230bb6-3dbd-428b-9d52-e206d282c57f",
                            Body = "A RESTful API for managing contacts",
                            ImageUrl = "images/work5.png",
                            Name = "ContactMangerAPI",
                            Url = "https://github.com/LegendaryAy/ContactManagerApi",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "b392e18a-65a5-4a1e-866e-00993fb672b7",
                            Body = "A simple Bank application that perorms basic transactions",
                            ImageUrl = "images/work6.png",
                            Name = "LegendBank",
                            Url = "https://github.com/LegendaryAy/LegendBank",
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
                            Id = "c11407fc-ebb7-465d-acf1-4ab3d9a4fefb",
                            Name = "HTML",
                            Progress = 100,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "892c3658-834e-43a2-9b1d-c82e47327c06",
                            Name = "CSS",
                            Progress = 95,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "2d199bab-6ab6-4031-8d17-99e51ce5fae2",
                            Name = "JavaScript",
                            Progress = 89,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "8884e871-3508-450a-be83-228492c69771",
                            Name = "C#",
                            Progress = 90,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "cb67d6f8-c6f3-4658-87d9-1e09e2a68a88",
                            Name = "SQL",
                            Progress = 82,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "4a922068-1ada-44f7-b780-6716505e825b",
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
