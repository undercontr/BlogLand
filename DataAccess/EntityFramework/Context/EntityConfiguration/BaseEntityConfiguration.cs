using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CommonTypes.Entities;

namespace DataAccess.EntityFramework.Context.EntityConfiguration
{
    public class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity, new()
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.IsActive).HasDefaultValue(true);
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);

            builder.HasQueryFilter(p => p.IsActive == true);
            builder.HasQueryFilter(p => p.IsDeleted == false);

            //CreatedOn and UpdatedOn columns are filled in BlogContext.SaveChanges().
        }

    }

}
