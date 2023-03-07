using IdeaSystem.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IdeaSystem.Configurations
{
    public class IdeaConfigurations : IEntityTypeConfiguration<Idea>
    {
        public void Configure(EntityTypeBuilder<Idea> builder)
        {
            builder.ToTable("Idea");
            builder.HasKey(t => new { t.idea_Id });

            builder.HasOne(t => t.users).WithMany(ur => ur.ideaList)
                .HasForeignKey(pc => pc.idea_UserId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(t => t.category).WithMany(ur => ur.ideaList)
                .HasForeignKey(pc => pc.idea_CategoryId).OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(t => t.topic).WithMany(ur => ur.ideaList)
                .HasForeignKey(pc => pc.idea_Topic).OnDelete(DeleteBehavior.ClientSetNull);



        }
    }
}
