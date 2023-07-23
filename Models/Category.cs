using System.ComponentModel.DataAnnotations;

namespace WEBAPI.Models;

public class Category
{

    // Create Key
    [Key]
    public Guid CategoryID { get; set; }

    // Create Name
    [Required]
    [MaxLength(50)]
    public string NameCategory { get; set; }

    // Create Description
    [Required]
    [MaxLength(250)]
    public string DescriptionCategory { get; set; }

    // Create virtual Task
    public virtual ICollection<Task> Tasks { get; set; }

    // Create constructor
    public Category()
    {
        CategoryID = Guid.NewGuid(); // Inicializar el CategoryID con un nuevo GUID
        NameCategory = string.Empty; // Inicializar NameCategory con una cadena vacía
        DescriptionCategory = string.Empty; // Inicializar DescriptionCategory con una cadena vacía
        Tasks = new HashSet<Task>(); // Inicializar Tasks con un nuevo objeto HashSet<Task>
    }

    public static implicit operator Category(int v)
    {
        throw new NotImplementedException();
    }
}