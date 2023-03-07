using IdeaSystem.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdeaSystem.Entities;

namespace IdeaSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }



            builder.ApplyConfiguration(new UserConfigurations());
            builder.ApplyConfiguration(new RoleConfigurations());
            builder.ApplyConfiguration(new CategoryConfigurations());
            builder.ApplyConfiguration(new CommentConfigurations());
            builder.ApplyConfiguration(new DepartmentConfigurations());
            builder.ApplyConfiguration(new IdeaConfigurations());
            builder.ApplyConfiguration(new ReactConfigurations());
            builder.ApplyConfiguration(new TopicsCongifurations());
            builder.ApplyConfiguration(new ViewConfigurations());





            builder.Seed();
        }

        public DbSet<User> UserTable { set; get; }
        public DbSet<Role> RoleTable { set; get; }
        public DbSet<Category> CategoryTable { set; get; }
        public DbSet<Comment> CommentTable { set; get; }
        public DbSet<Department> DepartmentTable { set; get; }
        public DbSet<Idea> IdeaTable { set; get; }
        public DbSet<React> ReactTable { set; get; }
        public DbSet<Topic> TopicTable { set; get; }
        public DbSet<View> ViewTable { set; get; }

    }
}