using ImpactaLawTech.ToDo.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImpactaLawTech.ToDo.Domain.Interfaces
{
    public interface IUserTasksRepository
    {
        Task<UserTasks> AssingToMeAsync(UserTasks userTasks);
        Task<IEnumerable<UserTasks>> GetAllAsync();
    }
}
