﻿// <auto-generated />
using System;
using IdeaSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IdeaSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IdeaSystem.Entities.Category", b =>
                {
                    b.Property<string>("category_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("category_IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("category_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("category_Id");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            category_Id = "a06ab48a-f7b8-408f-92fa-09f294a61aa4",
                            category_IsDelete = false,
                            category_Name = "Category1"
                        },
                        new
                        {
                            category_Id = "ae1f2e7b-25a1-4bea-a95e-4ba67953d5c9",
                            category_IsDelete = false,
                            category_Name = "Category2"
                        });
                });

            modelBuilder.Entity("IdeaSystem.Entities.Comment", b =>
                {
                    b.Property<string>("cmt_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("cmt_Datetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("cmt_IdeaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("cmt_IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("cmt_Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cmt_UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("cmt_Id");

                    b.HasIndex("cmt_IdeaId");

                    b.HasIndex("cmt_UserId");

                    b.ToTable("Comment", (string)null);

                    b.HasData(
                        new
                        {
                            cmt_Id = "08329150-be4f-47d3-8ce9-ea1d9afe8e18",
                            cmt_Datetime = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_IdeaId = "b38290a7-b180-4626-baa9-642d4d088fd9",
                            cmt_IsDelete = false,
                            cmt_Text = "Commnet 1",
                            cmt_UserId = "c8d995b5-ecc4-4a37-812d-5a6e654255a8"
                        },
                        new
                        {
                            cmt_Id = "f16f94f7-12c6-412e-9fa5-8dffcf9434cf",
                            cmt_Datetime = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_IdeaId = "45d25248-ad2f-4358-98b2-b7b46143011e",
                            cmt_IsDelete = false,
                            cmt_Text = "Commnet 2",
                            cmt_UserId = "c8d995b5-ecc4-4a37-812d-5a6e654255a8"
                        });
                });

            modelBuilder.Entity("IdeaSystem.Entities.Department", b =>
                {
                    b.Property<string>("department_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("department_IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("department_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("department_Id");

                    b.ToTable("Department", (string)null);

                    b.HasData(
                        new
                        {
                            department_Id = "d05e1e31-75c0-4a6c-a428-fa885dbe860a",
                            department_IsDelete = false,
                            department_Name = "NameDepartment1"
                        },
                        new
                        {
                            department_Id = "e9660754-a92a-483e-b687-9adaec469457",
                            department_IsDelete = false,
                            department_Name = "NameDepartment2"
                        },
                        new
                        {
                            department_Id = "fd477db4-c6e1-4349-ad6d-7f72c91cd256",
                            department_IsDelete = false,
                            department_Name = "NameDepartment3"
                        });
                });

            modelBuilder.Entity("IdeaSystem.Entities.Idea", b =>
                {
                    b.Property<string>("idea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("idea_DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("idea_FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("idea_IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("idea_Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_TopicId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("idea_Id");

                    b.HasIndex("idea_CategoryId");

                    b.HasIndex("idea_TopicId");

                    b.HasIndex("idea_UserId");

                    b.ToTable("Idea", (string)null);

                    b.HasData(
                        new
                        {
                            idea_Id = "b38290a7-b180-4626-baa9-642d4d088fd9",
                            idea_CategoryId = "a06ab48a-f7b8-408f-92fa-09f294a61aa4",
                            idea_DateTime = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_FilePath = "FilePath1",
                            idea_IsDelete = false,
                            idea_Text = "Idea 1",
                            idea_TopicId = "c9454b78-be90-4abd-945f-6df1810dfd13",
                            idea_UserId = "c8d995b5-ecc4-4a37-812d-5a6e654255a8"
                        },
                        new
                        {
                            idea_Id = "08a79142-2e81-489f-948c-8c154552ea20",
                            idea_CategoryId = "ae1f2e7b-25a1-4bea-a95e-4ba67953d5c9",
                            idea_DateTime = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_FilePath = "FilePath2",
                            idea_IsDelete = false,
                            idea_Text = "Idea 2",
                            idea_TopicId = "ed00a7c2-947e-4dd5-9378-73a73a65adca",
                            idea_UserId = "c8d995b5-ecc4-4a37-812d-5a6e654255a8"
                        },
                        new
                        {
                            idea_Id = "45d25248-ad2f-4358-98b2-b7b46143011e",
                            idea_CategoryId = "ae1f2e7b-25a1-4bea-a95e-4ba67953d5c9",
                            idea_DateTime = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_FilePath = "FilePath3",
                            idea_IsDelete = false,
                            idea_Text = "Idea 3",
                            idea_TopicId = "c9454b78-be90-4abd-945f-6df1810dfd13",
                            idea_UserId = "c63325a5-52b0-4624-a823-41e5c097cedd"
                        });
                });

            modelBuilder.Entity("IdeaSystem.Entities.React", b =>
                {
                    b.Property<string>("react_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("react_IdeadId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("react_React")
                        .HasColumnType("int");

                    b.Property<string>("react_UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("react_Id");

                    b.HasIndex("react_IdeadId");

                    b.HasIndex("react_UserId");

                    b.ToTable("React", (string)null);

                    b.HasData(
                        new
                        {
                            react_Id = "9c3d0883-f786-44e4-9a03-7e1dd0849340",
                            react_IdeadId = "b38290a7-b180-4626-baa9-642d4d088fd9",
                            react_React = -1,
                            react_UserId = "c8d995b5-ecc4-4a37-812d-5a6e654255a8"
                        },
                        new
                        {
                            react_Id = "247ce902-03ef-4022-869d-6dd064be1e30",
                            react_IdeadId = "45d25248-ad2f-4358-98b2-b7b46143011e",
                            react_React = -1,
                            react_UserId = "c63325a5-52b0-4624-a823-41e5c097cedd"
                        },
                        new
                        {
                            react_Id = "09aeea8e-a544-4b25-90e3-dfa140087d76",
                            react_IdeadId = "b38290a7-b180-4626-baa9-642d4d088fd9",
                            react_React = 1,
                            react_UserId = "c63325a5-52b0-4624-a823-41e5c097cedd"
                        });
                });

            modelBuilder.Entity("IdeaSystem.Entities.Topic", b =>
                {
                    b.Property<string>("topic_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("topic_ClosureDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("topic_FinalClosureDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("topic_IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("topic_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("topic_Id");

                    b.ToTable("Topic", (string)null);

                    b.HasData(
                        new
                        {
                            topic_Id = "c9454b78-be90-4abd-945f-6df1810dfd13",
                            topic_ClosureDate = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_FinalClosureDate = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_IsDelete = false,
                            topic_Name = "Topic 1"
                        },
                        new
                        {
                            topic_Id = "ed00a7c2-947e-4dd5-9378-73a73a65adca",
                            topic_ClosureDate = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_FinalClosureDate = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_IsDelete = false,
                            topic_Name = "Topic 2"
                        },
                        new
                        {
                            topic_Id = "42d96189-0737-4c0a-aaa0-6f2e83fa8131",
                            topic_ClosureDate = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_FinalClosureDate = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_IsDelete = false,
                            topic_Name = "Topic 3"
                        },
                        new
                        {
                            topic_Id = "c80aa982-7c2d-4796-a053-3e413c0a7f63",
                            topic_ClosureDate = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_FinalClosureDate = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_IsDelete = false,
                            topic_Name = "Topic 4"
                        },
                        new
                        {
                            topic_Id = "f2cdf913-3b0b-42c0-8e31-0cb16b418125",
                            topic_ClosureDate = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_FinalClosureDate = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_IsDelete = false,
                            topic_Name = "Topic 5"
                        });
                });

            modelBuilder.Entity("IdeaSystem.Entities.View", b =>
                {
                    b.Property<string>("view_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("view_IdeadId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("view_UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("view_VisitTime")
                        .HasColumnType("int");

                    b.HasKey("view_Id");

                    b.HasIndex("view_IdeadId");

                    b.HasIndex("view_UserId");

                    b.ToTable("View", (string)null);

                    b.HasData(
                        new
                        {
                            view_Id = "a7492bd2-fef9-4f75-9bd5-a97b16298430",
                            view_IdeadId = "b38290a7-b180-4626-baa9-642d4d088fd9",
                            view_UserId = "c8d995b5-ecc4-4a37-812d-5a6e654255a8",
                            view_VisitTime = 1
                        },
                        new
                        {
                            view_Id = "3eb492a6-8f8e-4768-86e3-6ce9b985e543",
                            view_IdeadId = "45d25248-ad2f-4358-98b2-b7b46143011e",
                            view_UserId = "c63325a5-52b0-4624-a823-41e5c097cedd",
                            view_VisitTime = 1
                        },
                        new
                        {
                            view_Id = "7286a0f3-6d32-4543-88be-ed00c0722135",
                            view_IdeadId = "b38290a7-b180-4626-baa9-642d4d088fd9",
                            view_UserId = "c63325a5-52b0-4624-a823-41e5c097cedd",
                            view_VisitTime = 1
                        });
                });

            modelBuilder.Entity("IdeaSystem.Models.UserModel", b =>
                {
                    b.Property<string>("user_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("user_IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("user_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_RoleIdNew")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("user_Id");

                    b.ToTable("UserModel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "c8d995b5-ecc4-4a37-812d-5a6e654255a8",
                            RoleId = "8B6B7FA7-220D-427F-AF15-57DE6EF686C6"
                        },
                        new
                        {
                            UserId = "c63325a5-52b0-4624-a823-41e5c097cedd",
                            RoleId = "23628387-4AD3-4A03-993B-1ECF0F030CB3"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("IdeaSystem.Entities.Role", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<bool>("role_IsDelete")
                        .HasColumnType("bit");

                    b.ToTable("Roles");

                    b.HasDiscriminator().HasValue("Role");

                    b.HasData(
                        new
                        {
                            Id = "8B6B7FA7-220D-427F-AF15-57DE6EF686C6",
                            ConcurrencyStamp = "d8204fdf-809a-4ec4-a78e-a130c63cf385",
                            Name = "Staff",
                            NormalizedName = "staff",
                            role_IsDelete = false
                        },
                        new
                        {
                            Id = "23628387-4AD3-4A03-993B-1ECF0F030CB3",
                            ConcurrencyStamp = "f0980b80-27ed-48d8-84ab-c7c7a0f0fdd8",
                            Name = "Admin",
                            NormalizedName = "admin",
                            role_IsDelete = false
                        });
                });

            modelBuilder.Entity("IdeaSystem.Entities.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("user_DepartmentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("user_DepartmentId");

                    b.ToTable("Users");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = "c63325a5-52b0-4624-a823-41e5c097cedd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a2363135-7015-4914-a52f-212676872637",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPWnqKPk//Fvn4N5CXuXvko+eH90EvWOthH9m6FMlzSe5IA+xzZuh1OnKSTDvFmw7A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "575539a7-058b-4d6c-b2ab-7e435d8d071a",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com",
                            user_DepartmentId = "d05e1e31-75c0-4a6c-a428-fa885dbe860a"
                        },
                        new
                        {
                            Id = "c8d995b5-ecc4-4a37-812d-5a6e654255a8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "34b64e2d-b378-4ebb-a7d7-b1068b44b2c4",
                            Email = "staff@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF@GMAIL.COM",
                            NormalizedUserName = "STAFF@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJcHqkSZhEPRj98oUSzdEeDHrlqIdRrd6yIrNI5+pnzge4gC1t6CVlKsuL4zL8PSmw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "528f6296-be5c-43ab-885f-6c0a5456293b",
                            TwoFactorEnabled = false,
                            UserName = "staff@gmail.com",
                            user_DepartmentId = "e9660754-a92a-483e-b687-9adaec469457"
                        });
                });

            modelBuilder.Entity("IdeaSystem.Entities.Comment", b =>
                {
                    b.HasOne("IdeaSystem.Entities.Idea", "Idea")
                        .WithMany("commentList")
                        .HasForeignKey("cmt_IdeaId")
                        .IsRequired();

                    b.HasOne("IdeaSystem.Entities.User", "users")
                        .WithMany("commentList")
                        .HasForeignKey("cmt_UserId")
                        .IsRequired();

                    b.Navigation("Idea");

                    b.Navigation("users");
                });

            modelBuilder.Entity("IdeaSystem.Entities.Idea", b =>
                {
                    b.HasOne("IdeaSystem.Entities.Category", "category")
                        .WithMany("ideaList")
                        .HasForeignKey("idea_CategoryId")
                        .IsRequired();

                    b.HasOne("IdeaSystem.Entities.Topic", "topic")
                        .WithMany("ideaList")
                        .HasForeignKey("idea_TopicId")
                        .IsRequired();

                    b.HasOne("IdeaSystem.Entities.User", "users")
                        .WithMany("ideaList")
                        .HasForeignKey("idea_UserId")
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("topic");

                    b.Navigation("users");
                });

            modelBuilder.Entity("IdeaSystem.Entities.React", b =>
                {
                    b.HasOne("IdeaSystem.Entities.Idea", "Idea")
                        .WithMany("reactList")
                        .HasForeignKey("react_IdeadId")
                        .IsRequired();

                    b.HasOne("IdeaSystem.Entities.User", "users")
                        .WithMany("reactList")
                        .HasForeignKey("react_UserId")
                        .IsRequired();

                    b.Navigation("Idea");

                    b.Navigation("users");
                });

            modelBuilder.Entity("IdeaSystem.Entities.View", b =>
                {
                    b.HasOne("IdeaSystem.Entities.Idea", "Idea")
                        .WithMany("viewList")
                        .HasForeignKey("view_IdeadId")
                        .IsRequired();

                    b.HasOne("IdeaSystem.Entities.User", "users")
                        .WithMany("viewList")
                        .HasForeignKey("view_UserId")
                        .IsRequired();

                    b.Navigation("Idea");

                    b.Navigation("users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IdeaSystem.Entities.User", b =>
                {
                    b.HasOne("IdeaSystem.Entities.Department", "user_Department")
                        .WithMany("userList")
                        .HasForeignKey("user_DepartmentId")
                        .IsRequired();

                    b.Navigation("user_Department");
                });

            modelBuilder.Entity("IdeaSystem.Entities.Category", b =>
                {
                    b.Navigation("ideaList");
                });

            modelBuilder.Entity("IdeaSystem.Entities.Department", b =>
                {
                    b.Navigation("userList");
                });

            modelBuilder.Entity("IdeaSystem.Entities.Idea", b =>
                {
                    b.Navigation("commentList");

                    b.Navigation("reactList");

                    b.Navigation("viewList");
                });

            modelBuilder.Entity("IdeaSystem.Entities.Topic", b =>
                {
                    b.Navigation("ideaList");
                });

            modelBuilder.Entity("IdeaSystem.Entities.User", b =>
                {
                    b.Navigation("commentList");

                    b.Navigation("ideaList");

                    b.Navigation("reactList");

                    b.Navigation("viewList");
                });
#pragma warning restore 612, 618
        }
    }
}
