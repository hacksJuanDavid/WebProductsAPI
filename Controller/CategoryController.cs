using Microsoft.AspNetCore.Mvc;
using WEBAPI.Context;
using WEBAPI.Repositories;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ContextAplication _context;

        public CategoryController(ContextAplication context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var categoryRepository = new CategoryRepository(_context);
            var categories = categoryRepository.GetAll();
            return Ok(categories);
        }
    }
}

