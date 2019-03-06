using Autofac;
using SideKick.App.View;
using SideKick.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SideKick.App.Model.Services
{
    public class NavigationService : INavigationService
    {
        private readonly ILifetimeScope _scope;
        public NavigationService(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public Page GetMainPage()
        {
            var mainPage = _scope.Resolve<MainPage>();
            var mainVM = _scope.Resolve<MainViewModel>();
            mainPage.BindingContext = mainVM;
            mainVM.InitPage();

            return mainPage;
        }
    }
}
