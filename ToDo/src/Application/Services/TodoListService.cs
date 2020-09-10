using System.Collections.Generic;
using System.Linq;
using Todo.Application.Common.Interfaces;
using ToDo.Domain.Models;

namespace ToDo.Application.Services
{
    public class TodoListService
    {
        private IRepository _repository;

        public TodoListService(IRepository repository)
        {
            _repository = repository;
        }

        public List<TodoList> GetAll() => _repository.GetAll();

        public TodoList GetByUsername(string username) =>
            _repository.GetByUsername(username);
    }
}