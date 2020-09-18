using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogExemple.Models.Configurations
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

    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("t_comments");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("comment_id");
            builder.Property(t => t.Body).HasColumnName("body");
            builder.Property("PostId").HasColumnName("post_id");
        }
    }
}