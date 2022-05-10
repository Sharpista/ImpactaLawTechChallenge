using ImpactaLawTech.ToDo.Domain.Entities;
using ImpactaLawTech.ToDo.Domain.Interfaces;
using ImpactaLawTechToDo.Infra.Data.Context;

namespace ImpactaLawTechToDo.Infra.Data.Repositories
{
    public class TasksRepository : BaseRepository<Tasks>, ITaskRepository
    {
        public TasksRepository(ApplicationDBContext applicationDBContext) : base(applicationDBContext)
        {
        }
    }
}
