using AutoMapper;
using ImpactaLawTech.ToDo.Domain.Entities;
using ImpactaLawTech.ToDo.Domain.Interfaces;
using ImpactaLawTechToDo.Application.DTO;
using ImpactaLawTechToDo.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImpactaLawTechToDo.Application.Services
{
    public class UserTasksService : IUserTasksService
    {
        private readonly IUserTasksRepository _userTasksRepository;
        private readonly IMapper _mapper;

        public UserTasksService(IUserTasksRepository userTasksRepository, IMapper mapper)
        {
            _userTasksRepository = userTasksRepository;
            _mapper = mapper;
        }

        public async Task AssingToMe(UserTasksDTO userTasksDTO)
        {
           var userTasks =  _mapper.Map<UserTasks>(userTasksDTO);
           
           await _userTasksRepository.AssingToMeAsync(userTasks);
        }

        public async Task<IEnumerable<UserTasksDTO>> GetAll()
        {
           
           var userTasks = await _userTasksRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<UserTasksDTO>>(userTasks);
        }
    }
}
