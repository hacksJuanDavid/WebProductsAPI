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

        [HttpGet]
        public IActionResult GetAllTasks()
        {
            var taskRepository = new TaskRepository(_context);
            var tasks = taskRepository.GetAll();
            return Ok(tasks);
        }
    }
}

