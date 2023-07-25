using Microsoft.AspNetCore.Mvc;
using WEBAPI.Context;
using WEBAPI.Repositories;

namespace WEBAPI.Controllers
{      //987fb7bf-4508-4b3f-b6a9-e8f7fc10e542
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ContextAplication _context;

        public CategoryController(ContextAplication context)
        {
            _context = context;
        }

        // Create a method GetAllCategories
        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var categoryRepository = new CategoryRepository(_context);
            var categories = categoryRepository.GetAll();
            return Ok(categories);
        }

        // Create a method GetCategory
        [HttpGet("{id}")]
        public IActionResult GetCategory(Guid id)
        {
            var categoryRepository = new CategoryRepository(_context);
            var category = categoryRepository.GetByID(id);
            return Ok(category);
        }

        // Create a method InsertCategory
        [HttpPost]
        public IActionResult InsertCategory(Models.Category category)
        {
            var categoryRepository = new CategoryRepository(_context);
            categoryRepository.Insert(category);
            categoryRepository.Save();
            return Ok();
        }

        // Create a method UpdateCategory
        [HttpPut]
        public IActionResult UpdateCategory(Models.Category category)
        {
            var categoryRepository = new CategoryRepository(_context);
            categoryRepository.Update(category);
            categoryRepository.Save();
            return Ok();
        }

        // Create a method DeleteCategory
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(Guid id)
        {
            var categoryRepository = new CategoryRepository(_context);
            categoryRepository.Delete(id);
            categoryRepository.Save();
            return Ok();
        }

    }
}


