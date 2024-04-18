using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HRLeaveManagement.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void CongfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
