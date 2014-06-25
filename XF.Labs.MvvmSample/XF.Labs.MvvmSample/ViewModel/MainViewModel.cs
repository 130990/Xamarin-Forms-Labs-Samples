using System;
using Xamarin.Forms.Labs.Mvvm;
using System.Collections.ObjectModel;

namespace XF.Labs.MvvmSample
{
	public class MainViewModel : ViewModel
	{
		public MainViewModel ()
		{
			CreateSampleData ();
		}

		void CreateSampleData ()
		{
			Categories.Add (new Category () {
				Name = "Category 1"
			});
			Categories.Add (new Category () {
				Name = "Category 2"
			});
			Categories.Add (new Category () {
				Name = "Category 3"
			});
			Categories.Add (new Category () {
				Name = "Category 4"
			});
			Categories.Add (new Category () {
				Name = "Category 5"
			});
			int j = 1;
			foreach (var cat in Categories) {
				for (int i = 0; i < 10; i++) {
					cat.Items.Add (new Item () {
						Id = j,
						Name = string.Format ("Item nº {0} of {1}", i, cat.Name)
					});
					j++;
				}
			}
		}

		private ObservableCollection<Category> _categories= new ObservableCollection<Category> ();
		public ObservableCollection<Category> Categories{
			get{
				return _categories;
			}
			set{ 
				this.ChangeAndNotify(ref _categories,value);
			}
		}

		public string PageName{
			get{
				return "Main categories";
			}
		}

		private Category _selectedCategory = null;
		public Category SelectedCategory{
			get{
				return _selectedCategory;
			}
			set{ 
				this.ChangeAndNotify (ref _selectedCategory, value);
				if (value != null) {
					Navigation.PushAsync<CategoryViewModel> ((vm,p) => {
						(vm as CategoryViewModel).SelectedCategory = _selectedCategory;
					});
				}

			}
		}
	}
}

