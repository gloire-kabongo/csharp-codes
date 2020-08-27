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

        public string  Username { get; set; }
        public int AddTodo(string task)
        {
            while (GetById(nextId) != null)
            {
                nextId++;
            }
            nextId++;
            toDoItems.Add(new ToDoItem(nextId, task));
            return nextId;
        }

        public ToDoItem GetById(int id)
        {
            for (int i = 0; i < toDoItems.Count; i++)
            {
                ToDoItem item = toDoItems[i];
                if (item.Id == nextId)
                    return item;
            }
            return null;
        }

        public void MarkComplete(int id, bool complete)
        {
            var item = GetById(id);
            if(item != null)
                item.IsCompleted = complete;
        }
    }
}