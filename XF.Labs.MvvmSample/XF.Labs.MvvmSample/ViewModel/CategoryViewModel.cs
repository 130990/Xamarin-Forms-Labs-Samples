using System;
using Xamarin.Forms.Labs.Mvvm;
using System.Collections.ObjectModel;

namespace XF.Labs.MvvmSample
{
	public class CategoryViewModel : ViewModel
	{
		public CategoryViewModel ()
		{

		}

		private Category _selectedCategory = null;
		public Category SelectedCategory{
			get{
				return _selectedCategory;
			}
			set{ 

				this.ChangeAndNotify (ref _selectedCategory, value);
				Items.Clear ();
				foreach (var item in _selectedCategory.Items) {
					Items.Add (item);
				}
			}
		}

		private Item _selectedItem = null;
		public Item SelectedItem{
			get{
				return _selectedItem;
			}
			set{ 
				this.ChangeAndNotify (ref _selectedItem, value);
				//if this is not null we are navigating
				if(value != null)
					Navigation.PushAsync<ItemViewModel> ((vm,p) => {
						(vm as ItemViewModel).SelectedItem = _selectedItem;
					});
			}
		}

		private ObservableCollection<Item> _items= new ObservableCollection<Item> ();
		public ObservableCollection<Item> Items{
			get{
				return _items;
			}
			set{ 
				this.ChangeAndNotify(ref _items,value);
			}
		}
	}
}

