using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;

namespace AspNetCoreTemplate.Client.Web.Configuration
{
    //TODO Rename method
    public class ContainerConfiguration
    {
        public static void Configure(ContainerBuilder builder)
        {
            
            //builder.RegisterType<MainUnitOfWork>().As<IUnitOfWork>();
        }
    }
}
