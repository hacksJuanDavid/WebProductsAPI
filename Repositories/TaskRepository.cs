// Create a new methods in Repositories/TaskRepository.cs:
// Path: Repositories/TaskRepository.cs
// Compare this snippet from Repositories/TaskRepository.cs:

using Microsoft.EntityFrameworkCore;
using WEBAPI.Context;
using WEBAPI.Models;

namespace WEBAPI.Repositories;

// Create a Class TaskRepository
public class TaskRepository
{

    // Create a private variable _context
    private readonly ContextAplication _context;

    // Create a constructor
    public TaskRepository(ContextAplication context)
    {
        _context = context;
    }

    // Create a method GetAll
    public IEnumerable<Models.Task> GetAll()
    {
        return _context.Tasks.ToList();
    }

    // Create a method GetByID
    public Models.Task GetByID(Guid id)
    {
        return _context.Tasks.Find(id) ?? throw new InvalidOperationException("La tarea no fue encontrada.");
    }

    // Create a method Insert
    public void Insert(Models.Task task)
    {
        _context.Tasks.Add(task);
    }

    // Create a method Update
    public void Update(Models.Task task)
    {
        _context.Entry(task).State = EntityState.Modified;
    }

    // Create a method Delete
    public void Delete(Guid id)
    {
        Models.Task? task = _context.Tasks.Find(id);
        if (task != null)
        {
            _context.Tasks.Remove(task);
        }
        // Optionally, you can throw an exception or log a message if the task is not found.
    }

    // Create a method Save
    public void Save()
    {
        _context.SaveChanges();
    }


}