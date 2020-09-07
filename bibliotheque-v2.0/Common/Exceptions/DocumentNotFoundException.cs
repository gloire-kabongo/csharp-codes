using System;

namespace LibraryManager.Common.Exceptions
{
    public class DocumentNotFoundException : Exception
    {
        public DocumentNotFoundException(uint numeroEnregistrement)
            : base($"Document No \"{numeroEnregistrement}\" not found")
        {}
    }
}