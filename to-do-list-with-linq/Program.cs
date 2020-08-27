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
            List<ToDoItem> todos = GetToDoItems();
            var todoList = new ToDoList("Hertzy", todos);

            var newId = todoList.AddTodo("Courir");
            var todo = todoList.GetById(newId);
            Console.WriteLine(todo);

            todoList.MarkComplete(newId, complete: true);

            var todoItemsWithCompleteIncluded = todoList.GetDoItems(true);
            GetDoItems(todoItemsWithCompleteIncluded);

            var todoItemsWithCompleteNotIncluded = todoList.GetDoItems(false);
            GetDoItems(todoItemsWithCompleteNotIncluded);
        }

        private static List<ToDoItem> GetToDoItems()
        {
            return new List<ToDoItem>
            {
                new ToDoItem(1, "Etudier python"),
                new ToDoItem(2, "Faire du sport")
            };
        }

        private static void GetDoItems(List<ToDoItem> todoItems)
        {
            Console.WriteLine("To-do List");
            foreach (var item in todoItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
