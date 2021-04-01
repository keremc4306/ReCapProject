using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<T, TContext> : IEntityRepository<T>
            where T : class, IEntity, new()
            where TContext : DbContext, new()

    {

        public void Add(T entity)
        {
            //garbage collector gelip hemen alsın diye using kullanıyoruz, kullanmasak da olur

            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Delete(T entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();

            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().SingleOrDefault(filter);

            }
        }

        public void Update(T entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}