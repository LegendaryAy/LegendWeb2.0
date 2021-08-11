using Microsoft.EntityFrameworkCore.Migrations;

namespace LegendWeb.Migrations
{
    public partial class date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1",
                column: "DateOfBirth",
                value: "17th of Semptember");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "DateOfBirth",
                value: "17 September, 1998");
        }
    }
}
