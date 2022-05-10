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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, 
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            var UserEntities = await _userRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<UserDTO>>(UserEntities);
        }

        public async Task<UserDTO> GetById(int? id)
        {
            var userEntity = await _userRepository.GetByIdAsync(id);

            if (userEntity == null) throw new Exception();

            return _mapper.Map<UserDTO>(userEntity);
        }
        public async Task Create(UserDTO entity)
        {
            var userEntity = _mapper.Map<User>(entity);

            await _userRepository.CreateAsync(userEntity);

        }

        public async Task Update(UserDTO entity)
        {
            var userEntity = _mapper.Map<User>(entity);

            await _userRepository.UpdateAsync(userEntity);
        }

        public async Task Delete(int? id)
        {
           var userEntity = await _userRepository.GetByIdAsync(id);
            if (userEntity == null) throw new Exception();
            await _userRepository.RemoveAsync(userEntity);
        }

    }
}
