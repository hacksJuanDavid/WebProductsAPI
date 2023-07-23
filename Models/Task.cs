using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEBAPI.Models;

public class Task
{

    // Create Key
    [Key]
    public Guid TaskID { get; set; }

    // Create Name
    [Required]
    [MaxLength(50)]
    public string NameTask { get; set; }

    // Create Description
    [Required]
    [MaxLength(250)]
    public string DescriptionTask { get; set; }

    // Create Priority Task
    [Required]
    public int PriorityTask { get; set; }

    // Create Taks Date 
    [Required]
    public DateTime DateTask { get; set; }

    // Create virtual Category
    public virtual Category Category { get; set; }

    // Create Resum Task
    [NotMapped]
    public string ResumTask { get; set; }


    // Create constructor
    public Task()
    {
        TaskID = Guid.NewGuid(); // Inicializar el TaskID con un nuevo GUID
        NameTask = string.Empty; // Inicializar NameTask con una cadena vacía
        DescriptionTask = string.Empty; // Inicializar DescriptionTask con una cadena vacía
        PriorityTask = (int)Priority.Low; // Inicializar PriorityTask con un valor predeterminado (por ejemplo, Low)
        DateTask = DateTime.Now; // Inicializar DateTask con la fecha y hora actual
        Category = new Category(); // Inicializar Category con un nuevo objeto Category
        ResumTask = string.Empty; // Inicializar ResumTask con una cadena vacía
    }


}

// Create function Priority

public enum Priority
{
    Low = 1,
    Medium = 2,
    High = 3
}
