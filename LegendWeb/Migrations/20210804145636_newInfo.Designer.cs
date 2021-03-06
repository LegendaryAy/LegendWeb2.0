// <auto-generated />
using LegendWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LegendWeb.Migrations
{
    [DbContext(typeof(LegendDbContext))]
    [Migration("20210804145636_newInfo")]
    partial class newInfo
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
                            Id = "babfb1b6-f78e-4dbc-bc5a-6de300a920e2",
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
                            DateOfBirth = "17 September, 1998",
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
                            Id = "2b84f9af-806b-4732-823a-d5484e2da24e",
                            Body = "An online marketplace for livestocks integrated with  payment gateway",
                            ImageUrl = "images/work4.png",
                            Name = "Livestock247 Web App",
                            Url = "http://livestockfarms.herokuapp.com/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "40323260-0263-4266-9447-eef25dbbc534",
                            Body = "A Travel website template showing different cities and means to travel",
                            ImageUrl = "images/work2.png",
                            Name = "LegendTravels",
                            Url = "https://legendaryay.github.io/LegendTravels/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "2727f2ea-147c-4b7d-8004-7375e4893a82",
                            Body = "An Health website template showing different means of achieving good health",
                            ImageUrl = "images/work3.png",
                            Name = "LegendHealth",
                            Url = "https://legendaryay.github.io/LegendHealth/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "def32c62-8238-4e58-bce5-ff695a5ebbaf",
                            Body = "A Javascript application that creates random passwords",
                            ImageUrl = "images/work1.png",
                            Name = "Password Generator",
                            Url = "https://legendaryay.github.io/PasswordGenerator/",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "38ca6ddb-b00a-4a46-8b09-06d153d65d6f",
                            Body = "A RESTful API for managing contacts",
                            ImageUrl = "images/work5.png",
                            Name = "ContactMangerAPI",
                            Url = "https://github.com/LegendaryAy/ContactManagerApi",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "7ebe93f6-2ab5-411f-90ff-9cc4a1bc2d11",
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
                            Id = "d8315fb2-929e-40cc-bc26-bebec0e1ce0d",
                            Name = "HTML",
                            Progress = 100,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "cf1023b4-a416-476c-829a-d16e6f5984e7",
                            Name = "CSS",
                            Progress = 95,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "33bf4816-cf26-4caf-aa01-f806425ecd4c",
                            Name = "JavaScript",
                            Progress = 89,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "f7c8d07e-b82f-4c4e-b068-7209b6e7ae40",
                            Name = "C#",
                            Progress = 90,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "e6a4e70b-6dba-46ce-b3cb-f72474a7e3b9",
                            Name = "SQL",
                            Progress = 82,
                            UserId = "1"
                        },
                        new
                        {
                            Id = "8390c033-5851-4a25-b6ca-3d22a0c14174",
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
