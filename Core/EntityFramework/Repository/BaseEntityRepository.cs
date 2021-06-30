using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.CommonTypes.Entities;

namespace Core.EntityFramework.Repository
{
    public abstract class BaseEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var modifiedEntity = context.Entry(entity);
                modifiedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            TEntity entity;
            using (TContext context = new TContext())
            {
                entity = context.Set<TEntity>().SingleOrDefault(predicate);
            }

            return entity;
        }

        public ICollection<TEntity> GetAll()
        {
            ICollection<TEntity> entities;
            TContext context = new TContext();
            
            entities = context.Set<TEntity>().ToList();

            return entities;
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            ICollection<TEntity> entities;
            using (TContext context = new TContext())
            {
                entities = context.Set<TEntity>().Where(predicate).ToList();
            }

            return entities;
        }
    }
}
