using System.Collections.Generic;
using System.Linq;

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

        public int AddTodo(string task)
        {
            nextId = toDoItems
                .Select(t => t.Id)
                .Max();
            nextId++;
            toDoItems.Add(new ToDoItem(nextId, task));
            return nextId;
        }

        public ToDoItem GetById(int id) =>
            toDoItems
                .FirstOrDefault(t => t.Id == id);

        public List<ToDoItem> GetDoItems(bool includeCompleted)
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
            var incompleted = GetDoItems(false).Count;

            return (total, incompleted);
        }
    }
}