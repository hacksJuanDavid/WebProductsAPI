using WEBAPI.Context;
using WEBAPI.Models;
using WEBAPI.Repositories;

namespace WEBAPI.Tests
{
    public class Test
    {

        // Create a method insert task 
        public static void InsertTask(ContextAplication context)
        {
            var taskRepository = new TaskRepository(context);
            var task = new Models.Task
            {
                TaskID = Guid.NewGuid(),
                NameTask = "Task 2",
                DescriptionTask = "Description 2",
                PriorityTask = 1,
                DateTask = DateTime.UtcNow,
                Category = new Category(),
                ResumTask = "Resum 2"
            };
            taskRepository.Insert(task);
            taskRepository.Save();
        }

        // Create a method insert category
        public static void InsertCategory(ContextAplication context)
        {
            var categoryRepository = new CategoryRepository(context);
            var category = new Category
            {
                CategoryID = Guid.NewGuid(),
                NameCategory = "Category 2",
                DescriptionCategory = "Description 2"
            };
            categoryRepository.Insert(category);
            categoryRepository.Save();
        }
    }
}
