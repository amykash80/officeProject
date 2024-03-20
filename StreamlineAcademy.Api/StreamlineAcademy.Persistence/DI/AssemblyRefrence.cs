using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using StreamlineAcademy.Application.Abstractions.IRepositories;
using StreamlineAcademy.Persistence.Data;
using StreamlineAcademy.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Persistence.DI
{
    public static class AssemblyRefrence
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContextPool<StreamlineAcademyDbContet>(options => options.UseSqlServer(configuration.GetConnectionString(nameof(StreamlineAcademyDbContet))));
            services.AddScoped<IEnquiryRepository, EnquiryRepository>();
            services.AddScoped<IFileRepository, FileRepository>();
            return services;
        }
    }
}
