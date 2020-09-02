using System;

namespace ToDoListExemple.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key)
            : base($"Item \"{name}\" ({key}) was not found")
        {

        }
    }
}