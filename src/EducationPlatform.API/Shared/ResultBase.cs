using EducationPlatform.API.Shared.Interfaces;

namespace EducationPlatform.API.Shared
{
    public class ResultBase : IResultBase
    {
        protected ResultBase(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        protected ResultBase(bool isSuccess, Error error)
        {
            if(isSuccess && error != Error.None ||
               !isSuccess && error == Error.None)
            {
                throw new ArgumentException("Invalid error", nameof(error));
            }

            IsSuccess = isSuccess;
            Error = error;
        }

        public Error? Error { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsFailure => !IsSuccess;
    }

    public class ResultBase<TValue> : ResultBase
    {
        protected ResultBase(bool isSuccess, Error error) 
            : base(isSuccess, error) { }

        protected ResultBase(bool isSuccess, TValue value)
            :base(isSuccess)
        {
            _value = value;
        }

        protected TValue? _value;
        public TValue? Value => _value;
        public TValue? ValueOrDefault => _value ?? default;
    }
}