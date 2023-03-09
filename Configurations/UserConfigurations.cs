using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using IdeaSystem.Entities;

namespace IdeaSystem.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasOne(t => t.user_Department).WithMany(ur => ur.userList)
                .HasForeignKey(pc => pc.user_DepartmentId).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
