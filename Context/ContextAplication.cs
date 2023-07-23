using Microsoft.EntityFrameworkCore;
using WEBAPI.Models;

namespace WEBAPI.Context
{
    public class ContextAplication : DbContext
    {
        public ContextAplication(DbContextOptions<ContextAplication> options) : base(options)
        {
        }

        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}