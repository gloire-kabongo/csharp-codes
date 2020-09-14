using System.Collections.Generic;
using System.Linq;
using Todo.Application.Common.Interfaces;
using ToDo.Domain.Models;

namespace Todo.Infrastructure.Persistance
{
    public class LocalData : IRepository
    {
        private List<TodoList> lists;

        public LocalData()
        {
            lists = new List<TodoList>()
            {
                new TodoList("Jemima", new List<TodoItem>()),
                new TodoList("Herzty", new List<TodoItem>
                {
                    new TodoItem(1, "Etudier python"),
                    new TodoItem(2, "Faire du sport")
                })
            };
        }

        public List<TodoList> GetAll() => lists;

        public TodoList GetByUsername(string username) =>
             lists.FirstOrDefault(l => l.Username == username);
    }
}