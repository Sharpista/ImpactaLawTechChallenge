using AutoMapper;
using ImpactaLawTech.ToDo.Domain.Entities;
using ImpactaLawTech.ToDo.Domain.Interfaces;
using ImpactaLawTechToDo.Application.DTO;
using ImpactaLawTechToDo.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImpactaLawTechToDo.Application.Services
{
    public class TasksService : ITasksService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public TasksService(ITaskRepository taskRepository, 
            IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TasksDTO>> GetAll()
        {
           var taskEntities = await _taskRepository.GetAllAsync();

           return _mapper.Map<IEnumerable<TasksDTO>>(taskEntities);
        }

        public async Task<TasksDTO> GetById(int? id)
        {
            var taskEntity = await _taskRepository.GetByIdAsync(id);

            if (taskEntity == null) throw new Exception();

            return _mapper.Map<TasksDTO>(taskEntity);
        }
        public async Task Create(TasksDTO entity)
        {
            var takEntity = _mapper.Map<Tasks>(entity);

            await _taskRepository.CreateAsync(takEntity);
        }

        public async Task Update(TasksDTO entity)
        {
            var takEntity = _mapper.Map<Tasks>(entity);

            await _taskRepository.UpdateAsync(takEntity);
        }
        public async Task Delete(int? id)
        {
            var entity = await _taskRepository.GetByIdAsync(id);
            if (entity == null) throw new Exception();
            await _taskRepository.RemoveAsync(entity);
        }

       

        
    }
}
