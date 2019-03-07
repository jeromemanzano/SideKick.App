using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideKick.App.Utilities.Modules
{
    public class AutofacBootstrapper
    {        
        /// <summary>
        /// Gets or sets the instance of autofac lifetime scope.
        /// </summary>
        public static ILifetimeScope Instance { get; set; }


        /// <summary>
        /// Registers the autofac modules. Modules are used for registering classes
        /// </summary>
        /// <param name="platformModule">module used for registering platform specific services</param>
        public static void RegisterAutofacModules(Module platformModule = null)
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new ServicesModule());
            containerBuilder.RegisterModule(new ManagersModule());
            containerBuilder.RegisterModule(new PagesModule());

            if (platformModule != null)
            {
                containerBuilder.RegisterModule(platformModule);
            }

            Instance = containerBuilder.Build().BeginLifetimeScope();
        }
    }
}
