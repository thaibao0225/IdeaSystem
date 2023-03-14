using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaSystem.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    category_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    category_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    department_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    department_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    department_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.department_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role_IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    topic_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    topic_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    topic_ClosureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    topic_FinalClosureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    topic_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.topic_Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_DepartmentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Department_user_DepartmentId",
                        column: x => x.user_DepartmentId,
                        principalTable: "Department",
                        principalColumn: "department_Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Idea",
                columns: table => new
                {
                    idea_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idea_Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idea_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idea_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idea_FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idea_DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idea_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idea_CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idea_TopicId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idea_IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    idea_Agree = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idea", x => x.idea_Id);
                    table.ForeignKey(
                        name: "FK_Idea_Category_idea_CategoryId",
                        column: x => x.idea_CategoryId,
                        principalTable: "Category",
                        principalColumn: "category_Id");
                    table.ForeignKey(
                        name: "FK_Idea_Topic_idea_TopicId",
                        column: x => x.idea_TopicId,
                        principalTable: "Topic",
                        principalColumn: "topic_Id");
                    table.ForeignKey(
                        name: "FK_Idea_Users_idea_UserId",
                        column: x => x.idea_UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    cmt_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cmt_Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cmt_Datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cmt_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cmt_IdeaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cmt_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.cmt_Id);
                    table.ForeignKey(
                        name: "FK_Comment_Idea_cmt_IdeaId",
                        column: x => x.cmt_IdeaId,
                        principalTable: "Idea",
                        principalColumn: "idea_Id");
                    table.ForeignKey(
                        name: "FK_Comment_Users_cmt_UserId",
                        column: x => x.cmt_UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "React",
                columns: table => new
                {
                    react_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    react_React = table.Column<int>(type: "int", nullable: false),
                    react_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    react_IdeadId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_React", x => x.react_Id);
                    table.ForeignKey(
                        name: "FK_React_Idea_react_IdeadId",
                        column: x => x.react_IdeadId,
                        principalTable: "Idea",
                        principalColumn: "idea_Id");
                    table.ForeignKey(
                        name: "FK_React_Users_react_UserId",
                        column: x => x.react_UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "View",
                columns: table => new
                {
                    view_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    view_VisitTime = table.Column<int>(type: "int", nullable: false),
                    view_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    view_IdeadId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_View", x => x.view_Id);
                    table.ForeignKey(
                        name: "FK_View_Idea_view_IdeadId",
                        column: x => x.view_IdeadId,
                        principalTable: "Idea",
                        principalColumn: "idea_Id");
                    table.ForeignKey(
                        name: "FK_View_Users_view_UserId",
                        column: x => x.view_UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "category_Id", "category_IsDelete", "category_Name" },
                values: new object[,]
                {
                    { "bf209409-e9c7-4d61-ba61-730de1dd70bf", false, "Category1" },
                    { "f0c1d980-ba0f-44a2-a3c2-e507454428c9", false, "Category2" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "9d797bf6-7034-408d-9101-212f29c8554d", false, "NameDepartment3" },
                    { "d1fb164d-b4d8-4eac-9360-96fe89e8a543", false, "NameDepartment2" },
                    { "dfab6eed-c837-4012-bd80-f5bfee2840fa", false, "NameDepartment1" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "role_IsDelete" },
                values: new object[,]
                {
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "a8a87fc4-4ac0-4af2-9f51-718f798ddaa0", "Role", "Admin", "admin", false },
                    { "4bd099e1-8863-4b6d-9e14-167b2142cd34", "192f4236-d630-4ee9-b8c2-34acaa0d8e28", "Role", "QA", "QA", false },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "56d27edb-9d76-4960-95a7-be2d2ffcd9b5", "Role", "Staff", "staff", false }
                });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "topic_Id", "topic_ClosureDate", "topic_FinalClosureDate", "topic_IsDelete", "topic_Name" },
                values: new object[,]
                {
                    { "5dbedbd0-3c8d-4ea9-bd08-b5d727dca7bf", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 3" },
                    { "8fb26c36-18d9-4828-88d8-1d52b9af0d02", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 5" },
                    { "cf20f4ab-6e67-4f22-a925-a9bcb707545a", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 2" },
                    { "dfa98ba7-000d-4662-96ce-706f441560b7", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 1" },
                    { "ff1b5cd5-02f4-4084-ba48-416a871c0a10", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 4" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[,]
                {
                    { "302833b1-bab1-48b3-8f31-9e754b5fd369", 0, "1350eccd-baec-4a30-8294-5b8d275cca30", "User", "staff@testgmail.com", true, false, null, "STAFF@TESTGMAIL.COM", "qa@TESTGMAIL.COM", "AQAAAAEAACcQAAAAENYza0eXJNhGC9NDUpgAMtVJtda7S8xPkdkEUxIiOuyZecJkyAN1LDImv5XQOMTxtQ==", null, false, "01a15ac1-a36b-44ea-80f5-e7fe843d3a75", false, "qa@testgmail.com", "d1fb164d-b4d8-4eac-9360-96fe89e8a543" },
                    { "c63325a5-52b0-4624-a823-41e5c097cedd", 0, "63e909bb-8ada-4e12-999d-495e05d90a25", "User", "admin@testgmail.com", true, false, null, "ADMIN@TESTGMAIL.COM", "ADMIN@TESTGMAIL.COM", "AQAAAAEAACcQAAAAEC5MP7WtPBTbUBpVXCSC8O+5H3F7fQJaOLokt0CMtpiKyWTFWHvt+alZqdwBBpcWTQ==", null, false, "f07574a7-b239-45c4-802e-abc477ff2268", false, "admin@testgmail.com", "dfab6eed-c837-4012-bd80-f5bfee2840fa" },
                    { "d309760a-dc30-428d-a10c-be4e67e42d00", 0, "a3d38a34-29a5-49b7-b618-90dbd62eb7bf", "User", "staff@testgmail.com", true, false, null, "STAFF@TESTGMAIL.COM", "STAFF@TESTGMAIL.COM", "AQAAAAEAACcQAAAAEI+57PnuLscYz9UqWKgmI8bVF4PmMoMHCbI7ZddOL0hJ7KKpV1rlj1g2xHGg+W9U+w==", null, false, "0d2347e4-370f-4fd4-bd0d-e93682c366e4", false, "staff@testgmail.com", "d1fb164d-b4d8-4eac-9360-96fe89e8a543" },
                    { "f3f399e2-76eb-491b-b29e-b52bcd418610", 0, "1d17ff2c-abdc-4221-b30e-1e43c9dd2dca", "User", "staff2@gmail.com", true, false, null, "STAFF2@TESTGMAIL.COM", "STAFF2@TESTGMAIL.COM", "AQAAAAEAACcQAAAAECiYlovYKuYrR0IQHYNeJuWGKkl7fhbcVXkjU/xXUMb1PXYAAJpCWk3kM0JmLnEoSQ==", null, false, "6a58c2b0-9e3a-4505-b2e2-52f6a406f17d", false, "staff2@testgmail.com", "d1fb164d-b4d8-4eac-9360-96fe89e8a543" }
                });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_Agree", "idea_CategoryId", "idea_DateTime", "idea_FileName", "idea_FilePath", "idea_IsDelete", "idea_Name", "idea_Text", "idea_TopicId", "idea_UserId" },
                values: new object[,]
                {
                    { "2ffad209-cf5d-454f-8b00-393afb2fbc23", false, "f0c1d980-ba0f-44a2-a3c2-e507454428c9", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath2", "FilePath2", false, "Idea 2", "Idea 2", "cf20f4ab-6e67-4f22-a925-a9bcb707545a", "d309760a-dc30-428d-a10c-be4e67e42d00" },
                    { "4c9763fd-566a-40e1-b0ca-45ca71c26ca3", false, "bf209409-e9c7-4d61-ba61-730de1dd70bf", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath1", "FilePath1", false, "Idea 1", "Idea 1", "dfa98ba7-000d-4662-96ce-706f441560b7", "d309760a-dc30-428d-a10c-be4e67e42d00" },
                    { "c31a1ddb-9dd1-4e8c-b87e-298cffd5a0c3", false, "f0c1d980-ba0f-44a2-a3c2-e507454428c9", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath3", "FilePath3", false, "Idea 3", "Idea 3", "dfa98ba7-000d-4662-96ce-706f441560b7", "c63325a5-52b0-4624-a823-41e5c097cedd" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4bd099e1-8863-4b6d-9e14-167b2142cd34", "302833b1-bab1-48b3-8f31-9e754b5fd369" },
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "d309760a-dc30-428d-a10c-be4e67e42d00" },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "f3f399e2-76eb-491b-b29e-b52bcd418610" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "cmt_Id", "cmt_Datetime", "cmt_IdeaId", "cmt_IsDelete", "cmt_Text", "cmt_UserId" },
                values: new object[,]
                {
                    { "119b7b3d-928e-4906-9e16-b5c5dba206f2", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "c31a1ddb-9dd1-4e8c-b87e-298cffd5a0c3", false, "Commnet 2", "d309760a-dc30-428d-a10c-be4e67e42d00" },
                    { "defb91bb-bc88-487a-99c8-a134121d12be", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "4c9763fd-566a-40e1-b0ca-45ca71c26ca3", false, "Commnet 1", "d309760a-dc30-428d-a10c-be4e67e42d00" }
                });

            migrationBuilder.InsertData(
                table: "React",
                columns: new[] { "react_Id", "react_IdeadId", "react_React", "react_UserId" },
                values: new object[,]
                {
                    { "5eb7f2ba-6c78-471f-9412-193abfdb865d", "4c9763fd-566a-40e1-b0ca-45ca71c26ca3", 1, "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "6148210a-c590-40bf-a075-a8681aa948a1", "4c9763fd-566a-40e1-b0ca-45ca71c26ca3", -1, "d309760a-dc30-428d-a10c-be4e67e42d00" },
                    { "89a0ed29-747a-4397-84d2-2f77d267a625", "c31a1ddb-9dd1-4e8c-b87e-298cffd5a0c3", -1, "c63325a5-52b0-4624-a823-41e5c097cedd" }
                });

            migrationBuilder.InsertData(
                table: "View",
                columns: new[] { "view_Id", "view_IdeadId", "view_UserId", "view_VisitTime" },
                values: new object[,]
                {
                    { "479c4c05-43e5-45d5-9874-e85ca65953b9", "4c9763fd-566a-40e1-b0ca-45ca71c26ca3", "d309760a-dc30-428d-a10c-be4e67e42d00", 1 },
                    { "5b81939f-45c7-4f8b-ad9a-af93fa75b4e1", "4c9763fd-566a-40e1-b0ca-45ca71c26ca3", "c63325a5-52b0-4624-a823-41e5c097cedd", 1 },
                    { "eea7be65-2cfa-4ca3-bef9-84cf73a871b9", "c31a1ddb-9dd1-4e8c-b87e-298cffd5a0c3", "c63325a5-52b0-4624-a823-41e5c097cedd", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_cmt_IdeaId",
                table: "Comment",
                column: "cmt_IdeaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_cmt_UserId",
                table: "Comment",
                column: "cmt_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Idea_idea_CategoryId",
                table: "Idea",
                column: "idea_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Idea_idea_TopicId",
                table: "Idea",
                column: "idea_TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Idea_idea_UserId",
                table: "Idea",
                column: "idea_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_React_react_IdeadId",
                table: "React",
                column: "react_IdeadId");

            migrationBuilder.CreateIndex(
                name: "IX_React_react_UserId",
                table: "React",
                column: "react_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Users_user_DepartmentId",
                table: "Users",
                column: "user_DepartmentId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_View_view_IdeadId",
                table: "View",
                column: "view_IdeadId");

            migrationBuilder.CreateIndex(
                name: "IX_View_view_UserId",
                table: "View",
                column: "view_UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "React");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserModel");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "View");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Idea");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Topic");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
