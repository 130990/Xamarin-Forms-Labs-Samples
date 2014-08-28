using System;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Services.Media;

namespace XF.Labs.CameraSample
{
    public class App
    {
        public static Page GetMainPage ()
		{ 			
			var mainNav = new NavigationPage (new TestPage ());

			return mainNav;
        }
    }
}

