using Microsoft.EntityFrameworkCore;
using PortfolioApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApi.DAL
{
    public class BaseRepository : IGenericRepository
    {
        private PortfolioContext _dbContext = null;

        public BaseRepository(PortfolioContext Context)
        {
            _dbContext = Context;
        }
        public void Delete<TEntity>(TEntity entity) where TEntity : BaseClass
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public TEntity GetByID<TEntity>(object id) where TEntity : BaseClass
        {
           return _dbContext.Set<TEntity>().FirstOrDefault(t => t.Id == (long)id);
        }

        public IQueryable<TEntity> GetQuery<TEntity>() where TEntity : BaseClass
        {
            DbSet<TEntity> tempSet = _dbContext.Set<TEntity>();
            return tempSet.AsQueryable<TEntity>();
        }

        public void Insert<TEntity>(TEntity entity) where TEntity : BaseClass
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update<TEntity>(TEntity entity) where TEntity : BaseClass
        {
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
