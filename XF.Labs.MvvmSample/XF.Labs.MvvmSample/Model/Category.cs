using System;
using System.Collections.Generic;

namespace XF.Labs.MvvmSample
{
	public class Category
	{
		public Category ()
		{
			Items = new List<Item> ();
		}

		public string Name {
				get;
				set;
		}

		public List<Item> Items {
			get;
			set;
		}
	}
}