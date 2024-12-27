using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService (IServiceCollection serviceCollection){
            serviceCollection.AddTransient<IUserService, UserService> ();   
        }
    }
}
