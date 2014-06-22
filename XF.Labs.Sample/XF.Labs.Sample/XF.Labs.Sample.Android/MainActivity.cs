using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms.Labs.Droid;
using Xamarin.Forms.Labs.Mvvm;
using Xamarin.Forms.Labs.Services;
using Xamarin.Forms.Labs.Services.Serialization;
using Xamarin.Forms.Labs.Caching.SQLiteNet;
using System.IO;
using Xamarin.Forms.Labs;


namespace XF.Labs.Sample.Droid
{
    [Activity(Label = "XF.Labs.Sample", MainLauncher = true, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class MainActivity : XFormsApplicationDroid
    {
        /// <summary>
        /// Indicated if the application has been initialized
        /// </summary>
        private static bool _initialized;

	
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            if (!_initialized)
            {
                this.SetIoc();
            }   

            Xamarin.Forms.Forms.Init(this, bundle);
            App.Init();

            SetPage(App.GetMainPage());
        }


        /// <summary>
        /// Sets the IoC.
        /// </summary>
        private void SetIoc()
        {
            var resolverContainer = new SimpleContainer();

            var app = new XFormsAppDroid();

            var documents = Environment.ExternalStorageDirectory.AbsolutePath;
            var pathToDatabase = Path.Combine(documents, "xforms.db");

            app.Init(this);

            resolverContainer.Register<IDevice>(t => AndroidDevice.CurrentDevice)
                .Register<IDisplay>(t => t.Resolve<IDevice>().Display)
                .Register<IJsonSerializer, Xamarin.Forms.Labs.Services.Serialization.ServiceStackV3.JsonSerializer>()
                .Register<IDependencyContainer>(resolverContainer)
                .Register<IXFormsApp>(app)
                .Register<ISimpleCache>(t => new SQLiteSimpleCache(new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(),
                    new SQLite.Net.SQLiteConnectionString(pathToDatabase, true), t.Resolve<IJsonSerializer>()));


            Resolver.SetResolver(resolverContainer.GetResolver());

            _initialized = true;
        }
    }
}

