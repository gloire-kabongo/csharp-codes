namespace ToDoListExemple.Models
{
    public class ToDoItem
    {
        public ToDoItem(int id, string task)
        {
            Id = id;
            Task = task;
            IsCompleted = false;
        }

        public int Id { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            var etat = !IsCompleted ? "Actif" : "Fini";
            return $"Task:{Id}: ({Task}, {etat})";
        }
    }
}