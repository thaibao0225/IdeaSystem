using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaSystem.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4c50852c-87ea-45a0-a143-bcb31a7b968b", true, "Category2" },
                    { "5886bb81-5ad9-4428-a427-c0518d27dc23", true, "Category1" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "33c54d6f-e316-422d-8522-fff1df97209f", true, "NameDepartment1" },
                    { "9eb15111-d6de-4f16-92ed-d791c12c4342", true, "NameDepartment3" },
                    { "d14184d9-64bd-4835-92da-c590b097b134", true, "NameDepartment2" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "23628387-4AD3-4A03-993B-1ECF0F030CB3",
                column: "ConcurrencyStamp",
                value: "86242ca0-5c70-4954-a500-a274e13af4aa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8B6B7FA7-220D-427F-AF15-57DE6EF686C6",
                column: "ConcurrencyStamp",
                value: "7a6bd1d2-264f-43d3-8874-8d6b3770ea1f");

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "topic_Id", "topic_ClosureDate", "topic_FinalClosureDate", "topic_Name" },
                values: new object[,]
                {
                    { "18cb6f25-2ebf-452e-aae7-c69df1431d3e", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 1" },
                    { "a1ffc92e-e00c-4f1a-b2c1-8380bbd04f7a", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 2" },
                    { "b3f37bbd-0a0d-4bbb-8649-8ac4726e0be1", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 4" },
                    { "d54fdee1-ddbf-4d14-a350-a48fea6cbb23", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 5" },
                    { "e11f4250-0178-4c39-8a43-6edbe9747635", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 3" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "0edcca19-5e0f-4f68-9bf6-515fcdd71617", 0, "0f411073-a6cd-45d4-88a9-f24d53dc68de", "User", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDusEi5fOXts5mvqWUVTXV4e2ujswcFqnyizdGkOi5brEC5PP2W1+lAboIQA3HQoRQ==", null, false, "1f0b9f05-7ddf-4f31-8063-6ae5ae8564f9", false, "Admin", "33c54d6f-e316-422d-8522-fff1df97209f" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "1a463cb6-c9bb-4269-a90c-b3e74edc3ed7", 0, "1652fc14-29e6-4964-b0fb-0795e4b881d5", "User", "staff@gmail.com", true, false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAENDSKFpPGoXf1icvoXqui0NRVAWogPdrkFhuWqju7anOpZNdaTc36S703zxEayHf4g==", null, false, "7783a78d-d3a1-4c19-b2db-714bca490599", false, "Staff", "d14184d9-64bd-4835-92da-c590b097b134" });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_CategoryId", "idea_DateTime", "idea_FilePath", "idea_IsDelete", "idea_Text", "idea_Topic", "idea_UserId" },
                values: new object[,]
                {
                    { "4f371d07-81eb-463f-bc90-2a4aefe40de4", "5886bb81-5ad9-4428-a427-c0518d27dc23", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath1", true, "Idea 1", "18cb6f25-2ebf-452e-aae7-c69df1431d3e", "1a463cb6-c9bb-4269-a90c-b3e74edc3ed7" },
                    { "674ac24f-7334-4f04-961c-7ec2aeb8b8ee", "4c50852c-87ea-45a0-a143-bcb31a7b968b", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath2", true, "Idea 2", "a1ffc92e-e00c-4f1a-b2c1-8380bbd04f7a", "1a463cb6-c9bb-4269-a90c-b3e74edc3ed7" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "0edcca19-5e0f-4f68-9bf6-515fcdd71617" },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "1a463cb6-c9bb-4269-a90c-b3e74edc3ed7" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "cmt_Id", "cmt_Datetime", "cmt_IdeaId", "cmt_IsDelete", "cmt_Text", "cmt_UserId" },
                values: new object[] { "039a2b32-c268-4d52-9621-3544a62171f5", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f371d07-81eb-463f-bc90-2a4aefe40de4", true, "Commnet 1", "1a463cb6-c9bb-4269-a90c-b3e74edc3ed7" });

            migrationBuilder.InsertData(
                table: "React",
                columns: new[] { "react_Id", "react_IdeadId", "react_React", "react_UserId" },
                values: new object[,]
                {
                    { "93d300dc-0785-4c3d-8ba7-0fdec4a7b002", "4f371d07-81eb-463f-bc90-2a4aefe40de4", -1, "0edcca19-5e0f-4f68-9bf6-515fcdd71617" },
                    { "c16e1275-7286-45e2-9c1a-5979e09495fb", "4f371d07-81eb-463f-bc90-2a4aefe40de4", -1, "1a463cb6-c9bb-4269-a90c-b3e74edc3ed7" }
                });

            migrationBuilder.InsertData(
                table: "View",
                columns: new[] { "view_Id", "view_IdeadId", "view_UserId", "view_VisitTime" },
                values: new object[] { "638050f6-69e1-417b-9b1b-019f53260a1f", "4f371d07-81eb-463f-bc90-2a4aefe40de4", "1a463cb6-c9bb-4269-a90c-b3e74edc3ed7", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "cmt_Id",
                keyValue: "039a2b32-c268-4d52-9621-3544a62171f5");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "9eb15111-d6de-4f16-92ed-d791c12c4342");

            migrationBuilder.DeleteData(
                table: "Idea",
                keyColumn: "idea_Id",
                keyValue: "674ac24f-7334-4f04-961c-7ec2aeb8b8ee");

            migrationBuilder.DeleteData(
                table: "React",
                keyColumn: "react_Id",
                keyValue: "93d300dc-0785-4c3d-8ba7-0fdec4a7b002");

            migrationBuilder.DeleteData(
                table: "React",
                keyColumn: "react_Id",
                keyValue: "c16e1275-7286-45e2-9c1a-5979e09495fb");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "b3f37bbd-0a0d-4bbb-8649-8ac4726e0be1");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "d54fdee1-ddbf-4d14-a350-a48fea6cbb23");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "e11f4250-0178-4c39-8a43-6edbe9747635");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "0edcca19-5e0f-4f68-9bf6-515fcdd71617" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "1a463cb6-c9bb-4269-a90c-b3e74edc3ed7" });

            migrationBuilder.DeleteData(
                table: "View",
                keyColumn: "view_Id",
                keyValue: "638050f6-69e1-417b-9b1b-019f53260a1f");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_Id",
                keyValue: "4c50852c-87ea-45a0-a143-bcb31a7b968b");

            migrationBuilder.DeleteData(
                table: "Idea",
                keyColumn: "idea_Id",
                keyValue: "4f371d07-81eb-463f-bc90-2a4aefe40de4");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "a1ffc92e-e00c-4f1a-b2c1-8380bbd04f7a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0edcca19-5e0f-4f68-9bf6-515fcdd71617");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_Id",
                keyValue: "5886bb81-5ad9-4428-a427-c0518d27dc23");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "33c54d6f-e316-422d-8522-fff1df97209f");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "18cb6f25-2ebf-452e-aae7-c69df1431d3e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1a463cb6-c9bb-4269-a90c-b3e74edc3ed7");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "d14184d9-64bd-4835-92da-c590b097b134");

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
    }
}
