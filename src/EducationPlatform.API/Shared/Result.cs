namespace EducationPlatform.API.Shared
{
    public class Result : ResultBase
    {
        private Result(bool isSuccess, Error error) 
            : base(isSuccess, error) { }

        public static Result Success() => new(true, Error.None);
        public static Result Failure(Error error) => new(false, error);
    }

    public class Result<TValue> : ResultBase<TValue>
    {
        private Result(bool isSuccess, Error error)
            : base(isSuccess, error) { }

        private Result(bool isSuccess, TValue value)
            : base(isSuccess, value) { }

        public static Result<TValue> Success<TValue>(TValue value) => new(true, value);
        public static Result<TValue> Failure(Error error) => new(false, error);
    }
}