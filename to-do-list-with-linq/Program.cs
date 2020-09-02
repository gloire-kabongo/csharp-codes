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

            var newId = todoList.AddTodoItem("Courir");
            var todo = todoList.GetById(newId);
            Console.WriteLine(todo);

            todoList.MarkComplete(newId, complete: true);

            var todoItemsWithCompleteIncluded = todoList.GetToDoItems(true);
            Display(todoItemsWithCompleteIncluded);

            var todoItemsWithCompleteNotIncluded = todoList.GetToDoItems(false);
            Display(todoItemsWithCompleteNotIncluded);

            try
            {
                todoList.DeleteToDoItem(100);

            }
            catch(ToDoListExemple.Exceptions.NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Display(todoList.GetToDoItems(true));

            }

        }


        private static List<ToDoItem> GetToDoItems()
        {
            return new List<ToDoItem>
            {
                new ToDoItem(1, "Etudier python"),
                new ToDoItem(2, "Faire du sport")
            };
        }

        private static void Display(List<ToDoItem> todoItems)
        {
            Console.WriteLine("To-do List");
            foreach (var item in todoItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
