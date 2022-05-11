using ImpactaLawTech.ToDo.Domain.Entities;
using ImpactaLawTech.ToDo.Domain.Interfaces;
using ImpactaLawTechToDo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImpactaLawTechToDo.Infra.Data.Repositories
{
    public class UserTaskRepository : IUserTasksRepository
    {
        protected readonly ApplicationDBContext _applicationDBContext;

        public UserTaskRepository(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }

        public async Task<UserTasks> AssingToMeAsync(UserTasks userTasks)
        {
            await _applicationDBContext.AddAsync(userTasks);
            await _applicationDBContext.SaveChangesAsync();
             return userTasks;
        }

        public async Task<IEnumerable<UserTasks>> GetAllAsync()
        {
            return await _applicationDBContext.UserTasks.ToListAsync();
        }
    }
}
