using System;

namespace ToDo.Domain.Exceptions
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(int id)
            : base($"item {id} was not found")
        {

        }
    }
}