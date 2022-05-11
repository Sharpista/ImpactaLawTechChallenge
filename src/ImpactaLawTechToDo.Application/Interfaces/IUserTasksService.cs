using ImpactaLawTech.ToDo.Domain.Entities;
using ImpactaLawTechToDo.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImpactaLawTechToDo.Application.Interfaces
{
    public  interface IUserTasksService
    {
        Task AssingToMe(UserTasksDTO userTasksDTO);
        Task<IEnumerable<UserTasksDTO>> GetAll();
    }
}
