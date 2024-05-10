namespace EducationPlatform.API.Shared.Interfaces
{
    public interface IResultBase
    {
        Error? Error { get; }
        bool IsSuccess { get; }
    }
}