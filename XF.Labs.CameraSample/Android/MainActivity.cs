using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Labs.Droid;


namespace XF.Labs.CameraSample.Android
{
    [Activity (Label = "XF.Labs.CameraSample.Android.Android", MainLauncher = true)]
    public class MainActivity : XFormsApplicationDroid    {
      
        protected override void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);

            Xamarin.Forms.Forms.Init (this, bundle);

            SetPage (App.GetMainPage ());
        }
    }
}

