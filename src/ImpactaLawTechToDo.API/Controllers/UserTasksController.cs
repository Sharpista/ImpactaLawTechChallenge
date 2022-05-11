using ImpactaLawTechToDo.Application.DTO;
using ImpactaLawTechToDo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImpactaLawTechToDo.API.Controllers
{
    [Route("api/userTasks")]
    [ApiController]
    public class UserTasksController : ControllerBase
    {
        private readonly IUserTasksService _userTasksService;

        public UserTasksController(IUserTasksService userTasksService)
        {
            _userTasksService = userTasksService;
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<UserTasksDTO>>> GetAllUserTasks()
        {
            var userTasks = await _userTasksService.GetAll();

            return Ok(userTasks);
        }
    }
}
