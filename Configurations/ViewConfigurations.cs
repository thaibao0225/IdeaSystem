using IdeaSystem.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IdeaSystem.Configurations
{
    public class ViewConfigurations : IEntityTypeConfiguration<View>
    {
        public void Configure(EntityTypeBuilder<View> builder)
        {
            builder.ToTable("View");
            builder.HasKey(t => new { t.view_Id });

            builder.HasOne(t => t.users).WithMany(ur => ur.viewList)
                .HasForeignKey(pc => pc.view_UserId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(t => t.Idea).WithMany(ur => ur.viewList)
                .HasForeignKey(pc => pc.view_IdeadId).OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
