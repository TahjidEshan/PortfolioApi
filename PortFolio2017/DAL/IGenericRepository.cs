using PortFolio2017.Models;
using System.Linq;

namespace PortFolio2017.DAL
{
    public partial interface IGenericRepository<TEntity> where TEntity : BaseClass
    {
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity GetByID(object id);
        IQueryable<TEntity> GetQuery();
    }
}
