using IdeaSystem.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdeaSystem.Data
{
    public static class Database
    {
        public static void Seed(this ModelBuilder builder)
        {
            //Table Department
            var IdDepartment1 = Guid.NewGuid().ToString();
            var IdDepartment2 = Guid.NewGuid().ToString();
            var IdDepartment3 = Guid.NewGuid().ToString();

            builder.Entity<Department>().HasData(
                new Department()
                {
                    department_Id = IdDepartment1,
                    department_Name = "NameDepartment1",
                    department_IsDelete = true
                },
                new Department()
                {
                    department_Id = IdDepartment2,
                    department_Name = "NameDepartment2",
                    department_IsDelete = true
                },
                new Department()
                {
                    department_Id = IdDepartment3,
                    department_Name = "NameDepartment3",
                    department_IsDelete = true
                });

            //Table AppRole
            string IdRoleStaff = "8B6B7FA7-220D-427F-AF15-57DE6EF686C6";
            var IdRoleAdmin = "23628387-4AD3-4A03-993B-1ECF0F030CB3";


            builder.Entity<Role>().HasData(
                new Role()
                {
                    Id = IdRoleStaff,
                    Name = "Staff",
                    NormalizedName = "staff",
                    role_IsDelete = true
                },
                new Role()
                {
                    Id = IdRoleAdmin,
                    Name = "Admin",
                    NormalizedName = "admin",
                    role_IsDelete = true
                });




            //Table AppUser 
            var IdStaff = Guid.NewGuid().ToString();
            var IdAdmin = Guid.NewGuid().ToString();

            var hasher = new PasswordHasher<User>();
            builder.Entity<User>().HasData(
            new User
            {
                Id = IdAdmin,
                UserName = "Admin",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                user_DepartmentId = IdDepartment1
                //FirstName = "admin",
                //LastName = "admin",
                //DoB = new DateTime(2020, 01, 02)
            },
            new User
            {
                Id = IdStaff,
                UserName = "Staff",
                NormalizedUserName = "STAFF@GMAIL.COM",
                NormalizedEmail = "STAFF@GMAIL.COM",
                Email = "staff@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                user_DepartmentId = IdDepartment2
                //FirstName = "staff",
                //LastName = "staff",
                //DoB = new DateTime(2020, 03, 02)
            });


            //Table AppUser - role 
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = IdRoleStaff,
                UserId = IdStaff
            },
            new IdentityUserRole<string>
            {
                RoleId = IdRoleAdmin,
                UserId = IdAdmin
            });

            // Topic Table
            var IdTopic1 = Guid.NewGuid().ToString();
            var IdTopic2 = Guid.NewGuid().ToString();
            var IdTopic3 = Guid.NewGuid().ToString();
            var IdTopic4 = Guid.NewGuid().ToString();
            var IdTopic5 = Guid.NewGuid().ToString();

            builder.Entity<Topic>().HasData(
                new Topic
                {
                    topic_Id = IdTopic1,
                    topic_Name = "Topic 1",
                    topic_ClosureDate = new DateTime(2020, 01, 02),
                    topic_FinalClosureDate = new DateTime(2020, 01, 09)
                },
                new Topic
                {
                    topic_Id = IdTopic2,
                    topic_Name = "Topic 2",
                    topic_ClosureDate = new DateTime(2020, 01, 02),
                    topic_FinalClosureDate = new DateTime(2020, 01, 09)
                },
                new Topic
                {
                    topic_Id = IdTopic3,
                    topic_Name = "Topic 3",
                    topic_ClosureDate = new DateTime(2020, 01, 02),
                    topic_FinalClosureDate = new DateTime(2020, 01, 09)
                },
                new Topic
                {
                    topic_Id = IdTopic4,
                    topic_Name = "Topic 4",
                    topic_ClosureDate = new DateTime(2020, 01, 02),
                    topic_FinalClosureDate = new DateTime(2020, 01, 09)
                },
                new Topic
                {
                    topic_Id = IdTopic5,
                    topic_Name = "Topic 5",
                    topic_ClosureDate = new DateTime(2020, 01, 02),
                    topic_FinalClosureDate = new DateTime(2020, 01, 09)
                });

            //Table Category
            var IdCategory1 = Guid.NewGuid().ToString();
            var IdCategory2 = Guid.NewGuid().ToString();


            builder.Entity<Category>().HasData(
                new Category()
                {
                    category_Id = IdCategory1,
                    category_Name = "Category1",
                    category_IsDelete = true
                },
                new Category()
                {
                    category_Id = IdCategory2,
                    category_Name = "Category2",
                    category_IsDelete = true
                });

            //Table Idea
            var IdIdea1 = Guid.NewGuid().ToString();
            var IdIdea2 = Guid.NewGuid().ToString();
            var IdIdea3 = Guid.NewGuid().ToString();

            builder.Entity<Idea>().HasData(
                new Idea()
                {
                    idea_Id = IdIdea1,
                    idea_Text = "Idea 1",
                    idea_FilePath = "FilePath1",
                    idea_DateTime = new DateTime(2020, 01, 09),
                    idea_UserId = IdStaff,
                    idea_CategoryId = IdCategory1,
                    idea_Topic = IdTopic1,
                    idea_IsDelete = true

                },
                new Idea()
                {
                    idea_Id = IdIdea2,
                    idea_Text = "Idea 2",
                    idea_FilePath = "FilePath2",
                    idea_DateTime = new DateTime(2020, 01, 09),
                    idea_UserId = IdStaff,
                    idea_CategoryId = IdCategory2,
                    idea_Topic = IdTopic2,
                    idea_IsDelete = true

                });

            //Table Comment
            var IdComment1 = Guid.NewGuid().ToString();
            var IdComment2 = Guid.NewGuid().ToString();


            builder.Entity<Comment>().HasData(
                new Comment()
                {
                    cmt_Id = IdComment1,
                    cmt_Text = "Commnet 1",
                    cmt_Datetime = new DateTime(2020, 01, 09),
                    cmt_UserId = IdStaff,
                    cmt_IdeaId = IdIdea1,
                    cmt_IsDelete = true
                });

            //Table React
            var IdReact1 = Guid.NewGuid().ToString();
            var IdReact2 = Guid.NewGuid().ToString();


            builder.Entity<React>().HasData(
                new React()
                {
                    react_Id = IdReact1,
                    react_React = -1,
                    react_UserId = IdStaff,
                    react_IdeadId = IdIdea1
                },
                new React()
                {
                    react_Id = IdReact2,
                    react_React = -1,
                    react_UserId = IdAdmin,
                    react_IdeadId = IdIdea1
                });

            //Table React
            var IdView1 = Guid.NewGuid().ToString();
            var IdView2 = Guid.NewGuid().ToString();


            builder.Entity<View>().HasData(
                new View()
                {
                    view_Id = IdView1,
                    view_VisitTime = 0,
                    view_IdeadId = IdIdea1,
                    view_UserId = IdStaff
                });
        }
    }
}