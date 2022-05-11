using AutoMapper;
using ImpactaLawTech.ToDo.Domain.Entities;
using ImpactaLawTechToDo.Application.DTO;

namespace ImpactaLawTechToDo.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Tasks, TasksDTO>().ReverseMap();
            CreateMap<UserTasks, UserTasksDTO>().ReverseMap();
        }
    }
}
