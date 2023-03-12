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
                    department_IsDelete = false
                },
                new Department()
                {
                    department_Id = IdDepartment2,
                    department_Name = "NameDepartment2",
                    department_IsDelete = false
                },
                new Department()
                {
                    department_Id = IdDepartment3,
                    department_Name = "NameDepartment3",
                    department_IsDelete = false
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
                    role_IsDelete = false
                },
                new Role()
                {
                    Id = IdRoleAdmin,
                    Name = "Admin",
                    NormalizedName = "admin",
                    role_IsDelete = false
                });




            //Table AppUser 
            var IdStaff = Guid.NewGuid().ToString();
            var IdAdmin = "c63325a5-52b0-4624-a823-41e5c097cedd";

            var hasher = new PasswordHasher<User>();
            builder.Entity<User>().HasData(
            new User
            {
                Id = IdAdmin,
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                user_DepartmentId = IdDepartment1,
                
                //FirstName = "admin",
                //LastName = "admin",
                //DoB = new DateTime(2020, 01, 02)
            },
            new User
            {
                Id = IdStaff,
                UserName = "staff@gmail.com",
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
                    category_IsDelete = false
                },
                new Category()
                {
                    category_Id = IdCategory2,
                    category_Name = "Category2",
                    category_IsDelete = false
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
                    idea_Name = "Idea 1",
                    idea_FilePath = "FilePath1",
                    idea_FileName = "FilePath1",
                    idea_DateTime = new DateTime(2020, 01, 09),
                    idea_UserId = IdStaff,
                    idea_CategoryId = IdCategory1,
                    idea_TopicId = IdTopic1,
                    idea_IsDelete = false

                },
                new Idea()
                {
                    idea_Id = IdIdea2,
                    idea_Text = "Idea 2",
                    idea_Name = "Idea 2",
                    idea_FilePath = "FilePath2",
                    idea_FileName = "FilePath2",
                    idea_DateTime = new DateTime(2020, 01, 09),
                    idea_UserId = IdStaff,
                    idea_CategoryId = IdCategory2,
                    idea_TopicId = IdTopic2,
                    idea_IsDelete = false

                },
                new Idea()
                {
                    idea_Id = IdIdea3,
                    idea_Text = "Idea 3",
                    idea_Name = "Idea 3",
                    idea_FilePath = "FilePath3",
                    idea_FileName = "FilePath3",
                    idea_DateTime = new DateTime(2020, 01, 09),
                    idea_UserId = IdAdmin,
                    idea_CategoryId = IdCategory2,
                    idea_TopicId = IdTopic1,
                    idea_IsDelete = false

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
                    cmt_IsDelete = false
                },
                new Comment()
                {
                    cmt_Id = IdComment2,
                    cmt_Text = "Commnet 2",
                    cmt_Datetime = new DateTime(2020, 01, 09),
                    cmt_UserId = IdStaff,
                    cmt_IdeaId = IdIdea3,
                    cmt_IsDelete = false
                });

            //Table React
            var IdReact1 = Guid.NewGuid().ToString();
            var IdReact2 = Guid.NewGuid().ToString();
            var IdReact3 = Guid.NewGuid().ToString();


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
                    react_IdeadId = IdIdea3
                },
                new React()
                {
                    react_Id = IdReact3,
                    react_React = 1,
                    react_UserId = IdAdmin,
                    react_IdeadId = IdIdea1
                });

            //Table React
            var IdView1 = Guid.NewGuid().ToString();
            var IdView2 = Guid.NewGuid().ToString();
            var IdView3 = Guid.NewGuid().ToString();


            builder.Entity<View>().HasData(
                new View()
                {
                    view_Id = IdView1,
                    view_VisitTime = 1,
                    view_IdeadId = IdIdea1,
                    view_UserId = IdStaff
                },
                new View()
                {
                    view_Id = IdView2,
                    view_VisitTime = 1,
                    view_IdeadId = IdIdea3,
                    view_UserId = IdAdmin
                },
                new View()
                {
                    view_Id = IdView3,
                    view_VisitTime = 1,
                    view_IdeadId = IdIdea1,
                    view_UserId = IdAdmin
                });
        }
    }
}