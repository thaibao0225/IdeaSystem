using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using IdeaSystem.Entities;

namespace IdeaSystem.Configurations
{
    public class TopicsCongifurations : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable("Topic");
            builder.HasKey(t => new { t.topic_Id });


        }
    }
}
