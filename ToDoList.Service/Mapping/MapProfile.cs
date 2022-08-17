using AutoMapper;
using ToDoList.Core.DTOs;
using ToDoList.Core.Models;

namespace ToDoList.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Todo, TodoDto>().ReverseMap();
            CreateMap<TodoCreateDto,Todo >().ReverseMap();
            CreateMap< Todo, TodoUpdateDto>().ReverseMap();
        }
    }
}
