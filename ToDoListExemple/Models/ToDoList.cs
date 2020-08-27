using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoListExemple.Models
{
    public class ToDoList
    {
        private int nextId = 1;
        public ToDoList(string username, List<ToDoItem> toDoItems)
        {
            Username = username;
            ToDoItems = toDoItems;
        }

        public string  Username { get; set; }
        public List<ToDoItem> ToDoItems { get; set; }

        public int AddTodo(string task)
        {
            nextId = ToDoItems
                .Select(t => t.Id)
                .Max();
            // while (GetById(nextId) != null)
            // {
            //     nextId++;
            // }
            nextId++;
            ToDoItems.Add(new ToDoItem(nextId, task));
            return nextId;
        }

        public ToDoItem GetById(int nextId)
        {
            return ToDoItems
                .Where(t => t.Id == nextId)
                .FirstOrDefault();



            // for (int i = 0; i < ToDoItems.Count; i++)
            // {
            //     ToDoItem item = ToDoItems[i];
            //     if (item.Id == nextId)
            //         return item;
            // }
            // return null;
        }

        public void MarkComplete(int id, bool complete)
        {
            var item = GetById(id);
            if(item != null)
                item.IsCompleted = complete;
        }
    }
}