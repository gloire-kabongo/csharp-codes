using System.Collections.Generic;
using ToDo.Domain.Models;

namespace Todo.Application.Common.Interfaces
{
    public interface IRepository
    {
        List<TodoList> GetAll();
        TodoList GetByUsername(string username);
    }
}