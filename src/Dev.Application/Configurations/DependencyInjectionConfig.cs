using Dev.Business.Interfaces;
using Dev.Business.Interfaces.Repositories;
using Dev.Business.Interfaces.Services;
using Dev.Business.Notificacoes;
using Dev.Data.Context;
using Dev.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.Application.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IContatoRepository, ContatoRepository>();
            services.AddScoped<IContatoService, ContatoService>();

            services.AddScoped<INotificador, Notificador>();

            return services;
        }

    }
}
