using EducationPlatform.Application.Results.Errors;

namespace EducationPlatform.Application.Results.Interfaces
{
    public interface IResultBase
    {
        Error? Error { get; }
        bool IsSuccess { get; }
    }
}