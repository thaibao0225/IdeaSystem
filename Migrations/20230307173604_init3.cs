using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaSystem.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "10bf2722-ddb1-411a-b123-1620a4335442", false, "NameDepartment2" },
                    { "4adbbc4e-1270-4643-92a6-b5547bc65cb4", false, "NameDepartment3" },
                    { "4b0d5460-35f7-4d4b-bb52-d0c235ebeec4", false, "NameDepartment1" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "23628387-4AD3-4A03-993B-1ECF0F030CB3",
                column: "ConcurrencyStamp",
                value: "78fd7cc0-3fe6-4521-ace8-b2b6f21df2a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8B6B7FA7-220D-427F-AF15-57DE6EF686C6",
                column: "ConcurrencyStamp",
                value: "d69684ea-8e69-466a-8e72-3265a31ed17a");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "4f64a673-f24d-4136-8bcc-42afb9475859", 0, "1cefe25b-57eb-4542-bcb7-6b8be902c2ad", "User", "staff@gmail.com", true, false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAED+Yh+RXLabsrN9zaELNreNGB7nwrh/1sOEOsordgjafTICnUe4lPnjKOOXq+yVDug==", null, false, "5cc64e19-0495-4dbd-9433-9e31a07c9d16", false, "Staff", "10bf2722-ddb1-411a-b123-1620a4335442" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "6c1051e9-0d4d-43f9-8852-a77d9c04f50f", 0, "8b0ac041-1cb8-4db1-b76f-66f47e931f35", "User", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEHO5FQxTp1qntvKf8s/lDg7nny1gu+EDG9ldyoH32r8d+FODDuq63FlrSRzf+oJlnQ==", null, false, "a1fc2c5e-00a6-4b9d-ad77-478a6ecb2546", false, "Admin", "4b0d5460-35f7-4d4b-bb52-d0c235ebeec4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "4adbbc4e-1270-4643-92a6-b5547bc65cb4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4f64a673-f24d-4136-8bcc-42afb9475859");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6c1051e9-0d4d-43f9-8852-a77d9c04f50f");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "10bf2722-ddb1-411a-b123-1620a4335442");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "4b0d5460-35f7-4d4b-bb52-d0c235ebeec4");

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "132c67f1-5969-422a-91db-192e00e7b048", false, "NameDepartment1" },
                    { "245f76a9-4c27-436f-921d-ebd6767c3215", false, "NameDepartment2" },
                    { "75de1a73-3329-4b6f-819f-03721ad3cd8c", false, "NameDepartment3" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "23628387-4AD3-4A03-993B-1ECF0F030CB3",
                column: "ConcurrencyStamp",
                value: "f830419c-ff71-477a-888b-f4f490041bda");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8B6B7FA7-220D-427F-AF15-57DE6EF686C6",
                column: "ConcurrencyStamp",
                value: "287cc878-9e35-4f9a-b5c2-438dcadde7a5");
        }
    }
}
