using Microsoft.EntityFrameworkCore.Migrations;

namespace LegendWeb.Migrations
{
    public partial class month : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c52f3d44-c922-4506-8f54-410efa1113ce", "Lagos", "Nigeria", "2013, Adunni Oluwole Loop, Fara park 2 Estate, Lekki-Epe Expressway", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "027dd8c2-2d3a-451b-8010-83b4540474ab", "An online marketplace for livestocks integrated with  payment gateway", "images/work4.png", "Livestock247 Web App", "http://livestockfarms.herokuapp.com/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "2d5800b4-231a-4e17-8f3a-29d08de7333c", "PlentyTechJobs is the one platform for finding the best technology jobs", "images/PTJ.png", "PlentyTechJobs", "https://plentytechjobs.africa", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "94658f38-1310-4264-b6ba-880d0f9f316b", "Omney is an application that will let users buy and sell stocks", "images/Omney.png", "Omney", "http://legendary-ay.herokuapp.com/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "ff7a41ec-40bc-4e81-b58c-0d9b76e44b53", "A Javascript application that creates random passwords", "images/work1.png", "Password Generator", "https://legendaryay.github.io/PasswordGenerator/", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "8fea0763-7325-40cb-9a2d-46fff0e33a67", "A RESTful API for managing contacts", "images/work5.png", "ContactMangerAPI", "https://github.com/LegendaryAy/ContactManagerApi", "1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Body", "ImageUrl", "Name", "Url", "UserId" },
                values: new object[] { "5e859116-1d1c-4917-8b3e-ac3c1aa60abe", "A simple Bank application that performs basic transactions", "images/work6.png", "LegendBank", "https://github.com/LegendaryAy/LegendBank", "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "e97aa8be-5b87-41bb-9355-f2efdb24be6f", "HTML", 100, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "76c348dd-fc61-4984-b967-a21f55db0c27", "CSS", 95, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "18f6fcfb-82e2-4cd5-b9b3-5c47f64b4487", "JavaScript", 89, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "dee9bf4c-db2a-440a-bdab-d9da29424ff1", "C#", 90, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "4097e361-7391-4d40-8152-a9616332e3da", "SQL", 82, "1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name", "Progress", "UserId" },
                values: new object[] { "df3c3ed9-f4d8-4cfd-843c-b99eca5b9450", "PHP", 86, "1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1",
                column: "DateOfBirth",
                value: "17th of September");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "c52f3d44-c922-4506-8f54-410efa1113ce");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "027dd8c2-2d3a-451b-8010-83b4540474ab");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "2d5800b4-231a-4e17-8f3a-29d08de7333c");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "5e859116-1d1c-4917-8b3e-ac3c1aa60abe");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "8fea0763-7325-40cb-9a2d-46fff0e33a67");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "94658f38-1310-4264-b6ba-880d0f9f316b");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "ff7a41ec-40bc-4e81-b58c-0d9b76e44b53");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "18f6fcfb-82e2-4cd5-b9b3-5c47f64b4487");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "4097e361-7391-4d40-8152-a9616332e3da");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "76c348dd-fc61-4984-b967-a21f55db0c27");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "dee9bf4c-db2a-440a-bdab-d9da29424ff1");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "df3c3ed9-f4d8-4cfd-843c-b99eca5b9450");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: "e97aa8be-5b87-41bb-9355-f2efdb24be6f");

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

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1",
                column: "DateOfBirth",
                value: "17th of Semptember");
        }
    }
}
