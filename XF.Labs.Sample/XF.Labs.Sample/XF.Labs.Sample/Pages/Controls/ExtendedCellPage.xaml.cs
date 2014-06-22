using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XF.Labs.Sample
{	
	public partial class ExtendedCellPage : ContentPage
	{	
		public ExtendedCellPage ()
		{
			InitializeComponent ();
			BindingContext = ViewModelLocator.Main;
		}
	}
}

