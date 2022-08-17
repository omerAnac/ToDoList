using Microsoft.EntityFrameworkCore;
using ToDoList.Core.Models;
using ToDoList.Core.Repositories;

namespace ToDoList.Repository.Repositories
{
    public class TodoRepository : Repository<Todo>, ITodoRepository
    {
        public TodoRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Todo>> GetTodosWithByUserId(int id)
        {
            return await _context.Todos.Include(x=>x.User).ToListAsync();
        }


    }
}
