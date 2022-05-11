using ImpactaLawTech.ToDo.Domain.Interfaces;
using ImpactaLawTechToDo.Application.DTO;
using ImpactaLawTechToDo.Application.Interfaces;
using ImpactaLawTechToDo.Application.Mappings;
using ImpactaLawTechToDo.Application.Services;
using ImpactaLawTechToDo.Infra.Data.Context;
using ImpactaLawTechToDo.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ImpactaLawTechToDo.Infra.IoC.Dependency_Resolvers
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
           
            services.AddDbContext<ApplicationDBContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                db => db.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName)));

            services.AddScoped<ITaskRepository, TasksRepository>();
            services.AddScoped<ITasksService, TasksService>();

            services.AddScoped<IUserRepository, UserRepository> ();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IUserTasksRepository, UserTaskRepository>();
            services.AddScoped<IUserTasksService, UserTasksService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));


            return services;
        }
    }
}
