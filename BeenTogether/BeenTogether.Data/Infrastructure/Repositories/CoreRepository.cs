﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BeenTogether.Data.Infrastructure.Repositories
{
    public class CoreRepository<Entity> : ICoreRepository<Entity> where Entity : class
    {
        protected readonly BeenTogetherContext _context;
        private readonly DbSet<Entity> DbSet;

        public CoreRepository(BeenTogetherContext context)
        {
            _context = context;
            //Find property with typeof(T) on dataContext
            var typeOfDbSet = typeof(DbSet<Entity>);
            foreach (var prop in context.GetType().GetProperties())
            {
                if (typeOfDbSet == prop.PropertyType)
                {
                    DbSet = prop.GetValue(context, null) as DbSet<Entity>;
                    break;
                }
            }

            if (DbSet == null)
            {
                DbSet = context.Set<Entity>();
            }
        }

        public void Add(Entity entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(Entity entity)
        {
            DbSet.Remove(entity);
        }

        public async Task<Entity> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual Entity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<Entity> GetQuery()
        {
            return DbSet;
        }

        public IQueryable<Entity> GetQuery(Expression<Func<Entity, bool>> where)
        {
            return DbSet.Where(where);
        }

        public void Update(Entity entity)
        {
            //_dbSet.AddOrUpdate(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

    }
}
