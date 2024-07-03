using EducationPlatform.Application.Results.Errors;

namespace EducationPlatform.Application.Results
{
    public class Result : ResultBase
    {
        private Result(bool isSuccess, Error error)
        {
            if(isSuccess && error != Error.None || !isSuccess && error == Error.None)
            {
                throw new ArgumentException("Invalid error", nameof(error));
            }

            IsSuccess = isSuccess;
            Error = error;
        }

        public static Result Success() => new(true, Error.None);
        public static Result Failure(Error error) => new(false, error);
    }

    public class Result<TValue> : ResultBase<TValue>
    {
        private Result(bool isSuccess, Error error)
        {
            if(isSuccess && error != Error.None || !isSuccess && error == Error.None)
            {
                throw new ArgumentException("Invalid error", nameof(error));
            }

            IsSuccess = isSuccess;
            Error = error;
        }

        protected Result(bool isSuccess, TValue value)
        {
            _value = value;
            IsSuccess = isSuccess;
        }

        public static Result<TValue> Success<T>(TValue value) => new(true, value);
        public static Result<TValue> Failure<T>(Error error) => new(false, error);
    }
}