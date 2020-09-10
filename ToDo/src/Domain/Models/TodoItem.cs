using System;

namespace ToDo.Domain.Models
{
    public class TodoItem
    {
        public TodoItem(int id,
            string task,
            bool complete = false)
        {
            Id = id;
            Task = task;
            Complete = complete;
        }

        public int Id { get; private set; }
        public string Task { get; private set; }
        public bool Complete { get; private set; }

        public void MarkComplete(bool complete)
            => Complete = complete;

        public override string ToString() =>
             $"Task:{Id}: ({Task}, Complete:{Complete})";
    }
}
