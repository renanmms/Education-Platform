using EducationPlatform.Application.Commands.CreateCourse;
using EducationPlatform.Core.Interfaces.Repositories;
using EducationPlatform.Infrastructure.Persistence;
using EducationPlatform.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("EducationPlatformCS");
builder.Services.AddDbContext<EducationPlatformDbContext>(
    options => options.UseNpgsql(connectionString)
);

builder.Services.AddScoped<ICourseRepository, CourseRepository>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateCourseCommand>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
