using System;
using Xamarin.Forms.Labs;
using Xamarin.Forms.Labs.Mvvm;

namespace XF.Labs.Sample
{
	[ViewType(typeof(MvvmSamplePage))]
	public class MvvmSampleViewModel : ViewModel
	{
		public MvvmSampleViewModel ()
		{
		
		}


		private RelayCommand _navigateToViewModel;
		public RelayCommand NavigateToViewModel 
		{
			get
			{ 
				return _navigateToViewModel ?? new RelayCommand (
					async () => await Navigation.PushAsync<NewPageViewModel>() , 
					() => true); 
			}
		}

		private string _navigateToViewModelButtonText = "Navigate to another view model";
		public string NavigateToViewModelButtonText
		{
			get
			{
				return _navigateToViewModelButtonText;
			}
			set
			{ 
				this.ChangeAndNotify(ref _navigateToViewModelButtonText, value);
			}
		}

	}
}

