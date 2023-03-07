﻿// <auto-generated />
using System;
using IdeaSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IdeaSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230307173456_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
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
                            department_Id = "132c67f1-5969-422a-91db-192e00e7b048",
                            department_IsDelete = false,
                            department_Name = "NameDepartment1"
                        },
                        new
                        {
                            department_Id = "245f76a9-4c27-436f-921d-ebd6767c3215",
                            department_IsDelete = false,
                            department_Name = "NameDepartment2"
                        },
                        new
                        {
                            department_Id = "75de1a73-3329-4b6f-819f-03721ad3cd8c",
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

                    b.Property<string>("idea_Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idea_UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("idea_Id");

                    b.HasIndex("idea_CategoryId");

                    b.HasIndex("idea_Topic");

                    b.HasIndex("idea_UserId");

                    b.ToTable("Idea", (string)null);
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
                });

            modelBuilder.Entity("IdeaSystem.Entities.Topic", b =>
                {
                    b.Property<string>("topic_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("topic_ClosureDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("topic_FinalClosureDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("topic_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("topic_Id");

                    b.ToTable("Topic", (string)null);
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
                            ConcurrencyStamp = "287cc878-9e35-4f9a-b5c2-438dcadde7a5",
                            Name = "Staff",
                            NormalizedName = "staff",
                            role_IsDelete = false
                        },
                        new
                        {
                            Id = "23628387-4AD3-4A03-993B-1ECF0F030CB3",
                            ConcurrencyStamp = "f830419c-ff71-477a-888b-f4f490041bda",
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
                        .HasForeignKey("idea_Topic")
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
