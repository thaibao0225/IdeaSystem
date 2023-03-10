using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdeaSystem.Migrations
{
    public partial class init2 : Migration
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
                    { "a06ab48a-f7b8-408f-92fa-09f294a61aa4", false, "Category1" },
                    { "ae1f2e7b-25a1-4bea-a95e-4ba67953d5c9", false, "Category2" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "d05e1e31-75c0-4a6c-a428-fa885dbe860a", false, "NameDepartment1" },
                    { "e9660754-a92a-483e-b687-9adaec469457", false, "NameDepartment2" },
                    { "fd477db4-c6e1-4349-ad6d-7f72c91cd256", false, "NameDepartment3" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "role_IsDelete" },
                values: new object[,]
                {
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "f0980b80-27ed-48d8-84ab-c7c7a0f0fdd8", "Role", "Admin", "admin", false },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "d8204fdf-809a-4ec4-a78e-a130c63cf385", "Role", "Staff", "staff", false }
                });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "topic_Id", "topic_ClosureDate", "topic_FinalClosureDate", "topic_IsDelete", "topic_Name" },
                values: new object[,]
                {
                    { "42d96189-0737-4c0a-aaa0-6f2e83fa8131", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 3" },
                    { "c80aa982-7c2d-4796-a053-3e413c0a7f63", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 4" },
                    { "c9454b78-be90-4abd-945f-6df1810dfd13", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 1" },
                    { "ed00a7c2-947e-4dd5-9378-73a73a65adca", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 2" },
                    { "f2cdf913-3b0b-42c0-8e31-0cb16b418125", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 5" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "c63325a5-52b0-4624-a823-41e5c097cedd", 0, "a2363135-7015-4914-a52f-212676872637", "User", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPWnqKPk//Fvn4N5CXuXvko+eH90EvWOthH9m6FMlzSe5IA+xzZuh1OnKSTDvFmw7A==", null, false, "575539a7-058b-4d6c-b2ab-7e435d8d071a", false, "admin@gmail.com", "d05e1e31-75c0-4a6c-a428-fa885dbe860a" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[] { "c8d995b5-ecc4-4a37-812d-5a6e654255a8", 0, "34b64e2d-b378-4ebb-a7d7-b1068b44b2c4", "User", "staff@gmail.com", true, false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEJcHqkSZhEPRj98oUSzdEeDHrlqIdRrd6yIrNI5+pnzge4gC1t6CVlKsuL4zL8PSmw==", null, false, "528f6296-be5c-43ab-885f-6c0a5456293b", false, "staff@gmail.com", "e9660754-a92a-483e-b687-9adaec469457" });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_CategoryId", "idea_DateTime", "idea_FilePath", "idea_IsDelete", "idea_Text", "idea_TopicId", "idea_UserId" },
                values: new object[,]
                {
                    { "08a79142-2e81-489f-948c-8c154552ea20", "ae1f2e7b-25a1-4bea-a95e-4ba67953d5c9", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath2", false, "Idea 2", "ed00a7c2-947e-4dd5-9378-73a73a65adca", "c8d995b5-ecc4-4a37-812d-5a6e654255a8" },
                    { "45d25248-ad2f-4358-98b2-b7b46143011e", "ae1f2e7b-25a1-4bea-a95e-4ba67953d5c9", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath3", false, "Idea 3", "c9454b78-be90-4abd-945f-6df1810dfd13", "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "b38290a7-b180-4626-baa9-642d4d088fd9", "a06ab48a-f7b8-408f-92fa-09f294a61aa4", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath1", false, "Idea 1", "c9454b78-be90-4abd-945f-6df1810dfd13", "c8d995b5-ecc4-4a37-812d-5a6e654255a8" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "c8d995b5-ecc4-4a37-812d-5a6e654255a8" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "cmt_Id", "cmt_Datetime", "cmt_IdeaId", "cmt_IsDelete", "cmt_Text", "cmt_UserId" },
                values: new object[,]
                {
                    { "08329150-be4f-47d3-8ce9-ea1d9afe8e18", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "b38290a7-b180-4626-baa9-642d4d088fd9", false, "Commnet 1", "c8d995b5-ecc4-4a37-812d-5a6e654255a8" },
                    { "f16f94f7-12c6-412e-9fa5-8dffcf9434cf", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "45d25248-ad2f-4358-98b2-b7b46143011e", false, "Commnet 2", "c8d995b5-ecc4-4a37-812d-5a6e654255a8" }
                });

            migrationBuilder.InsertData(
                table: "React",
                columns: new[] { "react_Id", "react_IdeadId", "react_React", "react_UserId" },
                values: new object[,]
                {
                    { "09aeea8e-a544-4b25-90e3-dfa140087d76", "b38290a7-b180-4626-baa9-642d4d088fd9", 1, "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "247ce902-03ef-4022-869d-6dd064be1e30", "45d25248-ad2f-4358-98b2-b7b46143011e", -1, "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "9c3d0883-f786-44e4-9a03-7e1dd0849340", "b38290a7-b180-4626-baa9-642d4d088fd9", -1, "c8d995b5-ecc4-4a37-812d-5a6e654255a8" }
                });

            migrationBuilder.InsertData(
                table: "View",
                columns: new[] { "view_Id", "view_IdeadId", "view_UserId", "view_VisitTime" },
                values: new object[,]
                {
                    { "3eb492a6-8f8e-4768-86e3-6ce9b985e543", "45d25248-ad2f-4358-98b2-b7b46143011e", "c63325a5-52b0-4624-a823-41e5c097cedd", 1 },
                    { "7286a0f3-6d32-4543-88be-ed00c0722135", "b38290a7-b180-4626-baa9-642d4d088fd9", "c63325a5-52b0-4624-a823-41e5c097cedd", 1 },
                    { "a7492bd2-fef9-4f75-9bd5-a97b16298430", "b38290a7-b180-4626-baa9-642d4d088fd9", "c8d995b5-ecc4-4a37-812d-5a6e654255a8", 1 }
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
