using IdeaSystem.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IdeaSystem.Configurations
{
    public class ReactConfigurations : IEntityTypeConfiguration<React>
    {
        public void Configure(EntityTypeBuilder<React> builder)
        {
            builder.ToTable("React");
            builder.HasKey(t => new { t.react_Id});

            builder.HasOne(t => t.users).WithMany(ur => ur.reactList)
                .HasForeignKey(pc => pc.react_UserId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(t => t.Idea).WithMany(ur => ur.reactList)
                .HasForeignKey(pc => pc.react_IdeadId).OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
