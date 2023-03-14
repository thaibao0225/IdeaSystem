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
                    { "a4cb1c23-1380-4ca3-b573-258162cfd3b2", false, "Category1" },
                    { "bc397ed8-b36a-4230-bd99-dc7790b2e60d", false, "Category2" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "590e133f-52bf-4f93-9646-23c45a119cef", false, "NameDepartment2" },
                    { "9f18b5cb-2e33-47d3-aea3-26991e4f0d14", false, "NameDepartment3" },
                    { "fea443ce-fe5f-4aa5-b2e4-007eadab28ac", false, "NameDepartment1" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "role_IsDelete" },
                values: new object[,]
                {
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "2cadd06c-4443-4eca-8dcf-7679faf642a9", "Role", "Admin", "admin", false },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "0de9d631-7c3d-4ad9-ba77-04543cc8c17d", "Role", "Staff", "staff", false },
                    { "aa25bd75-d486-4868-b2c3-14d91caf6cad", "28c922c5-b450-4305-a3fa-bbff7114d3b6", "Role", "Qa", "qa", false }
                });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "topic_Id", "topic_ClosureDate", "topic_FinalClosureDate", "topic_IsDelete", "topic_Name" },
                values: new object[,]
                {
                    { "120dfdb6-3d00-48bb-86ff-46706a1c453e", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 3" },
                    { "23df84a6-0575-4bb7-aef4-4c46e19a1b0e", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 1" },
                    { "463b097c-1681-4d56-ad0c-fa3badad88d2", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 2" },
                    { "54b02101-4e99-47a0-a6ad-1d76bfccb7fa", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 5" },
                    { "d4cae51f-009e-46d2-bc65-ba5e599a4d43", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 4" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[,]
                {
                    { "668cbb00-b970-478a-835d-697a046c95cd", 0, "ccdfd84d-36af-4f7b-b3df-ba1ec25327a0", "User", "staff@testgmail.com", true, false, null, "STAFF@TESTGMAIL.COM", "STAFF@TESTGMAIL.COM", "AQAAAAEAACcQAAAAEGgPpmffMCjbA7hVDJrxddePqWI/XtKooHe6ySlmxgz8T0AqSg5uQdczD9uvlbjWGA==", null, false, "768f7278-a851-4cd9-82a4-2128293025f9", false, "staff@testgmail.com", "590e133f-52bf-4f93-9646-23c45a119cef" },
                    { "8587e1a0-3531-4072-a48d-a6467ceb9f46", 0, "31011b34-b3b3-444b-ab65-68f16dd74e8a", "User", "qa@testgmail.com", true, false, null, "QA@TESTGMAIL.COM", "QA@TESTGMAIL.COM", "AQAAAAEAACcQAAAAEMakQtE6R8eK+o2IPUioso9VNILRAJzZM/GUbKf/HCpy+UEF8f39m4QfUrKMzZ2RDg==", null, false, "cf02f17d-fb22-435d-bae2-34fed006ee9b", false, "qa@testgmail.com", "590e133f-52bf-4f93-9646-23c45a119cef" },
                    { "c260f583-20b6-42bc-bd85-c70c86c1ae35", 0, "b47c3bf7-8a41-43f1-9fdb-25a02bd75a3d", "User", "staff2@gmail.com", true, false, null, "STAFF2@TESTGMAIL.COM", "STAFF2@TESTGMAIL.COM", "AQAAAAEAACcQAAAAEN3buXiinVZsyWXDTSm/BzKzmRQo37D1zajTcOEWpYltF4I+yeWpWZ2sHxmRa+XPlg==", null, false, "6848c635-890f-4321-8783-c60eb080ba9d", false, "staff2@testgmail.com", "590e133f-52bf-4f93-9646-23c45a119cef" },
                    { "c63325a5-52b0-4624-a823-41e5c097cedd", 0, "ef78221c-b663-40ea-a22d-20c68254c7f1", "User", "admin@testgmail.com", true, false, null, "ADMIN@TESTGMAIL.COM", "ADMIN@TESTGMAIL.COM", "AQAAAAEAACcQAAAAEBtJze7Q5jgMmBCM1Xm36mZO4I4qsHB0g48cu2Acdf6zDi5BalKoqeNdC66SZi/Thw==", null, false, "7407d3bb-bf92-4005-b997-dc4aa9a1ae72", false, "admin@testgmail.com", "fea443ce-fe5f-4aa5-b2e4-007eadab28ac" }
                });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_Agree", "idea_CategoryId", "idea_DateTime", "idea_FileName", "idea_FilePath", "idea_IsDelete", "idea_Name", "idea_Text", "idea_TopicId", "idea_UserId" },
                values: new object[,]
                {
                    { "7f3f5bfb-be23-4d05-97fd-1093012bd934", false, "bc397ed8-b36a-4230-bd99-dc7790b2e60d", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath2", "FilePath2", false, "Idea 2", "Idea 2", "463b097c-1681-4d56-ad0c-fa3badad88d2", "668cbb00-b970-478a-835d-697a046c95cd" },
                    { "94086978-23c4-4c2b-9c9f-4d81b3a2bf42", false, "bc397ed8-b36a-4230-bd99-dc7790b2e60d", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath3", "FilePath3", false, "Idea 3", "Idea 3", "23df84a6-0575-4bb7-aef4-4c46e19a1b0e", "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "a6677c95-a3fc-46aa-956d-366045edca54", false, "a4cb1c23-1380-4ca3-b573-258162cfd3b2", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath1", "FilePath1", false, "Idea 1", "Idea 1", "23df84a6-0575-4bb7-aef4-4c46e19a1b0e", "668cbb00-b970-478a-835d-697a046c95cd" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "668cbb00-b970-478a-835d-697a046c95cd" },
                    { "aa25bd75-d486-4868-b2c3-14d91caf6cad", "8587e1a0-3531-4072-a48d-a6467ceb9f46" },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "c260f583-20b6-42bc-bd85-c70c86c1ae35" },
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "c63325a5-52b0-4624-a823-41e5c097cedd" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "cmt_Id", "cmt_Datetime", "cmt_IdeaId", "cmt_IsDelete", "cmt_Text", "cmt_UserId" },
                values: new object[,]
                {
                    { "2e36b83c-bbcd-4fed-bc55-7b735306fde7", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "94086978-23c4-4c2b-9c9f-4d81b3a2bf42", false, "Commnet 2", "668cbb00-b970-478a-835d-697a046c95cd" },
                    { "4ee8fcf2-a555-4115-a18c-ed8def491420", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "a6677c95-a3fc-46aa-956d-366045edca54", false, "Commnet 1", "668cbb00-b970-478a-835d-697a046c95cd" }
                });

            migrationBuilder.InsertData(
                table: "React",
                columns: new[] { "react_Id", "react_IdeadId", "react_React", "react_UserId" },
                values: new object[,]
                {
                    { "0387f3d5-7ef3-4039-82cd-18c2ca81e003", "a6677c95-a3fc-46aa-956d-366045edca54", 1, "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "1bf13497-65e6-4e62-a8e3-925a22fb7f13", "94086978-23c4-4c2b-9c9f-4d81b3a2bf42", -1, "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "43da03e4-345c-4611-9097-4a23680b3940", "a6677c95-a3fc-46aa-956d-366045edca54", -1, "668cbb00-b970-478a-835d-697a046c95cd" }
                });

            migrationBuilder.InsertData(
                table: "View",
                columns: new[] { "view_Id", "view_IdeadId", "view_UserId", "view_VisitTime" },
                values: new object[,]
                {
                    { "7abc8c34-e8c8-46eb-a397-bfe60d5302bf", "a6677c95-a3fc-46aa-956d-366045edca54", "668cbb00-b970-478a-835d-697a046c95cd", 1 },
                    { "c4a21117-5498-43f9-ae5b-47ff272d90f4", "94086978-23c4-4c2b-9c9f-4d81b3a2bf42", "c63325a5-52b0-4624-a823-41e5c097cedd", 1 },
                    { "fee65d6a-a711-44b1-85b2-218d7861a7da", "a6677c95-a3fc-46aa-956d-366045edca54", "c63325a5-52b0-4624-a823-41e5c097cedd", 1 }
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
