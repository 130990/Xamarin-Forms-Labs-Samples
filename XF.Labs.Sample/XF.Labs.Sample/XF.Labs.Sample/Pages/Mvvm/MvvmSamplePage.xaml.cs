﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Mvvm;

namespace XF.Labs.Sample
{	
	public partial class MvvmSamplePage : BaseView
	{	
		public MvvmSamplePage ()
		{
			InitializeComponent ();
			this.BindingContext = new MvvmSampleViewModel ();
		}
	}
}

