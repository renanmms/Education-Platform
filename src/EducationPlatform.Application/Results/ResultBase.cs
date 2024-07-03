using EducationPlatform.Application.Results.Errors;
using EducationPlatform.Application.Results.Interfaces;

namespace EducationPlatform.Application.Results
{
    public abstract class ResultBase : IResultBase
    {
        public Error? Error { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsFailure => !IsSuccess;
    }

    public abstract class ResultBase<TValue> : ResultBase
    {
        protected TValue? _value;
        public TValue? Value => _value;
        public TValue? ValueOrDefault => _value ?? default;
    }
}