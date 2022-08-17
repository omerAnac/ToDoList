using ToDoList.Core.DTOs;
using ToDoList.Core.Models;

namespace ToDoList.Core.Services
{
    public interface ITodoService:IService<Todo>
    {
        Task<List<TodoDto>> GetTodosWithByUserId(int id);
    }
}
