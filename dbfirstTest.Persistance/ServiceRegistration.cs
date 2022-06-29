using dbfirstTest.Application.Repositories;
using dbfirstTest.Persistance.Repositories;
using dbfirstTest.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbfirstTest.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            //services.AddScoped<IGunlukMakineReadRepository , GunlukMakineReadRepository>();
            services.AddTransient<IOpcVardiyaReadRepository, VardiyaReadRepository>();
            services.AddTransient<IGunlukMakineReadRepository, GunlukMakineReadRepository>();

        }
    }
}
