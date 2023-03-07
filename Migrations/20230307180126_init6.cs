using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaSystem.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "category_Id", "category_IsDelete", "category_Name" },
                values: new object[,]
                {
                    { "0eb50f0e-4f5a-46bb-96ff-2182928508db", false, "Category2" },
                    { "24601c80-507a-41a2-8a30-21e956d0cedb", false, "Category1" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "6037198a-2fc2-4255-b882-6b1a01c7c928", false, "NameDepartment1" },
                    { "85052a09-fd42-42be-a0a2-d9d72c7d5b89", false, "NameDepartment2" },
                    { "e1bcc32f-486d-4eb5-b6a3-05b3aeede9e4", false, "NameDepartment3" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "23628387-4AD3-4A03-993B-1ECF0F030CB3",
                column: "ConcurrencyStamp",
                value: "cc1aac2a-4b60-4026-8f64-0cdee195c117");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8B6B7FA7-220D-427F-AF15-57DE6EF686C6",
                column: "ConcurrencyStamp",
                value: "52eca7cc-4245-4452-a818-546ff686a96a");

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "topic_Id", "topic_ClosureDate", "topic_FinalClosureDate", "topic_Name" },
                values: new object[,]
                {
                    { "2f210ee7-9eff-4ba3-994e-7cce07ab83d5", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 2" },
                    { "9869f7d3-cc67-4340-9a7f-c314a685351c", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 3" },
                    { "a46c556e-73d7-47f9-bebf-3551751e6997", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 5" },
                    { "bc14e881-3d37-4ddf-8481-b6200f16aa2b", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 1" },
                    { "fe93a5c4-b14a-465f-96e9-fbfbf107c91a", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 4" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "6ef05398-5127-4a49-bc9c-1b16c2268d94", 0, "d888f432-975d-4661-ac05-599d8f330e86", "User", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBG9dhz524+ymYtIAzo7ycovbd710yRbtK3D6q3TkzvA5EppYSduARXA1kQdw/k4HQ==", null, false, "218c5721-34e4-48eb-805a-d2159458c4ca", false, "Admin", "6037198a-2fc2-4255-b882-6b1a01c7c928" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "a2ec58db-6e2a-46e9-9276-980acb59ac70", 0, "a4f5ab36-40bb-40b1-abaf-498abaf2efa7", "User", "staff@gmail.com", true, false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEE2QOqbPcmNyoYD2xh/fVEX8sLKZA6AIFlucjN/9BpYZjijPNnREf7UL3kRL6jOlvg==", null, false, "ce8e6af8-2c84-468a-9ed9-5ddbf2ce1a7c", false, "Staff", "85052a09-fd42-42be-a0a2-d9d72c7d5b89" });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_CategoryId", "idea_DateTime", "idea_FilePath", "idea_IsDelete", "idea_Text", "idea_Topic", "idea_UserId" },
                values: new object[,]
                {
                    { "3926e74c-dc93-42f0-b9ac-2aa495170cf0", "24601c80-507a-41a2-8a30-21e956d0cedb", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath1", false, "Idea 1", "bc14e881-3d37-4ddf-8481-b6200f16aa2b", "a2ec58db-6e2a-46e9-9276-980acb59ac70" },
                    { "a0eb7a32-a07b-4b8f-af69-2f409c83c27d", "0eb50f0e-4f5a-46bb-96ff-2182928508db", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath2", false, "Idea 2", "2f210ee7-9eff-4ba3-994e-7cce07ab83d5", "a2ec58db-6e2a-46e9-9276-980acb59ac70" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "6ef05398-5127-4a49-bc9c-1b16c2268d94" },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "a2ec58db-6e2a-46e9-9276-980acb59ac70" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "cmt_Id", "cmt_Datetime", "cmt_IdeaId", "cmt_IsDelete", "cmt_Text", "cmt_UserId" },
                values: new object[] { "e9e319ba-78fb-4dfd-83c7-a4bd79b945e5", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "3926e74c-dc93-42f0-b9ac-2aa495170cf0", false, "Commnet 1", "a2ec58db-6e2a-46e9-9276-980acb59ac70" });

            migrationBuilder.InsertData(
                table: "React",
                columns: new[] { "react_Id", "react_IdeadId", "react_React", "react_UserId" },
                values: new object[,]
                {
                    { "3a98ffea-0e24-40c2-85f6-4a7bfe4fed3e", "3926e74c-dc93-42f0-b9ac-2aa495170cf0", -1, "6ef05398-5127-4a49-bc9c-1b16c2268d94" },
                    { "a4acfbfa-9b95-4bc4-8981-ba0f944553d8", "3926e74c-dc93-42f0-b9ac-2aa495170cf0", -1, "a2ec58db-6e2a-46e9-9276-980acb59ac70" }
                });

            migrationBuilder.InsertData(
                table: "View",
                columns: new[] { "view_Id", "view_IdeadId", "view_UserId", "view_VisitTime" },
                values: new object[] { "a931d036-28ef-415c-af29-b7eeb1eb7a9d", "3926e74c-dc93-42f0-b9ac-2aa495170cf0", "a2ec58db-6e2a-46e9-9276-980acb59ac70", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "cmt_Id",
                keyValue: "e9e319ba-78fb-4dfd-83c7-a4bd79b945e5");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "e1bcc32f-486d-4eb5-b6a3-05b3aeede9e4");

            migrationBuilder.DeleteData(
                table: "Idea",
                keyColumn: "idea_Id",
                keyValue: "a0eb7a32-a07b-4b8f-af69-2f409c83c27d");

            migrationBuilder.DeleteData(
                table: "React",
                keyColumn: "react_Id",
                keyValue: "3a98ffea-0e24-40c2-85f6-4a7bfe4fed3e");

            migrationBuilder.DeleteData(
                table: "React",
                keyColumn: "react_Id",
                keyValue: "a4acfbfa-9b95-4bc4-8981-ba0f944553d8");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "9869f7d3-cc67-4340-9a7f-c314a685351c");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "a46c556e-73d7-47f9-bebf-3551751e6997");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "fe93a5c4-b14a-465f-96e9-fbfbf107c91a");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "6ef05398-5127-4a49-bc9c-1b16c2268d94" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "a2ec58db-6e2a-46e9-9276-980acb59ac70" });

            migrationBuilder.DeleteData(
                table: "View",
                keyColumn: "view_Id",
                keyValue: "a931d036-28ef-415c-af29-b7eeb1eb7a9d");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_Id",
                keyValue: "0eb50f0e-4f5a-46bb-96ff-2182928508db");

            migrationBuilder.DeleteData(
                table: "Idea",
                keyColumn: "idea_Id",
                keyValue: "3926e74c-dc93-42f0-b9ac-2aa495170cf0");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "2f210ee7-9eff-4ba3-994e-7cce07ab83d5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6ef05398-5127-4a49-bc9c-1b16c2268d94");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_Id",
                keyValue: "24601c80-507a-41a2-8a30-21e956d0cedb");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "6037198a-2fc2-4255-b882-6b1a01c7c928");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "bc14e881-3d37-4ddf-8481-b6200f16aa2b");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a2ec58db-6e2a-46e9-9276-980acb59ac70");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "85052a09-fd42-42be-a0a2-d9d72c7d5b89");

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
    }
}
