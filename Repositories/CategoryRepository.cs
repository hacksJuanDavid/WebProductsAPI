// Create a new methods in Repositories/CategoryRepository.cs:
// Path: Repositories/CategoryRepository.cs
// Compare this snippet from Repositories/CategoryRepository.cs:

using Microsoft.EntityFrameworkCore;
using WEBAPI.Context;
using WEBAPI.Models;

namespace WEBAPI.Repositories;

// Create a Class CategoryRepository
public class CategoryRepository
{

    // Create a private variable _context
    private readonly ContextAplication _context;

    // Create a constructor
    public CategoryRepository(ContextAplication context)
    {
        _context = context;
    }

    // Create a method GetAll
    public IEnumerable<Category> GetAll()
    {
        return _context.Categories.ToList();
    }

    // Create a method GetByID
    public Category GetByID(Guid id)
    {
        return _context.Categories.Find(id) ?? throw new InvalidOperationException("La categoría no fue encontrada.");
    }

    // Create a method Insert
    public void Insert(Category category)
    {
        _context.Categories.Add(category);
    }


    // Create a method Update
    public void Update(Category category)
    {
        _context.Entry(category).State = EntityState.Modified;
    }

    // Create a method Delete
    public void Delete(Guid id)
    {
        Category? category = _context.Categories.Find(id);
        if (category != null)
        {
            _context.Categories.Remove(category);
        }
        // Optionally, you can throw an exception or log a message if the category is not found.
    }

    // Create a method Save
    public void Save()
    {
        _context.SaveChanges();
    }

}