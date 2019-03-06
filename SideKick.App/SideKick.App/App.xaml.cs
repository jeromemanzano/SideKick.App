using SideKick.App.Model.Services;
using SideKick.App.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SideKick.App
{
    public partial class App : Application
    {
        public App(INavigationService navigation)
        {
            InitializeComponent();

            MainPage = navigation.GetMainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
