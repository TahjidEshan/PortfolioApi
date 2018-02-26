using PortFolio2017.Models;
using System.Linq;

namespace PortFolio2017.DAL
{
    public partial interface IGenericRepository 
    {
        void Insert<TEntity>(TEntity entity) where TEntity : BaseClass;
        void Delete<TEntity>(TEntity entity) where TEntity : BaseClass;
        void Update<TEntity>(TEntity entity) where TEntity : BaseClass;
        TEntity GetByID<TEntity>(object id) where TEntity : BaseClass;
        IQueryable<TEntity> GetQuery<TEntity>() where TEntity : BaseClass;
    }
}
