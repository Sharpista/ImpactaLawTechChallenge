using ImpactaLawTechToDo.Application.DTO;
using ImpactaLawTechToDo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImpactaLawTechToDo.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAll()
        {
            var users = await _userService.GetAll();

            return Ok(users);
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<UserDTO>> GetById(int? id)
        {
            var user = await _userService.GetById(id);

            return Ok(user);

        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post(UserDTO userDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            await _userService.Create(userDTO);

            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<UserDTO>> Put(int id, UserDTO userDTO)
        {
            if (id != userDTO.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest();

            await _userService.Update(userDTO);

            return Ok();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            await _userService.Delete(id);

            return Ok();
        }
    }
}
