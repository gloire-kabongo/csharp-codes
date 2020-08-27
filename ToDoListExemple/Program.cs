using System;
using System.Collections.Generic;
using System.Linq;
using ToDoListExemple.Models;

namespace ToDoListExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            var todos = new List<ToDoItem>
            {
                new ToDoItem(1, "Etudier python"),
                new ToDoItem(2, "Faire du sport")
            };



            var todoList = new ToDoList("Hertzy", todos);

            var newId = todoList.AddTodo("Courir");
            var todo = todoList.GetById(newId);
            Console.WriteLine(todo);

            var idList = todos
                .Select(t => t.Id)
                .Max();

            Console.WriteLine(idList);
        }
    }
}
