using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ToDoList.Core.DTOs;
using ToDoList.Core.Models;
using ToDoList.Core.Services;

namespace ToDoList.Web.Controllers
{
    [Authorize]
    public class TodoController : Controller
    {
        private readonly ITodoService _todoService;
        private readonly IMapper _mapper;

        public TodoController(ITodoService todoService, IMapper mapper)
        {
            _todoService = todoService;
            _mapper = mapper;
        }
        [Authorize]
        // GET: TodoController
        public async Task<IActionResult> Index()
        {
            var userId = HttpContext.User.FindFirst("UserId");

            var todos = await _todoService.GetTodosWithByUserId(Convert.ToInt32(userId.Value));
            return View(todos);
        }


        [Authorize]
        // GET: TodoController/Create
        public async Task<IActionResult> Create()
        {

            return View();
        }

        // POST: TodoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TodoCreateDto todoCreateDto)
        {
            if (ModelState.IsValid)
            {
                todoCreateDto.UserId = Convert.ToInt32(HttpContext.User.FindFirst("UserId").Value);
                await _todoService.AddAsync(_mapper.Map<Todo>(todoCreateDto));
            }
            return RedirectToAction(nameof(Index));

        }

        // GET: TodoController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {

            var todo = await _todoService.GetByIdAsync(id);
            return View(_mapper.Map<TodoUpdateDto>(todo));
        }

        // POST: TodoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TodoUpdateDto todoUpdateDto)
        {
            if (ModelState.IsValid)
            {
                todoUpdateDto.UserId = Convert.ToInt32(HttpContext.User.FindFirst("UserId").Value);
                await _todoService.UpdateAsync(_mapper.Map<Todo>(todoUpdateDto));
                return RedirectToAction(nameof(Index));

            }
            return View(todoUpdateDto);

        }

        // GET: TodoController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var todo = await _todoService.GetByIdAsync(id);
            await _todoService.RemoveAsync(todo);

            return RedirectToAction(nameof(Index));
        }


    }
}
