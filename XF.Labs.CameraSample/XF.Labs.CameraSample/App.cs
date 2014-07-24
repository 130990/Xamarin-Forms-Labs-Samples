using System;
using Xamarin.Forms;
using Xamarin.Forms.Labs.Services.Media;

namespace XF.Labs.CameraSample
{
    public class App
    {
        public static Page GetMainPage ()
        {    
            return new ContentPage { 
                Content = new Button() {
                    Text="Take Picture", 
                    Command = new Command(async ()=>{
                        var mediaPicker = DependencyService.Get<IMediaPicker>();
                        var result = await mediaPicker.TakePhotoAsync(new CameraMediaStorageOptions { DefaultCamera = CameraDevice.Front, MaxPixelDimension = 400 });
                        })

                }
            };
        }
    }
}

