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
                NameTask = "Task test",
                DescriptionTask = "Description test",
                PriorityTask = 1,
                DateTask = DateTime.UtcNow,
                Category = new Category(),
                ResumTask = "Resum test"
            };
            taskRepository.Insert(task);
            taskRepository.Save();

            var task2 = new Models.Task
            {
                TaskID = Guid.NewGuid(),
                NameTask = "Task test 1",
                DescriptionTask = "Description test 1",
                PriorityTask = 1,
                DateTask = DateTime.UtcNow,
                Category = new Category(),
                ResumTask = "Resum test 1"
            };
            taskRepository.Insert(task2);
            taskRepository.Save();
        }

        // Create a method insert category
        public static void InsertCategory(ContextAplication context)
        {
            var categoryRepository = new CategoryRepository(context);
            var category = new Category
            {
                CategoryID = Guid.NewGuid(),
                NameCategory = "Category test",
                DescriptionCategory = "Description test"
            };
            categoryRepository.Insert(category);
            categoryRepository.Save();

            var category2 = new Category
            {
                CategoryID = Guid.NewGuid(),
                NameCategory = "Category test 1",
                DescriptionCategory = "Description test 1"
            };
            categoryRepository.Insert(category2);
            categoryRepository.Save();
        }
    }
}
