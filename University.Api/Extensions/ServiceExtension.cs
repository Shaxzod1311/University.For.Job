using Microsoft.Extensions.DependencyInjection;
using University.Data.IRepositories;
using University.Data.Repositories;
using University.Domain.Common;
using University.Domain.Entities;
using University.Service.Interfaces;
using University.Service.Services;

namespace University.Api.Extensions
{
    public static class ServiceExtension
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentService, StudentServiec>();

        }
    }
}
