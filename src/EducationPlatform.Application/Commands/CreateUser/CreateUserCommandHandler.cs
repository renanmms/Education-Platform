using EducationPlatform.Application.Results;
using EducationPlatform.Core.Entities;
using EducationPlatform.Core.Interfaces.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore.Update;

namespace EducationPlatform.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IUserRepository _repository;
        public CreateUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.Fullname, request.Email, request.Password, request.BirthDate, request.Document, request.Phone, request.Role);

            var id = await _repository.CreateAsync(user);

            return id;
        }
    }

    // public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Guid>
    // {
    //     private readonly ICourseRepository _repository;
    //     public CreateCourseCommandHandler(ICourseRepository repository)
    //     {
    //         _repository = repository;
    //     }
    
    //     public async Task<Guid> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    //     {
    //         var course = new Course(request.Name, request.Description, request.Cover, request.CreatedAt, request.SubscriptionId);
    //         var id = await _repository.CreateAsync(course);
    //         return id;
    //     }
    // }
}