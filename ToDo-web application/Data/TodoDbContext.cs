using Microsoft.EntityFrameworkCore;
using ToDo_web_application.Models;

namespace ToDo_web_application.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}