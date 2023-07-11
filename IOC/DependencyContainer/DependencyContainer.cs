using Application.Services.Implementation;
using Application.Services.Interfaces;
using Data.Repositories;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.DependencyContainer
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            #region Repository
            services.AddScoped<IActivitiesRepository , ActivitiesRepository>();

            #endregion

            #region Services
            services.AddScoped<IActivitiesServices, ActivitiesServices>();


            #endregion
        }
    }
}
