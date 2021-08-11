using Microsoft.EntityFrameworkCore.Migrations;

namespace LegendWeb.Migrations
{
    public partial class spelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "0aecf5a5-a11d-4dab-b080-123ce7c1a51c");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "08230bb6-3dbd-428b-9d52-e206d282c57f");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "1a412695-b0a3-4fa4-a10d-59a82ce45c50");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "759cd101-fdbe-4cc7-812b-92311f4733e5");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "b392e18a-65a5-4a1e-866e-00993fb672b7");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "d078639e-066f-45ab-97c6-ddbdf97235de");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "f278fd68-ee21-476d-a803-f22e4564e98b");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "2d199bab-6ab6-4031-8d17-99e51ce5fae2");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "4a922068-1ada-44f7-b780-6716505e825b");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "8884e871-3508-450a-be83-228492c69771");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "892c3658-834e-43a2-9b1d-c82e47327c06");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "c11407fc-ebb7-465d-acf1-4ab3d9a4fefb");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "cb67d6f8-c6f3-4658-87d9-1e09e2a68a88");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0aecf5a5-a11d-4dab-b080-123ce7c1a51c", "Lagos", "Nigeria", "No 8, Alaba Obe Street, Off Ajuwon Road", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "759cd101-fdbe-4cc7-812b-92311f4733e5", "An online marketplace for livestocks integrated with  payment gateway", "images/work4.png", "Livestock247 Web App", "http://livestockfarms.herokuapp.com/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "1a412695-b0a3-4fa4-a10d-59a82ce45c50", "A Travel website template showing different cities and means to travel", "images/work2.png", "LegendTravels", "https://legendaryay.github.io/LegendTravels/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "f278fd68-ee21-476d-a803-f22e4564e98b", "An Health website template showing different means of achieving good health", "images/work3.png", "LegendHealth", "https://legendaryay.github.io/LegendHealth/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "d078639e-066f-45ab-97c6-ddbdf97235de", "A Javascript application that creates random passwords", "images/work1.png", "Password Generator", "https://legendaryay.github.io/PasswordGenerator/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "08230bb6-3dbd-428b-9d52-e206d282c57f", "A RESTful API for managing contacts", "images/work5.png", "ContactMangerAPI", "https://github.com/LegendaryAy/ContactManagerApi", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "b392e18a-65a5-4a1e-866e-00993fb672b7", "A simple Bank application that perorms basic transactions", "images/work6.png", "LegendBank", "https://github.com/LegendaryAy/LegendBank", "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "c11407fc-ebb7-465d-acf1-4ab3d9a4fefb", "HTML", 100, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "892c3658-834e-43a2-9b1d-c82e47327c06", "CSS", 95, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "2d199bab-6ab6-4031-8d17-99e51ce5fae2", "JavaScript", 89, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "8884e871-3508-450a-be83-228492c69771", "C#", 90, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "cb67d6f8-c6f3-4658-87d9-1e09e2a68a88", "SQL", 82, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "4a922068-1ada-44f7-b780-6716505e825b", "PHP", 86, "1" });
        }
    }
}
