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
                    { "9508e71d-669d-455b-ad36-f2a83e424039", false, "Category1" },
                    { "cff5e2e0-a4c9-4c67-ba40-4da1c2dd7cf1", false, "Category2" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_Id", "department_IsDelete", "department_Name" },
                values: new object[,]
                {
                    { "10366241-bd1e-45e0-a34b-45ef9cb0cee2", false, "NameDepartment1" },
                    { "b021b595-1842-490d-93b9-2b4773ce2eab", false, "NameDepartment2" },
                    { "e79b30ca-143b-424d-b896-69328baa46db", false, "NameDepartment3" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "role_IsDelete" },
                values: new object[,]
                {
                    { "06c62f70-7860-493d-8c74-648a5360883e", "aee65bcc-747b-4857-a147-03eab1e5dc14", "Role", "Qa", "qa", false },
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "a0d75844-ad22-42d8-bc16-ec505532e25e", "Role", "Admin", "admin", false },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "8d5e3fa0-9abc-4d25-9284-ba2495290d5d", "Role", "Staff", "staff", false }
                });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "topic_Id", "topic_ClosureDate", "topic_FinalClosureDate", "topic_IsDelete", "topic_Name" },
                values: new object[,]
                {
                    { "2649749b-a968-4f8d-9f0f-6a0afd785455", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 5" },
                    { "b0f1679b-8604-48e8-ba49-31d27d6a4f66", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 4" },
                    { "c283b083-0a18-4467-abb9-3ea0b4d64cf7", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 3" },
                    { "d8f144f1-709a-4e38-a4ce-12b84be56445", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 2" },
                    { "f84c8b6e-6692-4f95-a547-ddb98b17bd6d", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Topic 1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "user_DepartmentId" },
                values: new object[,]
                {
                    { "c63325a5-52b0-4624-a823-41e5c097cedd", 0, "4a6d0f69-5f91-40e3-8c15-f70c051532fc", "User", "admin@testgmail.com", true, false, null, "ADMIN@TESTGMAIL.COM", "ADMIN@TESTGMAIL.COM", "AQAAAAEAACcQAAAAEAif7ToLlHTnCzISoBSSo++i+BOEA8HMZNxnAh8NiD6xX933Ml4OEc7lgGvRPKy3Ug==", null, false, "c7603986-a817-4277-a9e5-f41eca2290bc", false, "admin@testgmail.com", "10366241-bd1e-45e0-a34b-45ef9cb0cee2" },
                    { "d76e1c03-fead-4df4-966c-4b3b62b27a57", 0, "9f8f86ae-6258-41cf-a8dc-82f61c27dcde", "User", "qa@testgmail.com", true, false, null, "QA@TESTGMAIL.COM", "QA@TESTGMAIL.COM", "AQAAAAEAACcQAAAAENGnu8AMNMtS9A7dWr+JEdAuGtDOu9xPSXfOKWOmUwfiHDH+6L4XVVj1jWAa1/PpEw==", null, false, "b16a0458-0e0b-4f49-901f-f93e462248fe", false, "qa@testgmail.com", "b021b595-1842-490d-93b9-2b4773ce2eab" },
                    { "dd28b735-4f61-46bf-be98-02c02ee27cee", 0, "e43e17d0-5989-4f75-94fa-01abf84a225a", "User", "staff2@gmail.com", true, false, null, "STAFF2@TESTGMAIL.COM", "STAFF2@TESTGMAIL.COM", "AQAAAAEAACcQAAAAEPdiyYB+12Xws+kE31LUaXW16Ax3fa0ZVLVoc5fxisRPX76MPXd1XkVxNTN1lK4aHw==", null, false, "6324a4dd-63c0-4255-a47d-179d067d39da", false, "staff2@testgmail.com", "b021b595-1842-490d-93b9-2b4773ce2eab" },
                    { "faaf8942-df50-4b17-b3f8-939c7e03ffe8", 0, "dfe228e8-0f1c-4604-b113-6ed04bdbc2e8", "User", "staff@testgmail.com", true, false, null, "STAFF@TESTGMAIL.COM", "STAFF@TESTGMAIL.COM", "AQAAAAEAACcQAAAAEJwqfE92lJsjx0ZplIpPvTrBLHlxjTYwnBESOZKNCI/9rr751QLHCczTFCZzmU2Tog==", null, false, "81a11dc9-f428-4b51-b1ba-147422ec418f", false, "staff@testgmail.com", "b021b595-1842-490d-93b9-2b4773ce2eab" }
                });

            migrationBuilder.InsertData(
                table: "Idea",
                columns: new[] { "idea_Id", "idea_Agree", "idea_CategoryId", "idea_DateTime", "idea_FileName", "idea_FilePath", "idea_IsDelete", "idea_Name", "idea_Text", "idea_TopicId", "idea_UserId" },
                values: new object[,]
                {
                    { "486a781b-066c-4e0a-b9c1-e31f7888391e", false, "9508e71d-669d-455b-ad36-f2a83e424039", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath1", "FilePath1", false, "Idea 1", "Idea 1", "f84c8b6e-6692-4f95-a547-ddb98b17bd6d", "faaf8942-df50-4b17-b3f8-939c7e03ffe8" },
                    { "e4512814-41a7-4724-ba67-877c4f1a137e", false, "cff5e2e0-a4c9-4c67-ba40-4da1c2dd7cf1", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath3", "FilePath3", false, "Idea 3", "Idea 3", "f84c8b6e-6692-4f95-a547-ddb98b17bd6d", "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "fa695188-522a-4aed-a82b-f348673913a9", false, "cff5e2e0-a4c9-4c67-ba40-4da1c2dd7cf1", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FilePath2", "FilePath2", false, "Idea 2", "Idea 2", "d8f144f1-709a-4e38-a4ce-12b84be56445", "faaf8942-df50-4b17-b3f8-939c7e03ffe8" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "23628387-4AD3-4A03-993B-1ECF0F030CB3", "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "06c62f70-7860-493d-8c74-648a5360883e", "d76e1c03-fead-4df4-966c-4b3b62b27a57" },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "dd28b735-4f61-46bf-be98-02c02ee27cee" },
                    { "8B6B7FA7-220D-427F-AF15-57DE6EF686C6", "faaf8942-df50-4b17-b3f8-939c7e03ffe8" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "cmt_Id", "cmt_Datetime", "cmt_IdeaId", "cmt_IsDelete", "cmt_Text", "cmt_UserId" },
                values: new object[,]
                {
                    { "40987a54-2bb6-4c53-8d0e-7c73907c5760", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "e4512814-41a7-4724-ba67-877c4f1a137e", false, "Commnet 2", "faaf8942-df50-4b17-b3f8-939c7e03ffe8" },
                    { "f925b22b-0513-4a81-ac91-7c80fdcd22f0", new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "486a781b-066c-4e0a-b9c1-e31f7888391e", false, "Commnet 1", "faaf8942-df50-4b17-b3f8-939c7e03ffe8" }
                });

            migrationBuilder.InsertData(
                table: "React",
                columns: new[] { "react_Id", "react_IdeadId", "react_React", "react_UserId" },
                values: new object[,]
                {
                    { "24ade95e-3783-4730-915d-af18157ad585", "fa695188-522a-4aed-a82b-f348673913a9", 1, "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "5d5e6537-91a8-43ae-8063-1b22b886e11c", "e4512814-41a7-4724-ba67-877c4f1a137e", -1, "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "6005a9ca-d652-4813-8ef2-1fa0d0d2de44", "486a781b-066c-4e0a-b9c1-e31f7888391e", 1, "c63325a5-52b0-4624-a823-41e5c097cedd" },
                    { "a500ed55-14fc-4fba-a7fa-55cf1675376d", "486a781b-066c-4e0a-b9c1-e31f7888391e", -1, "faaf8942-df50-4b17-b3f8-939c7e03ffe8" }
                });

            migrationBuilder.InsertData(
                table: "View",
                columns: new[] { "view_Id", "view_IdeadId", "view_UserId", "view_VisitTime" },
                values: new object[,]
                {
                    { "2fc9b539-afb7-44aa-acd4-588ac8cabccc", "486a781b-066c-4e0a-b9c1-e31f7888391e", "faaf8942-df50-4b17-b3f8-939c7e03ffe8", 1 },
                    { "67be34c7-cb54-4d6c-b71b-4aa27627a17b", "fa695188-522a-4aed-a82b-f348673913a9", "c63325a5-52b0-4624-a823-41e5c097cedd", 1 },
                    { "90541aa0-d004-448a-94c6-f7d5e6c97824", "486a781b-066c-4e0a-b9c1-e31f7888391e", "c63325a5-52b0-4624-a823-41e5c097cedd", 1 },
                    { "abb04dac-2710-451d-80bc-bb64ddeab556", "e4512814-41a7-4724-ba67-877c4f1a137e", "c63325a5-52b0-4624-a823-41e5c097cedd", 1 }
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
