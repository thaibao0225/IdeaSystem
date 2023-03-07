using IdeaSystem.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Emit;

namespace IdeaSystem.Configurations
{
    public class CommentConfigurations : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment");
            builder.HasKey(t => new { t.cmt_Id });

            builder.HasOne(t => t.users).WithMany(ur => ur.commentList)
                .HasForeignKey(pc => pc.cmt_UserId).OnDelete(DeleteBehavior.ClientSetNull);


            builder.HasOne(t => t.Idea).WithMany(ur => ur.commentList)
                .HasForeignKey(pc => pc.cmt_IdeaId).OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
