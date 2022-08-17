using ToDoList.Core.Models;

namespace ToDoList.Core.Repositories
{
    public interface ITodoRepository:IRepository<Todo>
    {
        Task<List<Todo>> GetTodosWithByUserId(int id);
    }
}
