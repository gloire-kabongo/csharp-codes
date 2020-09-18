using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Blogging.Logic.Entities;

namespace Blogging.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("t_posts");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("post_id");
            builder.Property(t => t.Title).HasColumnName("title");
            builder.Property(t => t.Body).HasColumnName("body");
        }
    }
}