using Microsoft.EntityFrameworkCore;
using System.Reflection;
using ToDoList.Core.Models;

namespace ToDoList.Repository
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { 
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());       

            base.OnModelCreating(modelBuilder);
        }
    }
}
