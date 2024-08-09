using EducationPlatform.Core.Interfaces.Repositories;
using EducationPlatform.Infrastructure.Repositories;

namespace EducationPlatform.API
{
    public static class InfrastructureModule
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
            services.AddScoped<IModuleRepository, ModuleRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
