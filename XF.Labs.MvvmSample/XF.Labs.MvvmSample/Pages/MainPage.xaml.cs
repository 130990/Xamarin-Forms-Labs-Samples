using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Mvvm;

namespace XF.Labs.MvvmSample
{	
	public partial class MainPage : BaseView
	{	
		public MainPage ()
		{
			InitializeComponent ();
		}

		protected override void OnAppearing ()
		{
			(this.BindingContext as MainViewModel).SelectedCategory = null;
			base.OnAppearing ();
		}
	}
}

