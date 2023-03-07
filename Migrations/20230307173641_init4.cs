using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaSystem.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "28046077-cd72-4230-948d-ae40284d1a88", false, "NameDepartment2" },
                    { "ec6fcbc4-d5f3-49d5-aadd-b9d7b0c43365", false, "NameDepartment3" },
                    { "f499030d-7367-4ad5-881e-c66f44ab992d", false, "NameDepartment1" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "23628387-4AD3-4A03-993B-1ECF0F030CB3",
                column: "ConcurrencyStamp",
                value: "aa5fc83f-f378-4510-8b90-3d19188cbcaa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8B6B7FA7-220D-427F-AF15-57DE6EF686C6",
                column: "ConcurrencyStamp",
                value: "44dda820-c0f6-4edb-b925-f4a34cd16ed3");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "b9a50978-98e5-4de6-9027-9400c48db866", 0, "66bd6dc0-3bfe-45ca-9d0b-e838785be89a", "User", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPQRLV9VIOUZAXVHhMkN2BL8URv20dEEU+/XL6yospXochOTXsTiyFh0WNvJua7tGw==", null, false, "b771916b-9802-4715-8856-18aa341740f9", false, "Admin", "f499030d-7367-4ad5-881e-c66f44ab992d" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "bbabfcf1-29bc-4792-9b94-e5bc970fa44d", 0, "183e556d-4cc4-4fae-b246-c214dfa6b740", "User", "staff@gmail.com", true, false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEKT/Lm2AmwQS2BvykrCuR95Nhb3Di8CVXaPN5zu5Q5vRQd/jINx3/VcvrV9A+sDjGA==", null, false, "ed75c876-f573-47a0-84f8-6499093538c5", false, "Staff", "28046077-cd72-4230-948d-ae40284d1a88" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "b9a50978-98e5-4de6-9027-9400c48db866" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "bbabfcf1-29bc-4792-9b94-e5bc970fa44d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "ec6fcbc4-d5f3-49d5-aadd-b9d7b0c43365");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "b9a50978-98e5-4de6-9027-9400c48db866" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "bbabfcf1-29bc-4792-9b94-e5bc970fa44d" });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b9a50978-98e5-4de6-9027-9400c48db866");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bbabfcf1-29bc-4792-9b94-e5bc970fa44d");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "28046077-cd72-4230-948d-ae40284d1a88");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "f499030d-7367-4ad5-881e-c66f44ab992d");

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
    }
}
