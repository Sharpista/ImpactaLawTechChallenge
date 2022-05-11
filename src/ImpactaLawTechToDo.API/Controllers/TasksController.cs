using ImpactaLawTechToDo.Application.DTO;
using ImpactaLawTechToDo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImpactaLawTechToDo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITasksService _taskService;

        public TasksController(ITasksService tasksService)
        {
            _taskService = tasksService;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<TasksDTO>>> GetAll()
        {
            var users = await _taskService.GetAll();

            return Ok(users);
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<TasksDTO>> GetById(int? id)
        {
            var user = await _taskService.GetById(id);

            return Ok(user);

        }

        [HttpPost]
        public async Task<ActionResult<TasksDTO>> Post(TasksDTO TasksDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            await _taskService.Create(TasksDTO);

            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<TasksDTO>> Put(int id, TasksDTO TasksDTO)
        {
            if (id != TasksDTO.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest();

            await _taskService.Update(TasksDTO);

            return Ok();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            await _taskService.Delete(id);

            return Ok();
        }
    }
}
