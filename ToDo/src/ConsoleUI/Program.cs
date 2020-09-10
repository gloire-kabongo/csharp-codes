using System;
using System.Collections.Generic;

using ToDo.Domain.Models;
using ToDo.Application.Services;
using Todo.Infrastructure.Persistance;

using static System.Console;

namespace ToDo.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = CreateLocalStore();

            TodoList todoList;
            todoList = GetTodoList(store);
            WriteLine();
            WriteLine(todoList.Username);


            int choix;
            do
            {
                choix = Menu();
                switch (choix)
                {
                    case 1:
                        List();
                        break;
                    case 2:
                        New();
                        break;
                    case 3:
                        MarkComplete();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 9:
                        Quitter();
                        break;
                }
            } while (choix < 9);

            var newId = todoList.AddItem("Courir");
            var todo = todoList.GetById(newId);
            WriteLine(todo);

            todoList.MarkComplete(newId, complete: true);

            var todoItemsWithCompleteIncluded = todoList.GetItems(true);
            Display(todoItemsWithCompleteIncluded);



            var todoItemsWithCompleteNotIncluded = todoList.GetItems(false);
            Display(todoItemsWithCompleteNotIncluded);
        }

        static int Menu()
        {
            int choix = 0;

            WriteLine();
            WriteLine();
            WriteLine("1. Liste des to-do");
            WriteLine("2. New");
            WriteLine("3. Mark complete");
            WriteLine("4. Delete");
            WriteLine("9. Quitter");

            while((choix != 1) && (choix != 2) && (choix != 9))
            {
                _ = int.TryParse(ReadLine(), out choix);
            }
            return choix;
        }

        private static TodoList GetTodoList(TodoListService store)
        {
            TodoList todoList;
            do
            {

                WriteLine();
                Write("Veuillez saisir votre username: ");
                string username = ReadLine();

                todoList = store.GetByUsername(username);

                if (todoList == null)
                    WriteLine("Cet user n'a pas de To do list");
                Clear();

            } while (todoList == null);
            return todoList;
        }


        static TodoListService CreateLocalStore() =>
            new TodoListService(new LocalData());

        static void Quitter()
        {
            WriteLine("Programme terminé !");
        }

        static void List(){}

        static void New() {}

        static void MarkComplete() {}

        static void Delete() {}

        private static void Display(List<TodoItem> todoItems)
        {
            Console.WriteLine("To-do List");
            foreach (var item in todoItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
