using AutoMapper;
using ToDoList.Core.DTOs;
using ToDoList.Core.Models;
using ToDoList.Core.Repositories;
using ToDoList.Core.Services;
using ToDoList.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class TodoService : Service<Todo>, ITodoService
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IMapper _mapper;

        public TodoService(IRepository<Todo> repository, IUnitOfWork unitOfWork, IMapper mapper, ITodoRepository categoryRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _todoRepository = categoryRepository;
        }
        public async Task<List<TodoDto>> GetTodosWithByUserId(int id)
        {
            var todos = await _todoRepository.GetTodosWithByUserId(id);
            var todosDto=_mapper.Map<List<TodoDto>>(todos);
            return todosDto;
        }

      
    }
}
