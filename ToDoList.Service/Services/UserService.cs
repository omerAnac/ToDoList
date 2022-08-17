using AutoMapper;
using ToDoList.Core.Models;
using ToDoList.Core.Repositories;
using ToDoList.Core.Services;
using ToDoList.Core.UnitOfWorks;

namespace NLayer.Service.Services
{
    public class UserService : Service<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IRepository<User> repository, IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
    }
}
