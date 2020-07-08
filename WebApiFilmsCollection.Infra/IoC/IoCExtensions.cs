using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiFilmsCollection.Application.Contracts.Services;
using WebApiFilmsCollection.Application.Services;
using WebApiFilmsCollection.Core.Contracts.Repositories;
using WebApiFilmsCollection.Core.Contracts.Services;
using WebApiFilmsCollection.Core.Services;
using WebApiFilmsCollection.Infra.Data.Context;

namespace WebApiFilmsCollection.Infra.IoC
{
    public static class IoCExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IFilmeRepository, FilmeRepository>();
            services.AddScoped<IFilmeService, FilmeService>();
            services.AddScoped<IFilmeAppService, FilmeAppService>();
        }
    }
}
