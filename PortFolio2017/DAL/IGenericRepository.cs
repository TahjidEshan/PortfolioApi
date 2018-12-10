using System.Linq;
using PortFolio2017.Models;

namespace PortFolio2017.DAL {
    public partial interface IGenericRepository {
        void Insert<TEntity> (TEntity entity) where TEntity : BaseClass;
        void Delete<TEntity> (TEntity entity) where TEntity : BaseClass;
        void Update<TEntity> (TEntity entity) where TEntity : BaseClass;
        TEntity GetByID<TEntity> (object id) where TEntity : BaseClass;
        IQueryable<TEntity> GetQuery<TEntity> (bool trackChanges = true) where TEntity : BaseClass;

        //User
        void InsertUser<TEntity> (TEntity entity) where TEntity : User;
        void UpdateUser<TEntity> (TEntity entity) where TEntity : User;
        void DeleteUser<TEntity> (TEntity entity) where TEntity : User;
        TEntity GetUserByID<TEntity> (object id) where TEntity : User;
        IQueryable<TEntity> GetAllUsers<TEntity> (bool trackChanges = true) where TEntity : User;
    }
}