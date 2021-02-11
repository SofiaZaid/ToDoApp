using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.Data
{
    public class ToDoAppContext : DbContext
    {
        public ToDoAppContext (DbContextOptions<ToDoAppContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoItem> ToDoItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}