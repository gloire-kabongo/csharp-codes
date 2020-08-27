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

            todoList.MarkComplete(newId, complete: true);

            var todoItemsWithCompleteIncluded = todoList.GetDoItems(true);
            GetDoItems(todoList.Username, todoItemsWithCompleteIncluded);

            var todoItemsWithCompleteNotIncluded = todoList.GetDoItems(false);
            GetDoItems(todoList.Username, todoItemsWithCompleteNotIncluded);
        }

        private static void GetDoItems(string username, List<ToDoItem> todoItems)
        {
            Console.WriteLine($"{username}'s To-do List");
            foreach (var item in todoItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
