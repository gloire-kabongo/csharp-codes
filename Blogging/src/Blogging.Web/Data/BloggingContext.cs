using System;
using System.Reflection;
using Blogging.Logic.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blogging.Data
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly()
            );

            //base.OnModelCreating(modelBuilder);
        }
    }
}
