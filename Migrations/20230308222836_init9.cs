using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaSystem.Migrations
{
    public partial class init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "topic_IsDelete",
                table: "Topic",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    user_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    user_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_RoleIdNew = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.user_Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "category_Id", "category_IsDelete", "category_Name" },
                values: new object[,]
                {
                    { "101f2802-02b6-4b83-a3ac-82d2f38945e0", false, "Category2" },
                    { "eae52257-c261-4130-a9d3-e843ad735f1d", false, "Category1" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "3335c7e8-d380-4f73-9233-b477f77db28a", false, "NameDepartment2" },
                    { "40d2170f-d13d-4207-8194-a7cdba3c4445", false, "NameDepartment1" },
                    { "6e09445f-2754-498a-86af-c1d3f9eea8eb", false, "NameDepartment3" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "23628387-4AD3-4A03-993B-1ECF0F030CB3",
                columns: new[] { "ConcurrencyStamp", "role_IsDelete" },
                values: new object[] { "523470e5-fb7c-46e8-bea6-7ced2e332663", false });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8B6B7FA7-220D-427F-AF15-57DE6EF686C6",
                columns: new[] { "ConcurrencyStamp", "role_IsDelete" },
                values: new object[] { "4e89bf30-a9a6-4204-9407-5d4e9c0a0345", false });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "topic_Id", "topic_ClosureDate", "topic_FinalClosureDate", "topic_IsDelete", "topic_Name" },
                values: new object[,]
                {
                    { "00eff228-cf1a-45e3-a8c8-49f8c5442e9f", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 5" },
                    { "1a21bc01-3c67-411c-8b6b-17aea508e2c8", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 3" },
                    { "4f544ed5-809b-4dab-9df8-dba04116dfcd", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 4" },
                    { "7716c94e-1538-459d-8207-1ccab9d2f63e", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 1" },
                    { "df586373-2627-4b0e-b1b2-bbd6cbaed95e", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 2" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "575c8ae3-105a-4cc3-adcc-764e28e2eb54", 0, "a0d6d3d5-a8ba-4d79-a22c-34e9a98bf2a1", "User", "staff@gmail.com", false, false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEHH5pAuA8HYzvLZ8HF9Y+FslOwNp2+GJDr8R6Mu+QBGmiMrA7OUbEoavC8JCDuBJqA==", null, false, "2048b02f-8e09-4cbf-881d-14f808a230a1", false, "Staff", "3335c7e8-d380-4f73-9233-b477f77db28a" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "ff267cba-2878-49f1-b1b5-a7f3764cb694", 0, "05400929-d741-4671-b182-29da5bf6f421", "User", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEHBSdzgj324I9/W50Kmzyi5WBuvHIrempE6ejXKdzCf5/bgCxiPPLr5UC978bBW9Ew==", null, false, "17f07a07-904f-40f3-bbfc-ba1a3b517432", false, "Admin", "40d2170f-d13d-4207-8194-a7cdba3c4445" });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_CategoryId", "idea_DateTime", "idea_FilePath", "idea_IsDelete", "idea_Text", "idea_Topic", "idea_UserId" },
                values: new object[,]
                {
                    { "747ae602-8302-44ae-ba11-4e4d48e011c7", "101f2802-02b6-4b83-a3ac-82d2f38945e0", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath2", false, "Idea 2", "df586373-2627-4b0e-b1b2-bbd6cbaed95e", "575c8ae3-105a-4cc3-adcc-764e28e2eb54" },
                    { "ac19dc98-eb40-41e5-8fff-88f767fb0096", "eae52257-c261-4130-a9d3-e843ad735f1d", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath1", false, "Idea 1", "7716c94e-1538-459d-8207-1ccab9d2f63e", "575c8ae3-105a-4cc3-adcc-764e28e2eb54" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "575c8ae3-105a-4cc3-adcc-764e28e2eb54" },
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "ff267cba-2878-49f1-b1b5-a7f3764cb694" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "cmt_Id", "cmt_Datetime", "cmt_IdeaId", "cmt_IsDelete", "cmt_Text", "cmt_UserId" },
                values: new object[] { "8028b248-3681-4554-bba2-ee26cab831c2", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ac19dc98-eb40-41e5-8fff-88f767fb0096", false, "Commnet 1", "575c8ae3-105a-4cc3-adcc-764e28e2eb54" });

            migrationBuilder.InsertData(
                table: "React",
                columns: new[] { "react_Id", "react_IdeadId", "react_React", "react_UserId" },
                values: new object[,]
                {
                    { "137a9653-34d5-4d36-ba1e-5673a7cbe6e0", "ac19dc98-eb40-41e5-8fff-88f767fb0096", -1, "575c8ae3-105a-4cc3-adcc-764e28e2eb54" },
                    { "b7c5753c-7d06-45cb-a1de-5729f9e7775e", "ac19dc98-eb40-41e5-8fff-88f767fb0096", -1, "ff267cba-2878-49f1-b1b5-a7f3764cb694" }
                });

            migrationBuilder.InsertData(
                table: "View",
                columns: new[] { "view_Id", "view_IdeadId", "view_UserId", "view_VisitTime" },
                values: new object[] { "663669d2-6f67-4702-bb86-707eda6a10d4", "ac19dc98-eb40-41e5-8fff-88f767fb0096", "575c8ae3-105a-4cc3-adcc-764e28e2eb54", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserModel");

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "cmt_Id",
                keyValue: "8028b248-3681-4554-bba2-ee26cab831c2");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "6e09445f-2754-498a-86af-c1d3f9eea8eb");

            migrationBuilder.DeleteData(
                table: "Idea",
                keyColumn: "idea_Id",
                keyValue: "747ae602-8302-44ae-ba11-4e4d48e011c7");

            migrationBuilder.DeleteData(
                table: "React",
                keyColumn: "react_Id",
                keyValue: "137a9653-34d5-4d36-ba1e-5673a7cbe6e0");

            migrationBuilder.DeleteData(
                table: "React",
                keyColumn: "react_Id",
                keyValue: "b7c5753c-7d06-45cb-a1de-5729f9e7775e");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "00eff228-cf1a-45e3-a8c8-49f8c5442e9f");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "1a21bc01-3c67-411c-8b6b-17aea508e2c8");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "4f544ed5-809b-4dab-9df8-dba04116dfcd");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "575c8ae3-105a-4cc3-adcc-764e28e2eb54" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "ff267cba-2878-49f1-b1b5-a7f3764cb694" });

            migrationBuilder.DeleteData(
                table: "View",
                keyColumn: "view_Id",
                keyValue: "663669d2-6f67-4702-bb86-707eda6a10d4");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_Id",
                keyValue: "101f2802-02b6-4b83-a3ac-82d2f38945e0");

            migrationBuilder.DeleteData(
                table: "Idea",
                keyColumn: "idea_Id",
                keyValue: "ac19dc98-eb40-41e5-8fff-88f767fb0096");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "df586373-2627-4b0e-b1b2-bbd6cbaed95e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ff267cba-2878-49f1-b1b5-a7f3764cb694");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "category_Id",
                keyValue: "eae52257-c261-4130-a9d3-e843ad735f1d");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "40d2170f-d13d-4207-8194-a7cdba3c4445");

            migrationBuilder.DeleteData(
                table: "Topic",
                keyColumn: "topic_Id",
                keyValue: "7716c94e-1538-459d-8207-1ccab9d2f63e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "575c8ae3-105a-4cc3-adcc-764e28e2eb54");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "department_Id",
                keyValue: "3335c7e8-d380-4f73-9233-b477f77db28a");

            migrationBuilder.DropColumn(
                name: "topic_IsDelete",
                table: "Topic");

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
    }
}
