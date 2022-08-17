using Microsoft.EntityFrameworkCore;
using ToDoList.Core.Models;
using ToDoList.Core.Repositories;

namespace ToDoList.Repository.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
        

    }
}
