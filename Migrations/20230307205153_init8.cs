using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaSystem.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4f50fc7d-7abe-4b51-b4dd-c143fcab0c18", true, "Category1" },
                    { "9231d6ee-8368-4991-8f6b-4e3dbeee2034", true, "Category2" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "25ebab45-fd0a-4eef-aa1e-2b5ab10e665a", true, "NameDepartment2" },
                    { "901c5830-b54b-4408-a7d9-cb9ba0eeb6db", true, "NameDepartment3" },
                    { "b56bdddd-ec73-4032-bcd3-7fb78e0d3c46", true, "NameDepartment1" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "23628387-4AD3-4A03-993B-1ECF0F030CB3",
                columns: new[] { "ConcurrencyStamp", "role_IsDelete" },
                values: new object[] { "82212ca5-651f-4603-8e1e-92a62ee7aca3", true });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8B6B7FA7-220D-427F-AF15-57DE6EF686C6",
                columns: new[] { "ConcurrencyStamp", "role_IsDelete" },
                values: new object[] { "c09051d2-9cf7-4efc-86c2-9fffa8b1e2a0", true });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "topic_Id", "topic_ClosureDate", "topic_FinalClosureDate", "topic_Name" },
                values: new object[,]
                {
                    { "22398ed7-c193-40f4-a1fc-4d0ee3471e2c", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 5" },
                    { "5153481a-b8b4-40a4-9b59-106ca4dcfe55", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 2" },
                    { "ae188c38-e882-4cf1-a7d8-cbc432132f6f", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 4" },
                    { "d9cd8a8a-1ce6-4d64-b888-3fe42e772e6c", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 3" },
                    { "e99210df-cc76-4392-ba00-735e050a335f", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Topic 1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "18ffe056-3351-4211-b9f2-d4bbca1cd2e6", 0, "481d9094-e961-43ff-85ca-4fe64ef2dbb0", "User", "staff@gmail.com", true, false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEG4T2VwzP4osiBn+h4Lgd5m394X/UK8egZbSmKATpGxnYjbNmzmtoMYnHp9AL7aDsw==", null, false, "1d52d1e8-f27d-4aaf-87ee-f3821a194286", false, "Staff", "25ebab45-fd0a-4eef-aa1e-2b5ab10e665a" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "c63325a5-52b0-4624-a823-41e5c097cedd", 0, "99c69a19-5cf3-4d6d-a1af-f40ec2e7f174", "User", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECvJ8jP0UdpblA/W1pCVS7oUH95D5Y3GxQiO2BNzkoV2cTvhygbaQjQkP9FLgXAj1Q==", null, false, "9e39c4ec-c27d-422a-a69b-c84e8756af0a", false, "Admin", "b56bdddd-ec73-4032-bcd3-7fb78e0d3c46" });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_CategoryId", "idea_DateTime", "idea_FilePath", "idea_IsDelete", "idea_Text", "idea_Topic", "idea_UserId" },
                values: new object[,]
                {
                    { "9708c206-ab1d-49f2-8931-b5e919d3e113", "9231d6ee-8368-4991-8f6b-4e3dbeee2034", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath2", true, "Idea 2", "5153481a-b8b4-40a4-9b59-106ca4dcfe55", "18ffe056-3351-4211-b9f2-d4bbca1cd2e6" },
                    { "d9c9a0fd-bdb1-4ba0-a799-3df11083d7bd", "4f50fc7d-7abe-4b51-b4dd-c143fcab0c18", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath1", true, "Idea 1", "e99210df-cc76-4392-ba00-735e050a335f", "18ffe056-3351-4211-b9f2-d4bbca1cd2e6" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "18ffe056-3351-4211-b9f2-d4bbca1cd2e6" },
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "c63325a5-52b0-4624-a823-41e5c097cedd" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "cmt_Id", "cmt_Datetime", "cmt_IdeaId", "cmt_IsDelete", "cmt_Text", "cmt_UserId" },
                values: new object[] { "c94ecdb6-63b8-4770-9cc0-f9486356419a", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "d9c9a0fd-bdb1-4ba0-a799-3df11083d7bd", true, "Commnet 1", "18ffe056-3351-4211-b9f2-d4bbca1cd2e6" });

            migrationBuilder.InsertData(
                table: "React",
                columns: new[] { "react_Id", "react_IdeadId", "react_React", "react_UserId" },
                values: new object[,]
                {
                    { "513ff376-8673-476c-9239-7aa1f4cc8701", "d9c9a0fd-bdb1-4ba0-a799-3df11083d7bd", -1, "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "f6545af0-e83d-4473-95af-1592c7db7470", "d9c9a0fd-bdb1-4ba0-a799-3df11083d7bd", -1, "18ffe056-3351-4211-b9f2-d4bbca1cd2e6" }
                });

            migrationBuilder.InsertData(
                table: "View",
                columns: new[] { "view_Id", "view_IdeadId", "view_UserId", "view_VisitTime" },
                values: new object[] { "fa51724d-a4d6-405c-8c51-f4b2a9bba861", "d9c9a0fd-bdb1-4ba0-a799-3df11083d7bd", "18ffe056-3351-4211-b9f2-d4bbca1cd2e6", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "cmt_Id",
                keyValue: "c94ecdb6-63b8-4770-9cc0-f9486356419a");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "901c5830-b54b-4408-a7d9-cb9ba0eeb6db");

            migrationBuilder.DeleteData(
                table: "Idea",
                keyColumn: "idea_Id",
                keyValue: "9708c206-ab1d-49f2-8931-b5e919d3e113");

            migrationBuilder.DeleteData(
                table: "React",
                keyColumn: "react_Id",
                keyValue: "513ff376-8673-476c-9239-7aa1f4cc8701");

            migrationBuilder.DeleteData(
                table: "React",
                keyColumn: "react_Id",
                keyValue: "f6545af0-e83d-4473-95af-1592c7db7470");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "22398ed7-c193-40f4-a1fc-4d0ee3471e2c");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "ae188c38-e882-4cf1-a7d8-cbc432132f6f");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "d9cd8a8a-1ce6-4d64-b888-3fe42e772e6c");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "18ffe056-3351-4211-b9f2-d4bbca1cd2e6" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "c63325a5-52b0-4624-a823-41e5c097cedd" });

            migrationBuilder.DeleteData(
                table: "View",
                keyColumn: "view_Id",
                keyValue: "fa51724d-a4d6-405c-8c51-f4b2a9bba861");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_Id",
                keyValue: "9231d6ee-8368-4991-8f6b-4e3dbeee2034");

            migrationBuilder.DeleteData(
                table: "Idea",
                keyColumn: "idea_Id",
                keyValue: "d9c9a0fd-bdb1-4ba0-a799-3df11083d7bd");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "5153481a-b8b4-40a4-9b59-106ca4dcfe55");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c63325a5-52b0-4624-a823-41e5c097cedd");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_Id",
                keyValue: "4f50fc7d-7abe-4b51-b4dd-c143fcab0c18");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "b56bdddd-ec73-4032-bcd3-7fb78e0d3c46");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "e99210df-cc76-4392-ba00-735e050a335f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18ffe056-3351-4211-b9f2-d4bbca1cd2e6");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "25ebab45-fd0a-4eef-aa1e-2b5ab10e665a");

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
                columns: new[] { "ConcurrencyStamp", "role_IsDelete" },
                values: new object[] { "86242ca0-5c70-4954-a500-a274e13af4aa", false });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8B6B7FA7-220D-427F-AF15-57DE6EF686C6",
                columns: new[] { "ConcurrencyStamp", "role_IsDelete" },
                values: new object[] { "7a6bd1d2-264f-43d3-8874-8d6b3770ea1f", false });

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
    }
}
