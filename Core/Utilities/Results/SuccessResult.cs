namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
            Message = message;
        }

        public SuccessResult() : base(true)
        {
        }
    }
}