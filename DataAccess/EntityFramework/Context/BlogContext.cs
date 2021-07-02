using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Core.CommonTypes.Entities;
using DataAccess.EntityFramework.Context.EntityConfiguration;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataAccess.EntityFramework.Context
{
    public class BlogContext : DbContext
    {

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Post>(new BaseEntityConfiguration<Post>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=BlogLandDb;Trusted_Connection=true");
        }

        // overriding SaveChanges method to set default values for DateTime properties
        public override int SaveChanges()
        {
            DateTime currentTimestamp = DateTime.Now;

            IEnumerable<EntityEntry<BaseEntity>> entries = ChangeTracker.Entries<BaseEntity>();

            foreach (var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Property(p => p.CreatedOn).CurrentValue = currentTimestamp;
                        break;
                    case EntityState.Modified:
                        entry.Property(p => p.UpdatedOn).CurrentValue = currentTimestamp;
                        break;
                    default:
                        break;
                }
            }

            return base.SaveChanges();
        }
    }
}
