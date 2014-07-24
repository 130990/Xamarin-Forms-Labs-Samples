using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Labs.iOS;
using Xamarin.Forms.Labs;
using Xamarin.Forms.Labs.Services;
using Xamarin.Forms.Labs.Mvvm;

namespace XF.Labs.CameraSample.iOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : XFormsApplicationDelegate
    {
        UIWindow window;

        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            Forms.Init ();

            //this.SetIoc();

            window = new UIWindow (UIScreen.MainScreen.Bounds);
            
            window.RootViewController = App.GetMainPage ().CreateViewController ();
            window.MakeKeyAndVisible ();
            
            return true;
        }
        /// <summary>
        /// Sets the IoC.
        /// </summary>
//        private void SetIoc()
//        {
//            var resolverContainer = new SimpleContainer ();
//
//            var app = new XFormsAppiOS ();
//
//            app.Init(this);
//            resolverContainer.Register<IDevice> (t => AppleDevice.CurrentDevice)
//                .Register<IXFormsApp> (app);
//            }
    }
}

