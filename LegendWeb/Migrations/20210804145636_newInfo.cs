using Microsoft.EntityFrameworkCore.Migrations;

namespace LegendWeb.Migrations
{
    public partial class newInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "d3e5a945-914d-4251-ae90-707565f97d47");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "250f6963-f7d1-41b5-8ca3-50c6f4754a7e");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "2d3b6d09-e2df-4633-8bfb-29aca7e7e0cb");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "9ef02947-1be6-40ff-845c-fba23eaa2112");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "a6e7074f-567b-481b-bab7-b7605fa505bb");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "bbe7b8e3-fd82-43a1-8a34-309fad4355f4");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "edc9327f-56ed-4d58-a17d-db0a2aed8d48");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "2afc471c-f52a-49b9-9e4f-7e5e65f615be");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "377c13d5-bf69-4d6c-86a0-eb2e7eaaeb01");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "523f628d-3bd9-4102-89d3-ac7745106ec5");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "66afcc85-e5e4-4014-a5e9-583a3e2e1b42");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "986fe43a-b391-4bc3-b6ce-37863f04d573");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "99849d36-cd53-4af8-b462-04a993968422");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "UserId" },
                values: new object[] { "babfb1b6-f78e-4dbc-bc5a-6de300a920e2", "Lagos", "Nigeria", "No 8, Alaba Obe Street, Off Ajuwon Road", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "2b84f9af-806b-4732-823a-d5484e2da24e", "An online marketplace for livestocks integrated with  payment gateway", "images/work4.png", "Livestock247 Web App", "http://livestockfarms.herokuapp.com/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "40323260-0263-4266-9447-eef25dbbc534", "A Travel website template showing different cities and means to travel", "images/work2.png", "LegendTravels", "https://legendaryay.github.io/LegendTravels/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "2727f2ea-147c-4b7d-8004-7375e4893a82", "An Health website template showing different means of achieving good health", "images/work3.png", "LegendHealth", "https://legendaryay.github.io/LegendHealth/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "def32c62-8238-4e58-bce5-ff695a5ebbaf", "A Javascript application that creates random passwords", "images/work1.png", "Password Generator", "https://legendaryay.github.io/PasswordGenerator/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "38ca6ddb-b00a-4a46-8b09-06d153d65d6f", "A RESTful API for managing contacts", "images/work5.png", "ContactMangerAPI", "https://github.com/LegendaryAy/ContactManagerApi", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "7ebe93f6-2ab5-411f-90ff-9cc4a1bc2d11", "A simple Bank application that perorms basic transactions", "images/work6.png", "LegendBank", "https://github.com/LegendaryAy/LegendBank", "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "d8315fb2-929e-40cc-bc26-bebec0e1ce0d", "HTML", 100, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "cf1023b4-a416-476c-829a-d16e6f5984e7", "CSS", 95, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "33bf4816-cf26-4caf-aa01-f806425ecd4c", "JavaScript", 89, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "f7c8d07e-b82f-4c4e-b068-7209b6e7ae40", "C#", 90, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "e6a4e70b-6dba-46ce-b3cb-f72474a7e3b9", "SQL", 82, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "8390c033-5851-4a25-b6ca-3d22a0c14174", "PHP", 86, "1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Bio", "JobTitle" },
                values: new object[] { "With experience in developing scalable applications, I am highly proficient and committed to building innovative software applications. I’m in tune with the latest technological trends and I use them to build efficient software applications.", "Fullstack Software Engineer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "babfb1b6-f78e-4dbc-bc5a-6de300a920e2");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "2727f2ea-147c-4b7d-8004-7375e4893a82");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "2b84f9af-806b-4732-823a-d5484e2da24e");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "38ca6ddb-b00a-4a46-8b09-06d153d65d6f");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "40323260-0263-4266-9447-eef25dbbc534");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "7ebe93f6-2ab5-411f-90ff-9cc4a1bc2d11");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "def32c62-8238-4e58-bce5-ff695a5ebbaf");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "33bf4816-cf26-4caf-aa01-f806425ecd4c");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "8390c033-5851-4a25-b6ca-3d22a0c14174");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "cf1023b4-a416-476c-829a-d16e6f5984e7");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "d8315fb2-929e-40cc-bc26-bebec0e1ce0d");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "e6a4e70b-6dba-46ce-b3cb-f72474a7e3b9");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "f7c8d07e-b82f-4c4e-b068-7209b6e7ae40");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Street", "UserId" },
                values: new object[] { "d3e5a945-914d-4251-ae90-707565f97d47", "Lagos", "Nigeria", "No 8, Alaba Obe Street, Off Ajuwon Road", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "2d3b6d09-e2df-4633-8bfb-29aca7e7e0cb", "A Javascript application that creates random passwords", "images/work1.png", "Password Generator", "https://legendaryay.github.io/PasswordGenerator/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "bbe7b8e3-fd82-43a1-8a34-309fad4355f4", "A Travel website template showing different cities and means to travel", "images/work2.png", "LegendTravels", "https://legendaryay.github.io/LegendTravels/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "a6e7074f-567b-481b-bab7-b7605fa505bb", "An Health website template showing different means of achieving good health", "images/work3.png", "LegendHealth", "https://legendaryay.github.io/LegendHealth/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "9ef02947-1be6-40ff-845c-fba23eaa2112", "A template showing different designs created by the owner", "images/work4.png", "LegendDesign", "https://legendaryay.github.io/LegendDesign/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "edc9327f-56ed-4d58-a17d-db0a2aed8d48", "A RESTful API for managing contacts", "images/work5.png", "ContactMangerAPI", "https://github.com/LegendaryAy/ContactManagerApi", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "250f6963-f7d1-41b5-8ca3-50c6f4754a7e", "A simple Bank application that perorms basic transactions", "images/work6.png", "LegendBank", "https://github.com/LegendaryAy/LegendBank", "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "66afcc85-e5e4-4014-a5e9-583a3e2e1b42", "HTML", 100, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "986fe43a-b391-4bc3-b6ce-37863f04d573", "CSS", 95, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "377c13d5-bf69-4d6c-86a0-eb2e7eaaeb01", "JavaScript", 89, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "2afc471c-f52a-49b9-9e4f-7e5e65f615be", "C#", 90, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "523f628d-3bd9-4102-89d3-ac7745106ec5", "SQL", 82, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "99849d36-cd53-4af8-b462-04a993968422", "PHP", 86, "1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Bio", "JobTitle" },
                values: new object[] { "Experienced Software Developer adept in bringing forth expertise in design, installation, testing and maintenance of software systems. Equipped with a diverse and promising skill-set. Proficient in various platforms, languages, and embedded systems. Experienced with the latest cutting edge development tools and procedures. Able to effectively self-manage during independent projects, as well as collaborate as part of a productive team.", "Intermediate Software Engineer" });
        }
    }
}
