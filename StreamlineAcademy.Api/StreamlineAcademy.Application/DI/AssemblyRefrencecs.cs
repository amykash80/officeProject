using Microsoft.Extensions.DependencyInjection;
using StreamlineAcademy.Application.Abstractions.IServices;
using StreamlineAcademy.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.DI
{
    public static class AssemblyRefrencecs
    {

        public static IServiceCollection AddAplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IEnquiryService,EnquiryService>();
            return services;
        }
    }
}
