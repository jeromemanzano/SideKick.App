using Autofac;
using SideKick.App.Model.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideKick.App.Utilities.Modules
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MockUserService>().As<IUserService>().SingleInstance();
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
        }
    }
}
