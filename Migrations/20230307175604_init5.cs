using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaSystem.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "topic_FinalClosureDate",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "topic_ClosureDate",
                table: "Topic",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "category_Id", "category_IsDelete", "category_Name" },
                values: new object[,]
                {
                    { "1517fbd7-bcd0-482a-9530-27f55cc1b92f", false, "Category1" },
                    { "3b0a0df4-caf5-4b37-a5cc-a7b9a5688474", false, "Category2" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "207d1d69-b06f-42b3-8d37-89acfe84ec8a", false, "NameDepartment2" },
                    { "b79239ed-cac0-4c0c-99a0-def208dce3d5", false, "NameDepartment3" },
                    { "e6d6ff53-4745-4287-846a-afcff6d07a1f", false, "NameDepartment1" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "23628387-4AD3-4A03-993B-1ECF0F030CB3",
                column: "ConcurrencyStamp",
                value: "66834544-943a-467a-bdad-35d6326801f7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8B6B7FA7-220D-427F-AF15-57DE6EF686C6",
                column: "ConcurrencyStamp",
                value: "3d0f03b1-52a0-4eb7-bf0c-32f4bf58b477");

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "topic_Id", "topic_ClosureDate", "topic_FinalClosureDate", "topic_Name" },
                values: new object[,]
                {
                    { "08c040e9-7005-4442-976f-33e7746ac665", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 5" },
                    { "12ca5889-89c3-4af3-927e-06adf6c0ffc9", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 3" },
                    { "5ca1b082-080b-4158-8ff2-fa1efbace2b2", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 2" },
                    { "80f80a32-c75b-4ac5-a274-96fd4c8d0ba7", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 4" },
                    { "c51d9e53-f331-45bf-9608-01d987523597", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "1fb233ba-0a18-4c50-b3d9-e90ae977cf68", 0, "9644f9bf-6838-4122-902d-3dfed28daf6e", "User", "staff@gmail.com", true, false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEEh0vBwct7wQ9Fr3icOkY1J6c7nnkduV0C6yV/5TAtcosDRtJ74mm/DXkc4tsq7mrA==", null, false, "c029e2c5-6737-4b30-bc47-26f69020454a", false, "Staff", "207d1d69-b06f-42b3-8d37-89acfe84ec8a" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "93b7aead-3a2e-424e-b818-21879e1af16d", 0, "80e9c77e-18d1-43c4-b411-e158489581c0", "User", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPmtNtMNrrjKncQD5lb84fADGkh49bUVWtE4+3vtnEv9qf0Acs1UjtNDpZKSskPSFQ==", null, false, "4a034f13-4cb5-4ca8-89cc-befb4eb8d4a7", false, "Admin", "e6d6ff53-4745-4287-846a-afcff6d07a1f" });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_CategoryId", "idea_DateTime", "idea_FilePath", "idea_IsDelete", "idea_Text", "idea_Topic", "idea_UserId" },
                values: new object[,]
                {
                    { "62a01ed3-b03b-4179-9914-304efb7bd83f", "3b0a0df4-caf5-4b37-a5cc-a7b9a5688474", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath2", false, "Idea 2", "5ca1b082-080b-4158-8ff2-fa1efbace2b2", "1fb233ba-0a18-4c50-b3d9-e90ae977cf68" },
                    { "a11b3476-3f6d-41ab-940b-83b9aa3dce50", "1517fbd7-bcd0-482a-9530-27f55cc1b92f", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath1", false, "Idea 1", "c51d9e53-f331-45bf-9608-01d987523597", "1fb233ba-0a18-4c50-b3d9-e90ae977cf68" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "1fb233ba-0a18-4c50-b3d9-e90ae977cf68" },
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "93b7aead-3a2e-424e-b818-21879e1af16d" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "cmt_Id", "cmt_Datetime", "cmt_IdeaId", "cmt_IsDelete", "cmt_Text", "cmt_UserId" },
                values: new object[] { "77c95485-f253-46c8-b3a4-9f834227e7c3", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "a11b3476-3f6d-41ab-940b-83b9aa3dce50", false, "Commnet 1", "1fb233ba-0a18-4c50-b3d9-e90ae977cf68" });

            migrationBuilder.InsertData(
                table: "React",
                columns: new[] { "react_Id", "react_IdeadId", "react_React", "react_UserId" },
                values: new object[] { "2e9ffc00-7e12-4551-b16a-dfbeca7ff019", "a11b3476-3f6d-41ab-940b-83b9aa3dce50", -1, "93b7aead-3a2e-424e-b818-21879e1af16d" });

            migrationBuilder.InsertData(
                table: "React",
                columns: new[] { "react_Id", "react_IdeadId", "react_React", "react_UserId" },
                values: new object[] { "48b516ed-ede1-45bc-9088-d9ae430029e5", "a11b3476-3f6d-41ab-940b-83b9aa3dce50", -1, "1fb233ba-0a18-4c50-b3d9-e90ae977cf68" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "cmt_Id",
                keyValue: "77c95485-f253-46c8-b3a4-9f834227e7c3");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "b79239ed-cac0-4c0c-99a0-def208dce3d5");

            migrationBuilder.DeleteData(
                table: "Idea",
                keyColumn: "idea_Id",
                keyValue: "62a01ed3-b03b-4179-9914-304efb7bd83f");

            migrationBuilder.DeleteData(
                table: "React",
                keyColumn: "react_Id",
                keyValue: "2e9ffc00-7e12-4551-b16a-dfbeca7ff019");

            migrationBuilder.DeleteData(
                table: "React",
                keyColumn: "react_Id",
                keyValue: "48b516ed-ede1-45bc-9088-d9ae430029e5");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "08c040e9-7005-4442-976f-33e7746ac665");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "12ca5889-89c3-4af3-927e-06adf6c0ffc9");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "80f80a32-c75b-4ac5-a274-96fd4c8d0ba7");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "1fb233ba-0a18-4c50-b3d9-e90ae977cf68" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "93b7aead-3a2e-424e-b818-21879e1af16d" });

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_Id",
                keyValue: "3b0a0df4-caf5-4b37-a5cc-a7b9a5688474");

            migrationBuilder.DeleteData(
                table: "Idea",
                keyColumn: "idea_Id",
                keyValue: "a11b3476-3f6d-41ab-940b-83b9aa3dce50");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "5ca1b082-080b-4158-8ff2-fa1efbace2b2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "93b7aead-3a2e-424e-b818-21879e1af16d");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_Id",
                keyValue: "1517fbd7-bcd0-482a-9530-27f55cc1b92f");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "e6d6ff53-4745-4287-846a-afcff6d07a1f");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "c51d9e53-f331-45bf-9608-01d987523597");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1fb233ba-0a18-4c50-b3d9-e90ae977cf68");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "207d1d69-b06f-42b3-8d37-89acfe84ec8a");

            migrationBuilder.AlterColumn<string>(
                name: "topic_FinalClosureDate",
                table: "Topic",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "topic_ClosureDate",
                table: "Topic",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
    }
}
