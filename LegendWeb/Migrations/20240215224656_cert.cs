using Microsoft.EntityFrameworkCore.Migrations;

namespace LegendWeb.Migrations
{
    public partial class cert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Subject = table.Column<string>(type: "TEXT", nullable: true),
                    Message = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Degree = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    WorkStatus = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    Bio = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<string>(type: "TEXT", nullable: true),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ImageThumbNailUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Education = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Issuer = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certifications_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Date = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Company = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Logo = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Website = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Body = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Progress = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpDescription",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    ExperienceId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpDescription_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Age", "Bio", "DateOfBirth", "Degree", "Description", "Education", "Email", "FirstName", "Gender", "ImageThumbNailUrl", "ImageUrl", "JobTitle", "LastName", "PhoneNumber", "WorkStatus" },
                values: new object[] { "1", "23", "With experience in developing scalable applications, I am highly proficient and committed to building innovative software applications. I’m in tune with the latest technological trends and I use them to build efficient software applications.", "17th of September", "Proficient", "I am a Software Engineer from Lagos", "B.Sc (Hons) Biochemistry, Obafemi Awolowo University", "fadeniayobami@gmail.com", "Ayobami", "Male", "images/2.jpg", "images/1.jpg", "Fullstack Software Engineer", "Fadeni", "+234-8106322363", "Available" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "UserId" },
                values: new object[] { "1c1ecee7-08cc-4dd9-9980-008ce048028b", "Lagos", "Nigeria", "2013, Adunni Oluwole Loop, Fara park 2 Estate, Lekki-Epe Expressway", "1" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ImageUrl", "Issuer", "Name", "UserId" },
                values: new object[] { "59634931-b36b-437c-8425-0069838fe11f", "images/aws.png", "AWS", "AWS Certified Cloud Practitioner", "1" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ImageUrl", "Issuer", "Name", "UserId" },
                values: new object[] { "72027f4b-974b-428d-83a5-81e6528e288c", "images/mcstyling.png", "University of Michigan", "Advanced Styling with Responsive Design", "1" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ImageUrl", "Issuer", "Name", "UserId" },
                values: new object[] { "923c27ff-b2ed-4ed1-911b-71beb719f260", "images/mccss.png", "University of Michigan", "Introduction to CSS3", "1" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ImageUrl", "Issuer", "Name", "UserId" },
                values: new object[] { "61ee821a-e106-48ee-ba02-ea4241d474e7", "images/scrum.png", "ScrumStudy", "Scrum Fundamentals Certified", "1" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ImageUrl", "Issuer", "Name", "UserId" },
                values: new object[] { "75111b9a-1c07-448b-ac8c-8b45495c6604", "images/mchtml.png", "University of Michigan", "Introduction to HTML5", "1" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ImageUrl", "Issuer", "Name", "UserId" },
                values: new object[] { "72a9e636-55ad-477c-85f7-2147428ddf70", "images/web.png", "FreeCodeCamp", "Responsive Web Design", "1" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ImageUrl", "Issuer", "Name", "UserId" },
                values: new object[] { "d49f9569-3213-4aed-9ddc-7f3b5c9da987", "images/javascriptfc.png", "FreeCodeCamp", "Javascript Algorithms and Data Structures", "1" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ImageUrl", "Issuer", "Name", "UserId" },
                values: new object[] { "2012e0ac-ea3a-4307-9687-bb3530c06879", "images/comm.png", "Udemy", "Communication Skills for Beginners", "1" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ImageUrl", "Issuer", "Name", "UserId" },
                values: new object[] { "b30508d3-3e05-490d-8526-bcc605e17f42", "images/google.png", "Google & Konverge Media", "Google Digital Skills for Africa", "1" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ImageUrl", "Issuer", "Name", "UserId" },
                values: new object[] { "1de74db5-a0c4-4acc-9f6f-e0200804cad9", "images/mcjavascript.png", "University of Michigan", "Interactivity with Javascript", "1" });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "ImageUrl", "Issuer", "Name", "UserId" },
                values: new object[] { "781c83ce-2359-4e75-9ce7-0261670a1500", "images/decagon.jpg", "Decagon", "Software Engineering and Leadership Training", "1" });

            migrationBuilder.InsertData(
               table: "Experiences",
               columns: new[] { "Id", "Company", "Date", "Location", "Logo", "Title", "UserId", "Website" },
               values: new object[] { "1", "Cavista, Axxess", "April 2022 - February 2024", "Dallas, Texas, USA", "images/cavista.png", "Software Engineer", "1", "https://www.cavistatech.com/" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "Date", "Location", "Logo", "Title", "UserId", "Website" },
                values: new object[] { "2", "Decagon", "March 2021 - April 2022", "Lagos, Nigeria", "images/decagonlogo.png", "Software Engineer", "1", "https://decagonhq.com/" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "Date", "Location", "Logo", "Title", "UserId", "Website" },
                values: new object[] { "3", "Cousant", "July 2019 - March 2021", "Lagos, Nigeria", "images/cousant.png", "Consultant Fullstack Developer", "1", "https://cousant.com/" });

           migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "bcc34a46-6f6c-4738-99df-0d8cf0367c12", "An online marketplace for livestocks integrated with  payment gateway", "images/work4.png", "Livestock247 Web App", "http://livestockfarms.herokuapp.com/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "c28d7375-afdd-4100-81db-17d03b6c01a5", "PlentyTechJobs is the one platform for finding the best technology jobs", "images/PTJ.png", "PlentyTechJobs", "https://plentytechjobs.africa", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "aa8728e0-8a6b-4665-b41d-97d1bcb48fa0", "Omney is an application that will let users buy and sell stocks", "images/Omney.png", "Omney", "http://legendary-ay.herokuapp.com/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "570d599f-1338-4eac-a49d-a9f674eab0fa", "A Javascript application that creates random passwords", "images/work1.png", "Password Generator", "https://legendaryay.github.io/PasswordGenerator/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "04912f8b-4ff2-4190-b856-d7ffaf328b5c", "A RESTful API for managing contacts", "images/work5.png", "ContactMangerAPI", "https://github.com/LegendaryAy/ContactManagerApi", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "e66dfe61-d139-4560-9a8d-6f707fba07c0", "A simple Bank application that performs basic transactions", "images/work6.png", "LegendBank", "https://github.com/LegendaryAy/LegendBank", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "db1c463e-e021-4b3e-9af4-20968f0175b2", "An online home care system for hospice patients in the US.", "images/work7.png", "Hospice Solution", "https://www.axxess.com/hospice-software/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "e7c9cb35-7ff7-45c7-9f0f-9425e9494c0d", "A boilerplate for a travel website", "images/work2.png", "Legend Travels", "https://legendaryay.github.io/LegendTravels/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "5d094425-16d9-48dd-ae1c-cd9e19487ba9", "A boilerplate for an health blog", "images/work3.png", "Legend Health ", "https://legendaryay.github.io/LegendHealth/", "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "18861412-b69d-41b5-bb31-330e1d987f9a", "SQL", 82, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "ded796e0-668a-40c9-a11e-39280f49762d", "HTML", 100, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "4a80aecd-55c3-4221-9905-6b1bb7467d3c", "CSS", 95, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "ba82394c-c6d7-4fc4-8c1a-3502c15db292", "JavaScript", 89, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "9e6e7dfb-27c6-4e52-8e3e-b958740114c6", "C#", 90, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "d56c9e9b-2e2d-48d2-9895-7d837f634acd", "PHP", 86, "1" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "027bddf9-a860-4325-8cad-350509d50bbc", "Collaborated with product managers, business analysts, and stakeholders to gather and understand software requirements", "1" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "e4088ad9-c220-41e1-bc17-cd9f2e36fb9a", "Performed root cause analysis to understand the cause of bugs and implement appropriate fixes.", "1" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "8be1c423-3fa6-4a86-beca-922bb6eb44ad", "Worked with DevOps teams to deploy applications to various environments, automate deployment processes.", "1" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "d586c679-0e63-4535-a934-5aa5be2909d5", "Participated in the ongoing development of applications that meet the needs of our customers.", "1" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "ffdf3055-6506-4b24-9189-aaed9672e340", "Delivered new functionality and change requests for existing applications.", "1" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "82670936-8247-446c-b1b5-d438b2f0e3f6", "Used Agile Methodologies (SCRUM) while developing applications.", "2" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "3da354f1-ca46-4336-bd02-fd7de1c39cf8", "Wrote clean, efficient code based on specifications.", "2" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "5f06b11f-0850-4fed-9016-dcb4f8561cc5", "Architected and designed software systems, databases, and APIs.", "2" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "9c5286b7-75a9-4c10-bb21-a6b0ef65287b", "Responsible for integrating software components and third-party programs.", "2" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "94922087-6b20-42a3-bcdd-a0643da2f71b", "Worked with other developers and other team members to establish objectives and design more functional, cohesive codes to enhance the user experience.", "2" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "a97d4437-060d-49e2-b4ce-976ed0da4363", "Developed ideas for new programs, products, or features by monitoring industry developments and trends.", "3" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "b0e4981c-fd4e-46d0-8eff-45b5c3c94396", "Worked on projects using C#, .NET Core, EF Core, HTML, CSS, React.js, and JavaScript.", "3" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "49f4355c-8f29-4d05-914b-36da48ff24c9", "Troubleshot, debugged, and upgraded existing software to meet already established requirements.", "3" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "8e698d76-d784-428e-8556-2436870ba8be", "Performed complete testing of Web applications, units, and systems, engaging users as necessary.", "3" });

            migrationBuilder.InsertData(
                table: "ExpDescription",
                columns: new[] { "Id", "Description", "ExperienceId" },
                values: new object[] { "d1a53cda-5be8-4fc5-bddb-d59326187a61", "Developed database-driven Web interfaces for rapid, real-time information sharing.", "3" });

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_UserId",
                table: "Certifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpDescription_ExperienceId",
                table: "ExpDescription",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_UserId",
                table: "Experiences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_UserId",
                table: "Skills",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "ExpDescription");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
