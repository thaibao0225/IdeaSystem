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
                    idea_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idea_DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idea_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idea_CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idea_TopicId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idea_IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    { "2406d241-4a3f-49ba-baff-c0e5765de6e7", false, "Category2" },
                    { "821e3309-5ceb-4a11-90c8-9d0980fd72be", false, "Category1" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "67298881-c949-42d9-ac8b-f241d7e5f2b1", false, "NameDepartment1" },
                    { "cb4fdeff-bf4e-4727-beb9-6fe71405db78", false, "NameDepartment2" },
                    { "e9060823-6e2c-490b-a701-fdce27ed4b1b", false, "NameDepartment3" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "role_IsDelete" },
                values: new object[,]
                {
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "86108950-9ad1-4dc8-a845-56441cc85847", "Role", "Admin", "admin", false },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "4037667f-507e-41bc-bb59-d2dbaeba383f", "Role", "Staff", "staff", false }
                });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "topic_Id", "topic_ClosureDate", "topic_FinalClosureDate", "topic_IsDelete", "topic_Name" },
                values: new object[,]
                {
                    { "5903be3f-ef1f-45b4-90dc-c10d7677b86f", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 4" },
                    { "592b41b3-0ca3-47c0-94bd-f99c05ccce86", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 3" },
                    { "7b27ebeb-25b1-41ed-99a5-3d9c63ab5739", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 2" },
                    { "c27d9602-e59e-4f7b-bd75-ffadfb116eff", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 5" },
                    { "c5bfa4f2-140f-470e-8985-3c93bb5b92ed", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "c63325a5-52b0-4624-a823-41e5c097cedd", 0, "e3b888fe-44cf-469e-b6fa-a0858acc8fcc", "User", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEE26RwNslYvHiKoWpbxlx6qiXNJAYZZvc6fHSUGISm0eFfVNhzc77/NW2nniOOyxuw==", null, false, "0e2c9bee-af5b-4fee-9c94-1394873bc7f4", false, "Admin", "67298881-c949-42d9-ac8b-f241d7e5f2b1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "d93883d6-1265-4509-8bf3-d7479564c27f", 0, "a1769ba2-33be-4a48-9512-b6e7401822bc", "User", "staff@gmail.com", false, false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEHLBt/2jDzQeWGVEkLElS80tZy4FvHzspDdRWFuV8uFrZtbfMc889hTSpPfCNGQcWQ==", null, false, "4dea9836-032c-4d81-a71e-d43dfa784631", false, "Staff", "cb4fdeff-bf4e-4727-beb9-6fe71405db78" });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_CategoryId", "idea_DateTime", "idea_FilePath", "idea_IsDelete", "idea_Text", "idea_TopicId", "idea_UserId" },
                values: new object[,]
                {
                    { "2f9dbc67-5342-49be-a1d8-62fa832f2a8d", "821e3309-5ceb-4a11-90c8-9d0980fd72be", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath1", false, "Idea 1", "c5bfa4f2-140f-470e-8985-3c93bb5b92ed", "d93883d6-1265-4509-8bf3-d7479564c27f" },
                    { "ca0b271a-5224-445f-8123-d1579185f5db", "2406d241-4a3f-49ba-baff-c0e5765de6e7", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath2", false, "Idea 2", "7b27ebeb-25b1-41ed-99a5-3d9c63ab5739", "d93883d6-1265-4509-8bf3-d7479564c27f" },
                    { "ef4ce609-6d40-4a65-9e3b-d53d8047fccc", "2406d241-4a3f-49ba-baff-c0e5765de6e7", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath3", false, "Idea 3", "c5bfa4f2-140f-470e-8985-3c93bb5b92ed", "c63325a5-52b0-4624-a823-41e5c097cedd" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "d93883d6-1265-4509-8bf3-d7479564c27f" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "cmt_Id", "cmt_Datetime", "cmt_IdeaId", "cmt_IsDelete", "cmt_Text", "cmt_UserId" },
                values: new object[,]
                {
                    { "225d974a-578a-4744-8d13-bf57e603d449", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ef4ce609-6d40-4a65-9e3b-d53d8047fccc", false, "Commnet 2", "d93883d6-1265-4509-8bf3-d7479564c27f" },
                    { "d484bc32-80d5-4ef0-9776-3805e12e578f", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "2f9dbc67-5342-49be-a1d8-62fa832f2a8d", false, "Commnet 1", "d93883d6-1265-4509-8bf3-d7479564c27f" }
                });

            migrationBuilder.InsertData(
                table: "React",
                columns: new[] { "react_Id", "react_IdeadId", "react_React", "react_UserId" },
                values: new object[,]
                {
                    { "1fd7fe54-b949-45b4-a5c6-44d3e0af4e01", "2f9dbc67-5342-49be-a1d8-62fa832f2a8d", -1, "d93883d6-1265-4509-8bf3-d7479564c27f" },
                    { "4f01eda8-ac7b-4aeb-bc0f-273df6287728", "2f9dbc67-5342-49be-a1d8-62fa832f2a8d", 1, "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "6f73f1bd-ba4f-4c62-a40a-97dbb41a7e4a", "ef4ce609-6d40-4a65-9e3b-d53d8047fccc", -1, "c63325a5-52b0-4624-a823-41e5c097cedd" }
                });

            migrationBuilder.InsertData(
                table: "View",
                columns: new[] { "view_Id", "view_IdeadId", "view_UserId", "view_VisitTime" },
                values: new object[,]
                {
                    { "19444c15-f47b-470d-aeb7-289df5600d54", "2f9dbc67-5342-49be-a1d8-62fa832f2a8d", "c63325a5-52b0-4624-a823-41e5c097cedd", 1 },
                    { "96abcb29-d236-4e1c-b312-3ba8f2df17b5", "2f9dbc67-5342-49be-a1d8-62fa832f2a8d", "d93883d6-1265-4509-8bf3-d7479564c27f", 1 },
                    { "a10c30cf-a317-464a-9a57-529d96189fd7", "ef4ce609-6d40-4a65-9e3b-d53d8047fccc", "c63325a5-52b0-4624-a823-41e5c097cedd", 1 }
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
