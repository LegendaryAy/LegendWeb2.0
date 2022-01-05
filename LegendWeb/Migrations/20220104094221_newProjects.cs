using Microsoft.EntityFrameworkCore.Migrations;

namespace LegendWeb.Migrations
{
    public partial class newProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "f0c84fa6-e5dc-434e-a578-0929ac8f035b");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "0a6900f0-de93-4506-9380-fd415beb61b0");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "1722d9ae-cdab-49a0-a827-d5c705f7a2d2");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "3235f138-e4e1-4a8b-85d2-94812320c8cc");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "567a49f9-5c18-4b92-a32a-b02d4ab13753");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "767c60e4-36d5-4dfe-badf-54151221ee72");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "7dd87d3d-ba4e-4e0d-b2b5-e15eb03770cd");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "24600079-127c-4bb0-936f-55e33483714c");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "36365102-09df-4786-885d-5eaf6905ec7d");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "53f36dbc-c7bf-4e4e-825b-194c24420927");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "6b2e8c89-502d-422f-ae4e-40885aca3cb3");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "6f93a1e4-a9bc-4d7e-8bfa-7f02fa2201b2");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "fd1d8d9f-91b5-4d16-ae5c-bccb1221f6ca");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "UserId" },
                values: new object[] { "5508bc64-27f0-4521-b43c-67011c4af908", "Lagos", "Nigeria", "2013, Adunni Oluwole Loop, Fara park 2 Estate, Lekki-Epe Expressway", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "018aecf1-e52f-4339-947e-5f5c79087b78", "An online marketplace for livestocks integrated with  payment gateway", "images/work4.png", "Livestock247 Web App", "http://livestockfarms.herokuapp.com/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "0ea5bf42-9283-4454-adc6-20476564c0aa", "PlentyTechJobs is the one platform for finding the best technology jobs", "images/PTJ.png", "PlentyTechJobs", "https://plentytechjobs.africa", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "a939f9e5-14eb-44db-ac6c-d29fc501c7c3", "Omney is an application that will let users buy and sell stocks", "images/Omney.png", "Omney", "http://legendary-ay.herokuapp.com/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "b7b5f8cc-597f-4133-b2ec-8272e290c778", "A Javascript application that creates random passwords", "images/work1.png", "Password Generator", "https://legendaryay.github.io/PasswordGenerator/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "18a362e4-5da5-4e61-9bb6-ccd066d85122", "A RESTful API for managing contacts", "images/work5.png", "ContactMangerAPI", "https://github.com/LegendaryAy/ContactManagerApi", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "c82c30d2-bbfe-4ef2-8525-b2cf3175d26a", "A simple Bank application that performs basic transactions", "images/work6.png", "LegendBank", "https://github.com/LegendaryAy/LegendBank", "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "936e1ddd-3e1b-45be-9a96-fa02db9e8623", "HTML", 100, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "50bb5031-aea6-4817-925f-c48e3c14de7b", "CSS", 95, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "07a4ec83-6de6-4514-b94f-a748c6a12979", "JavaScript", 89, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "3a1cb135-deba-41f4-a463-eef04f777751", "C#", 90, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "3ae9008b-75c6-4aeb-93d6-29077ce09104", "SQL", 82, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "f21b0b1e-51c4-4afc-82e3-2713de5793b1", "PHP", 86, "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "5508bc64-27f0-4521-b43c-67011c4af908");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "018aecf1-e52f-4339-947e-5f5c79087b78");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "0ea5bf42-9283-4454-adc6-20476564c0aa");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "18a362e4-5da5-4e61-9bb6-ccd066d85122");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "a939f9e5-14eb-44db-ac6c-d29fc501c7c3");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "b7b5f8cc-597f-4133-b2ec-8272e290c778");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "c82c30d2-bbfe-4ef2-8525-b2cf3175d26a");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "07a4ec83-6de6-4514-b94f-a748c6a12979");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "3a1cb135-deba-41f4-a463-eef04f777751");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "3ae9008b-75c6-4aeb-93d6-29077ce09104");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "50bb5031-aea6-4817-925f-c48e3c14de7b");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "936e1ddd-3e1b-45be-9a96-fa02db9e8623");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "f21b0b1e-51c4-4afc-82e3-2713de5793b1");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "UserId" },
                values: new object[] { "f0c84fa6-e5dc-434e-a578-0929ac8f035b", "Lagos", "Nigeria", "No 8, Alaba Obe Street, Off Ajuwon Road", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "767c60e4-36d5-4dfe-badf-54151221ee72", "An online marketplace for livestocks integrated with  payment gateway", "images/work4.png", "Livestock247 Web App", "http://livestockfarms.herokuapp.com/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "0a6900f0-de93-4506-9380-fd415beb61b0", "A Travel website template showing different cities and means to travel", "images/work2.png", "LegendTravels", "https://legendaryay.github.io/LegendTravels/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "567a49f9-5c18-4b92-a32a-b02d4ab13753", "An Health website template showing different means of achieving good health", "images/work3.png", "LegendHealth", "https://legendaryay.github.io/LegendHealth/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "1722d9ae-cdab-49a0-a827-d5c705f7a2d2", "A Javascript application that creates random passwords", "images/work1.png", "Password Generator", "https://legendaryay.github.io/PasswordGenerator/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "3235f138-e4e1-4a8b-85d2-94812320c8cc", "A RESTful API for managing contacts", "images/work5.png", "ContactMangerAPI", "https://github.com/LegendaryAy/ContactManagerApi", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "7dd87d3d-ba4e-4e0d-b2b5-e15eb03770cd", "A simple Bank application that performs basic transactions", "images/work6.png", "LegendBank", "https://github.com/LegendaryAy/LegendBank", "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "6b2e8c89-502d-422f-ae4e-40885aca3cb3", "HTML", 100, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "36365102-09df-4786-885d-5eaf6905ec7d", "CSS", 95, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "24600079-127c-4bb0-936f-55e33483714c", "JavaScript", 89, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "53f36dbc-c7bf-4e4e-825b-194c24420927", "C#", 90, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "6f93a1e4-a9bc-4d7e-8bfa-7f02fa2201b2", "SQL", 82, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "fd1d8d9f-91b5-4d16-ae5c-bccb1221f6ca", "PHP", 86, "1" });
        }
    }
}
