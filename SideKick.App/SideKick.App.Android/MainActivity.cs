using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SideKick.App.Utilities;
using Autofac;
using SideKick.App.Droid.Services;
using Plugin.CurrentActivity;

namespace SideKick.App.Droid
{
    [Activity(Label = "SideKick.App", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            CrossCurrentActivity.Current.Init(this, savedInstanceState);
            LoadApplication(InitializeContainer());
        }

        private SideKick.App.App InitializeContainer()
        {
            AutofacBootstrapper.RegisterAutofacModules(new AndroidModule());
            //return instance of App
            return AutofacBootstrapper.Instance.Resolve<SideKick.App.App>();
        }
    }
}