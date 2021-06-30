using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework.Context.EntityConfiguration
{
    public class AppUserEntityConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Email)
               .HasMaxLength(150)
               .IsRequired();
            builder.Property(p => p.Username)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
