using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaSystem.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "512558f3-c0b2-497c-a84b-d6a7824e6f81");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "575b6255-2c12-4d54-ab28-999a9079ea50");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "65a0425b-f1f4-4a0a-b830-d08991abcfc7");

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "132c67f1-5969-422a-91db-192e00e7b048", false, "NameDepartment1" },
                    { "245f76a9-4c27-436f-921d-ebd6767c3215", false, "NameDepartment2" },
                    { "75de1a73-3329-4b6f-819f-03721ad3cd8c", false, "NameDepartment3" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "role_IsDelete" },
                values: new object[,]
                {
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "f830419c-ff71-477a-888b-f4f490041bda", "Role", "Admin", "admin", false },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "287cc878-9e35-4f9a-b5c2-438dcadde7a5", "Role", "Staff", "staff", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "132c67f1-5969-422a-91db-192e00e7b048");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "245f76a9-4c27-436f-921d-ebd6767c3215");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "75de1a73-3329-4b6f-819f-03721ad3cd8c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "23628387-4AD3-4A03-993B-1ECF0F030CB3");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8B6B7FA7-220D-427F-AF15-57DE6EF686C6");

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[] { "512558f3-c0b2-497c-a84b-d6a7824e6f81", false, "NameDepartment2" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[] { "575b6255-2c12-4d54-ab28-999a9079ea50", false, "NameDepartment1" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[] { "65a0425b-f1f4-4a0a-b830-d08991abcfc7", false, "NameDepartment3" });
        }
    }
}
