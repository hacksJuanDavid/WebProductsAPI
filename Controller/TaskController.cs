using Microsoft.AspNetCore.Mvc;
using WEBAPI.Context;
using WEBAPI.Repositories;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ContextAplication _context;

        public TaskController(ContextAplication context)
        {
            _context = context;
        }

        // Create a method GetAllTasks
        [HttpGet]
        public IActionResult GetAllTasks()
        {
            var taskRepository = new TaskRepository(_context);
            var tasks = taskRepository.GetAll();
            return Ok(tasks);
        }

        // Create a method GetTask
        [HttpGet("{id}")]
        public IActionResult GetTask(Guid id)
        {
            var taskRepository = new TaskRepository(_context);
            var task = taskRepository.GetByID(id);
            return Ok(task);
        }

        // Create a method InsertTask
        [HttpPost]
        public IActionResult InsertTask(Models.Task task)
        {
            var taskRepository = new TaskRepository(_context);
            taskRepository.Insert(task);
            taskRepository.Save();
            return Ok();
        }

        // Create a method UpdateTask
        [HttpPut]
        public IActionResult UpdateTask(Models.Task task)
        {
            var taskRepository = new TaskRepository(_context);
            taskRepository.Update(task);
            taskRepository.Save();
            return Ok();
        }

        // Create a method DeleteTask
        [HttpDelete("{id}")]
        public IActionResult DeleteTask(Guid id)
        {
            var taskRepository = new TaskRepository(_context);
            taskRepository.Delete(id);
            taskRepository.Save();
            return Ok();
        }
    }
}

