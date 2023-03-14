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
                            category_Id = "a4cb1c23-1380-4ca3-b573-258162cfd3b2",
                            category_IsDelete = false,
                            category_Name = "Category1"
                        },
                        new
                        {
                            category_Id = "bc397ed8-b36a-4230-bd99-dc7790b2e60d",
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
                            cmt_Id = "4ee8fcf2-a555-4115-a18c-ed8def491420",
                            cmt_Datetime = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_IdeaId = "a6677c95-a3fc-46aa-956d-366045edca54",
                            cmt_IsDelete = false,
                            cmt_Text = "Commnet 1",
                            cmt_UserId = "668cbb00-b970-478a-835d-697a046c95cd"
                        },
                        new
                        {
                            cmt_Id = "2e36b83c-bbcd-4fed-bc55-7b735306fde7",
                            cmt_Datetime = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            cmt_IdeaId = "94086978-23c4-4c2b-9c9f-4d81b3a2bf42",
                            cmt_IsDelete = false,
                            cmt_Text = "Commnet 2",
                            cmt_UserId = "668cbb00-b970-478a-835d-697a046c95cd"
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
                            department_Id = "fea443ce-fe5f-4aa5-b2e4-007eadab28ac",
                            department_IsDelete = false,
                            department_Name = "NameDepartment1"
                        },
                        new
                        {
                            department_Id = "590e133f-52bf-4f93-9646-23c45a119cef",
                            department_IsDelete = false,
                            department_Name = "NameDepartment2"
                        },
                        new
                        {
                            department_Id = "9f18b5cb-2e33-47d3-aea3-26991e4f0d14",
                            department_IsDelete = false,
                            department_Name = "NameDepartment3"
                        });
                });

            modelBuilder.Entity("IdeaSystem.Entities.Idea", b =>
                {
                    b.Property<string>("idea_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("idea_Agree")
                        .HasColumnType("bit");

                    b.Property<string>("idea_CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("idea_DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("idea_FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idea_FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("idea_IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("idea_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            idea_Id = "a6677c95-a3fc-46aa-956d-366045edca54",
                            idea_Agree = false,
                            idea_CategoryId = "a4cb1c23-1380-4ca3-b573-258162cfd3b2",
                            idea_DateTime = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_FileName = "FilePath1",
                            idea_FilePath = "FilePath1",
                            idea_IsDelete = false,
                            idea_Name = "Idea 1",
                            idea_Text = "Idea 1",
                            idea_TopicId = "23df84a6-0575-4bb7-aef4-4c46e19a1b0e",
                            idea_UserId = "668cbb00-b970-478a-835d-697a046c95cd"
                        },
                        new
                        {
                            idea_Id = "7f3f5bfb-be23-4d05-97fd-1093012bd934",
                            idea_Agree = false,
                            idea_CategoryId = "bc397ed8-b36a-4230-bd99-dc7790b2e60d",
                            idea_DateTime = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_FileName = "FilePath2",
                            idea_FilePath = "FilePath2",
                            idea_IsDelete = false,
                            idea_Name = "Idea 2",
                            idea_Text = "Idea 2",
                            idea_TopicId = "463b097c-1681-4d56-ad0c-fa3badad88d2",
                            idea_UserId = "668cbb00-b970-478a-835d-697a046c95cd"
                        },
                        new
                        {
                            idea_Id = "94086978-23c4-4c2b-9c9f-4d81b3a2bf42",
                            idea_Agree = false,
                            idea_CategoryId = "bc397ed8-b36a-4230-bd99-dc7790b2e60d",
                            idea_DateTime = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            idea_FileName = "FilePath3",
                            idea_FilePath = "FilePath3",
                            idea_IsDelete = false,
                            idea_Name = "Idea 3",
                            idea_Text = "Idea 3",
                            idea_TopicId = "23df84a6-0575-4bb7-aef4-4c46e19a1b0e",
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
                            react_Id = "43da03e4-345c-4611-9097-4a23680b3940",
                            react_IdeadId = "a6677c95-a3fc-46aa-956d-366045edca54",
                            react_React = -1,
                            react_UserId = "668cbb00-b970-478a-835d-697a046c95cd"
                        },
                        new
                        {
                            react_Id = "1bf13497-65e6-4e62-a8e3-925a22fb7f13",
                            react_IdeadId = "94086978-23c4-4c2b-9c9f-4d81b3a2bf42",
                            react_React = -1,
                            react_UserId = "c63325a5-52b0-4624-a823-41e5c097cedd"
                        },
                        new
                        {
                            react_Id = "0387f3d5-7ef3-4039-82cd-18c2ca81e003",
                            react_IdeadId = "a6677c95-a3fc-46aa-956d-366045edca54",
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
                            topic_Id = "23df84a6-0575-4bb7-aef4-4c46e19a1b0e",
                            topic_ClosureDate = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_FinalClosureDate = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_IsDelete = false,
                            topic_Name = "Topic 1"
                        },
                        new
                        {
                            topic_Id = "463b097c-1681-4d56-ad0c-fa3badad88d2",
                            topic_ClosureDate = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_FinalClosureDate = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_IsDelete = false,
                            topic_Name = "Topic 2"
                        },
                        new
                        {
                            topic_Id = "120dfdb6-3d00-48bb-86ff-46706a1c453e",
                            topic_ClosureDate = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_FinalClosureDate = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_IsDelete = false,
                            topic_Name = "Topic 3"
                        },
                        new
                        {
                            topic_Id = "d4cae51f-009e-46d2-bc65-ba5e599a4d43",
                            topic_ClosureDate = new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_FinalClosureDate = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            topic_IsDelete = false,
                            topic_Name = "Topic 4"
                        },
                        new
                        {
                            topic_Id = "54b02101-4e99-47a0-a6ad-1d76bfccb7fa",
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
                            view_Id = "7abc8c34-e8c8-46eb-a397-bfe60d5302bf",
                            view_IdeadId = "a6677c95-a3fc-46aa-956d-366045edca54",
                            view_UserId = "668cbb00-b970-478a-835d-697a046c95cd",
                            view_VisitTime = 1
                        },
                        new
                        {
                            view_Id = "c4a21117-5498-43f9-ae5b-47ff272d90f4",
                            view_IdeadId = "94086978-23c4-4c2b-9c9f-4d81b3a2bf42",
                            view_UserId = "c63325a5-52b0-4624-a823-41e5c097cedd",
                            view_VisitTime = 1
                        },
                        new
                        {
                            view_Id = "fee65d6a-a711-44b1-85b2-218d7861a7da",
                            view_IdeadId = "a6677c95-a3fc-46aa-956d-366045edca54",
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
                            UserId = "668cbb00-b970-478a-835d-697a046c95cd",
                            RoleId = "8B6B7FA7-220D-427F-AF15-57DE6EF686C6"
                        },
                        new
                        {
                            UserId = "c63325a5-52b0-4624-a823-41e5c097cedd",
                            RoleId = "23628387-4AD3-4A03-993B-1ECF0F030CB3"
                        },
                        new
                        {
                            UserId = "8587e1a0-3531-4072-a48d-a6467ceb9f46",
                            RoleId = "aa25bd75-d486-4868-b2c3-14d91caf6cad"
                        },
                        new
                        {
                            UserId = "c260f583-20b6-42bc-bd85-c70c86c1ae35",
                            RoleId = "8B6B7FA7-220D-427F-AF15-57DE6EF686C6"
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
                            ConcurrencyStamp = "0de9d631-7c3d-4ad9-ba77-04543cc8c17d",
                            Name = "Staff",
                            NormalizedName = "staff",
                            role_IsDelete = false
                        },
                        new
                        {
                            Id = "23628387-4AD3-4A03-993B-1ECF0F030CB3",
                            ConcurrencyStamp = "2cadd06c-4443-4eca-8dcf-7679faf642a9",
                            Name = "Admin",
                            NormalizedName = "admin",
                            role_IsDelete = false
                        },
                        new
                        {
                            Id = "aa25bd75-d486-4868-b2c3-14d91caf6cad",
                            ConcurrencyStamp = "28c922c5-b450-4305-a3fa-bbff7114d3b6",
                            Name = "Qa",
                            NormalizedName = "qa",
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
                            ConcurrencyStamp = "ef78221c-b663-40ea-a22d-20c68254c7f1",
                            Email = "admin@testgmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@TESTGMAIL.COM",
                            NormalizedUserName = "ADMIN@TESTGMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBtJze7Q5jgMmBCM1Xm36mZO4I4qsHB0g48cu2Acdf6zDi5BalKoqeNdC66SZi/Thw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7407d3bb-bf92-4005-b997-dc4aa9a1ae72",
                            TwoFactorEnabled = false,
                            UserName = "admin@testgmail.com",
                            user_DepartmentId = "fea443ce-fe5f-4aa5-b2e4-007eadab28ac"
                        },
                        new
                        {
                            Id = "668cbb00-b970-478a-835d-697a046c95cd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ccdfd84d-36af-4f7b-b3df-ba1ec25327a0",
                            Email = "staff@testgmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF@TESTGMAIL.COM",
                            NormalizedUserName = "STAFF@TESTGMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGgPpmffMCjbA7hVDJrxddePqWI/XtKooHe6ySlmxgz8T0AqSg5uQdczD9uvlbjWGA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "768f7278-a851-4cd9-82a4-2128293025f9",
                            TwoFactorEnabled = false,
                            UserName = "staff@testgmail.com",
                            user_DepartmentId = "590e133f-52bf-4f93-9646-23c45a119cef"
                        },
                        new
                        {
                            Id = "8587e1a0-3531-4072-a48d-a6467ceb9f46",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "31011b34-b3b3-444b-ab65-68f16dd74e8a",
                            Email = "qa@testgmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "QA@TESTGMAIL.COM",
                            NormalizedUserName = "QA@TESTGMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMakQtE6R8eK+o2IPUioso9VNILRAJzZM/GUbKf/HCpy+UEF8f39m4QfUrKMzZ2RDg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cf02f17d-fb22-435d-bae2-34fed006ee9b",
                            TwoFactorEnabled = false,
                            UserName = "qa@testgmail.com",
                            user_DepartmentId = "590e133f-52bf-4f93-9646-23c45a119cef"
                        },
                        new
                        {
                            Id = "c260f583-20b6-42bc-bd85-c70c86c1ae35",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b47c3bf7-8a41-43f1-9fdb-25a02bd75a3d",
                            Email = "staff2@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF2@TESTGMAIL.COM",
                            NormalizedUserName = "STAFF2@TESTGMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEN3buXiinVZsyWXDTSm/BzKzmRQo37D1zajTcOEWpYltF4I+yeWpWZ2sHxmRa+XPlg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6848c635-890f-4321-8783-c60eb080ba9d",
                            TwoFactorEnabled = false,
                            UserName = "staff2@testgmail.com",
                            user_DepartmentId = "590e133f-52bf-4f93-9646-23c45a119cef"
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
