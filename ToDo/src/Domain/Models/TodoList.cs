using System.Collections.Generic;
using System.Linq;

using ToDo.Domain.Exceptions;

namespace ToDo.Domain.Models
{
    public class TodoList
    {
        private int _nextId = 1;
        private List<TodoItem> _items;

        public TodoList(string username, List<TodoItem> items)
        {
            _items = items;
            Username = username;
        }

        public string Username { get; private set; }

        public int AddItem(string task)
        {
            _nextId = _items
                .Select(t => t.Id)
                .Max();
            _nextId++;
            _items.Add(new TodoItem(_nextId, task));
            return _nextId;
        }

        public void RemoveItem(int id)
        {
            var item = GetById(id);
            if (item == null)
            {
                throw new ItemNotFoundException(id);
            }
            _items.Remove(item);
        }

        public TodoItem GetById(int id) =>
            _items
                .FirstOrDefault(t => t.Id == id);

        public List<TodoItem> GetItems(bool includeCompleted)
        {
            return _items.Where(t => includeCompleted || !t.Complete)
                .ToList();
        }

        public void MarkComplete(int id, bool complete)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if (item != null)
                item.MarkComplete(complete);
        }

        public (int Total, int Incompleted) GetItemCounts()
        {
            var total = _items.Count;
            var incompleted = GetItems(false).Count;

            return (total, incompleted);
        }
    }
}