using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortFolio2017.Models;

namespace PortFolio2017.DAL {
    public class BaseRepository : IGenericRepository {
        private readonly PortfolioContext _dbContext = null;

        public BaseRepository (PortfolioContext Context) {
            _dbContext = Context;
        }
        public virtual void Delete<TEntity> (TEntity entity) where TEntity : BaseClass {
            _dbContext.Set<TEntity> ().Remove (entity);
            _dbContext.SaveChanges ();
        }

        public virtual TEntity GetByID<TEntity> (object id) where TEntity : BaseClass {
            return _dbContext.Set<TEntity> ().FirstOrDefault (t => t.Id == (Guid) id);
        }

        public virtual IQueryable<TEntity> GetQuery<TEntity> (bool trackChanges = true) where TEntity : BaseClass {
            DbSet<TEntity> tempSet = _dbContext.Set<TEntity> ();
            return trackChanges ? tempSet.AsQueryable<TEntity> () : tempSet.AsNoTracking<TEntity> ();
        }

        public virtual void Insert<TEntity> (TEntity entity) where TEntity : BaseClass {
            _dbContext.Set<TEntity> ().Add (entity);
            _dbContext.SaveChanges ();
        }

        public virtual void Update<TEntity> (TEntity entity) where TEntity : BaseClass {
            _dbContext.Set<TEntity> ().Update (entity);
            _dbContext.SaveChanges ();
        }

        //User

        public virtual void DeleteUser<TEntity> (TEntity entity) where TEntity : User {
            _dbContext.Set<TEntity> ().Remove (entity);
            _dbContext.SaveChanges ();
        }

        public virtual TEntity GetUserByID<TEntity> (object id) where TEntity : User {
            return _dbContext.Set<TEntity> ().FirstOrDefault (t => t.UserId == (Guid) id);
        }

        public virtual IQueryable<TEntity> GetAllUsers<TEntity> (bool trackChanges = true) where TEntity : User {
            DbSet<TEntity> tempSet = _dbContext.Set<TEntity> ();
            return trackChanges?tempSet.AsQueryable<TEntity> ():
                tempSet.AsNoTracking<TEntity> ();
        }

        public virtual void InsertUser<TEntity> (TEntity entity) where TEntity : User {
            _dbContext.Set<TEntity> ().Add (entity);
            _dbContext.SaveChanges ();
        }

        public virtual void UpdateUser<TEntity> (TEntity entity) where TEntity : User {
            _dbContext.Set<TEntity> ().Update (entity);
            _dbContext.SaveChanges ();
        }
    }
}