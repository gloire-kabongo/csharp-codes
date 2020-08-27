using System.Collections.Generic;
using System.Linq;

namespace ToDoListExemple.Models
{
    public class ToDoList
    {
        private int nextId = 1;
        private Dictionary<int, ToDoItem> map;
        public ToDoList(string username, List<ToDoItem> toDoItems)
        {
            Username = username;

            map = toDoItems.ToDictionary(key => key.Id, value => value);
        }

        public string  Username { get; set; }

        public int AddTodo(string task)
        {
            nextId = map.Select(t => t.Key).Max();
            nextId++;
            map.Add(nextId, new ToDoItem(nextId, task));
            return nextId;
        }

        public ToDoItem GetById(int id)
        {
            var item = map.FirstOrDefault(a => a.Key == id);
            if (item.Equals(new KeyValuePair<int, ToDoItem>()))
                return null;
            else return item.Value;
        }


        public void MarkComplete(int id, bool complete)
        {
            var item = GetById(id);
            if(item != null)
                item.IsCompleted = complete;
        }

        public List<ToDoItem> GetDoItems(bool includeCompleted)
        {
            return map.Where(t => includeCompleted || !t.Value.IsCompleted)
                .Select(t => t.Value)
                .ToList();
        }
    }
}