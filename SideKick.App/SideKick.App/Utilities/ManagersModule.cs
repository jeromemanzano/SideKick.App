using Autofac;
using SideKick.App.Model.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideKick.App.Utilities
{
    public class ManagersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserManager>().SingleInstance();
        }
    }
}
