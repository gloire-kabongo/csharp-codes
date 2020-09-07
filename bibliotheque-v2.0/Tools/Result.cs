namespace LibraryManager.Tools
{
    public class Result
    {
        private readonly string _error;
        private readonly bool _success;

        private Result(bool success, string error = "")
        {
            _error = error;
            _success = success;
        }

        public bool Success { get => _success; }
        public string Error { get => _error; }

        public static Result Ok()
        {
            return new Result(true);
        }

        public static Result Failure(string error)
        {
            return new Result(false, error);
        }
    }
}


