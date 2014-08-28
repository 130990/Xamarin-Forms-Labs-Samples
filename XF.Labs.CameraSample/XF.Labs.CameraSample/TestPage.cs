using System;
using System.Threading.Tasks;

using Xamarin.Forms;

using Xamarin.Forms.Labs;
using Xamarin.Forms.Labs.Services;
using Xamarin.Forms.Labs.Services.Media;
 


namespace XF.Labs.CameraSample
{

	public class TestPage : ContentPage
	{
		private ImageSource imageSource;
		private IMediaPicker mediaPicker;
		private Image img;
		private string status;

		public TestPage ()
		{
			this.Title = "Camera Test";


			NavigationPage.SetHasNavigationBar (this, false);


			img = new Image(){HeightRequest = 300, WidthRequest = 300, BackgroundColor = Color.FromHex("#D6D6D2"),Aspect = Aspect.AspectFit };
		

			var addPictureButton = new Button() { Text="Select Picture", 
				Command = new Command(async ()=>{ await SelectPicture(); })
			};


			StackLayout stack = new StackLayout();
			stack.VerticalOptions = LayoutOptions.FillAndExpand;

			stack.Children.Add (new BoxView {Color = Color.Transparent, HeightRequest = 20});
			stack.Children.Add ( addPictureButton );
			stack.Children.Add ( img );


			ScrollView scrollview = new ScrollView {
				Orientation = ScrollOrientation.Vertical,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Content = stack

			};

			this.Content = new StackLayout {
				Children = {scrollview}
			};


		}


		private async Task SelectPicture()
		{

			mediaPicker = DependencyService.Get<IMediaPicker>();

			imageSource = null;

			try
			{
				var mediaFile = await mediaPicker.SelectPhotoAsync(new CameraMediaStorageOptions
					{
						DefaultCamera = CameraDevice.Front,
						MaxPixelDimension = 400
					});
				imageSource = ImageSource.FromStream(() => mediaFile.Source);
				img.Source  = imageSource;
			}
			catch (System.Exception ex)
			{
				this.status = ex.Message;
			}
		}



	}

}




