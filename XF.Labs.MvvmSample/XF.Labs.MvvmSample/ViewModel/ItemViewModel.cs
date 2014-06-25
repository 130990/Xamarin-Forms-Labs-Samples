using System;
using Xamarin.Forms.Labs.Mvvm;

namespace XF.Labs.MvvmSample
{
	public class ItemViewModel : ViewModel
	{
		public ItemViewModel ()
		{
		}

		private Item _selectedItem = null;
		public Item SelectedItem{
			get{
				return _selectedItem;
			}
			set{ 
				this.ChangeAndNotify (ref _selectedItem, value);
			}
		}
	}
}

