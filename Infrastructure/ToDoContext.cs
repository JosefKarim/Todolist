using Microsoft.EntityFrameworkCore;
using ToDoListMVC.Models;

namespace ToDoListMVC.Infrastructure
{
    public class ToDoContext: DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }
        public DbSet<TodoList> ToDoList { get; set; }
    }
}
