using ImpactaLawTech.ToDo.Domain.Entities;
using ImpactaLawTech.ToDo.Domain.Interfaces;
using ImpactaLawTechToDo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImpactaLawTechToDo.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : EntityBase, new()
    {
        protected readonly ApplicationDBContext _applicationDBContext;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
            DbSet = applicationDBContext.Set<TEntity>();
        }

        public virtual async Task<TEntity> GetByIdAsync(int? id)
        {
            return await DbSet.AsNoTracking().SingleOrDefaultAsync(_ => _.Id == id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> RemoveAsync(TEntity entity)
        {
            DbSet.Remove(entity);
            await SaveChangesAsync();
            return entity;
        }
        public async Task<int> SaveChangesAsync()
        {
           return await _applicationDBContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _applicationDBContext?.Dispose();
        }
    }
}
