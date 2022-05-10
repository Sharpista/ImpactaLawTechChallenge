using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImpactaLawTechToDo.Application.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int? id);
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int? id);
    }
}
