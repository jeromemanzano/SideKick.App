using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.CurrentActivity;
using SideKick.App.Model.Services;

namespace SideKick.App.Droid.Services
{
    public class AppService : IAppService
    {
        public void Exit()
        {
            var activity = CrossCurrentActivity.Current.Activity;
            activity.FinishAffinity();
        }
    }
}