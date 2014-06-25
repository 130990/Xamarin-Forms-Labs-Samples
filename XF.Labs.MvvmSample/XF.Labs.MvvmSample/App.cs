using System;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Mvvm;

namespace XF.Labs.MvvmSample
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			//we are registering the viewmodels and respective view
			//this don't have to create them or set the normal bindings
			ViewFactory.Register<MainPage,MainViewModel>();
			ViewFactory.Register<CategoryPage,CategoryViewModel>();
			ViewFactory.Register<ItemPage,ItemViewModel>();
		
			return new NavigationPage (ViewFactory.CreatePage<MainViewModel> ());
		}
	}
}

