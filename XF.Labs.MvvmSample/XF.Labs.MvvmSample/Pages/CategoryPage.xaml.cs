using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Mvvm;

namespace XF.Labs.MvvmSample
{	
	public partial class CategoryPage : BaseView
	{	
		public CategoryPage ()
		{
			InitializeComponent ();
		}

		protected override void OnAppearing ()
		{
			//this is a cuting corners to remove the selection so we can navigate to the same item
			(this.BindingContext as CategoryViewModel).SelectedItem = null;
			base.OnAppearing ();
		}
	}
}

