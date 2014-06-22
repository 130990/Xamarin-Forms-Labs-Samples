using System;
using System.Collections.Generic;
using System.Text;
using XF.Labs.Sample;

namespace XF.Labs.Sample
{
	public class ViewModelLocator
    {
		private static MainViewModel _main;
		public static MainViewModel Main
        {
            get
            {
				if (_main == null)
					_main = new MainViewModel ();
				return _main;
            }
        }
    }
}
