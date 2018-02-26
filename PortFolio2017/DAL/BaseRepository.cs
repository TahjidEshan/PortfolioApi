using Microsoft.EntityFrameworkCore;
using PortFolio2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolio2017.DAL
{
    public class BaseRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseClass
    {
        private readonly PortfolioContext _dbContext = null;

        public BaseRepository(PortfolioContext Context)
        {
            _dbContext = Context;
        }
        public virtual void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public virtual TEntity GetByID(object id)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(t => t.Id == (long)id);
        }

        public virtual IQueryable<TEntity> GetQuery()
        { 
            DbSet<TEntity> tempSet = _dbContext.Set<TEntity>();
            return tempSet.AsQueryable<TEntity>();
        }

        public virtual void Insert(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
