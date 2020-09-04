namespace LibraryManager.Utils
{
    public class Result
    {
        private Result(string error = "", bool isSuccess = true)
        {
            Error = error;
            IsSuccess = isSuccess;
        }

        public string Error { get; private set; }
        public bool IsSuccess { get; private set; }

        public static Result Ok() => new Result();

        public static Result Failure(string error) =>
            new Result(error, false);
    }
}