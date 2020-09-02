using System.Collections.Generic;
using System.Linq;
using System;
using ToDoListExemple.Exceptions;

namespace ToDoListExemple.Models
{
    public class ToDoList
    {
        private int nextId = 1;
        private List<ToDoItem> toDoItems;

        public ToDoList(string username, List<ToDoItem> toDoItems)
        {
            Username = username;
            this.toDoItems = toDoItems;
        }

        public string Username { get; set; }

        public int AddTodoItem(string task)
        {
            nextId = toDoItems
                .Select(t => t.Id)
                .Max();
            nextId++;
            toDoItems.Add(new ToDoItem(nextId, task));
            return nextId;
        }

        public void DeleteToDoItem(int id)
        {
                var item = GetById(id);
                if (item == null)
                {
                    throw new NotFoundException(nameof(ToDoItem), id);
                }
                toDoItems.Remove(item);
        }

        public ToDoItem GetById(int id) =>
            toDoItems
                .FirstOrDefault(t => t.Id == id);

        public List<ToDoItem> GetToDoItems(bool includeCompleted)
        {
            return toDoItems.Where(t => includeCompleted || !t.IsCompleted)
                .ToList();
        }

        public void MarkComplete(int id, bool complete)
        {
            var todoItem = toDoItems.FirstOrDefault(i => i.Id == id);
            if (todoItem != null)
                todoItem.IsCompleted = complete;
        }

        public (int Total, int Incompleted) GetItemCounts()
        {
            var total = toDoItems.Count;
            var incompleted = GetToDoItems(false).Count;

            return (total, incompleted);
        }
    }
}