﻿using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Reflection;
using Trainer.Admin.BusinessLogic.Services;
using Trainer.Admin.Common.MappingProfiles;
using Trainer.Admin.DataAccess;

namespace Trainer.Admin.BusinessLogic.Extensions
{
    public static class CustomExtensions
    {
        public static void AddCustomServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddMediatR(Assembly.GetExecutingAssembly());

            service.AddScoped<DbConnectionFactory>();

            service.AddScoped<IDbConnection>(provider => provider
                .GetRequiredService<DbConnectionFactory>()
                .GetConnection());

            service.AddScoped<WordsService>();
            service.AddScoped<PhrasalVerbsService>();
        }

        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg => {
                cfg.AddProfile<WordProfile>();
                cfg.AddProfile<PhrasalVerbProfile>();
                cfg.AddProfile<ExampleProfile>();
            });
        }
    }
}
