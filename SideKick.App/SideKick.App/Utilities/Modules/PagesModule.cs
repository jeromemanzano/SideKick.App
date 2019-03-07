using Autofac;
using SideKick.App.View;
using SideKick.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideKick.App.Utilities.Modules
{
    public class PagesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<App>().AsSelf().SingleInstance();
            builder.RegisterType<MainPage>().AsSelf().InstancePerDependency();
            builder.RegisterType<MainViewModel>().AsSelf();
        }
    }
}
