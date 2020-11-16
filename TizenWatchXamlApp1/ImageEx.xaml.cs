using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenWatchXamlApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageEx : ContentPage
    {
        public ImageEx()
        {
            InitializeComponent();

            StackLayout stacklayout = new StackLayout()
            {
                //BackgroundColor = Color.White
            };
            Label label01 = new Label
            {
                Text = "Using FromUrI",
                HorizontalOptions = LayoutOptions.Center,
                Margin = 30,
            };

#if true //Not supported
            string uri = "https://developer.xamarin.com/demo/IMG_1415.JPG";

            Image image01 = new Image
            {
                BackgroundColor = Color.FromHex("00ff00"),
                Source = ImageSource.FromUri(new Uri(uri)),
                //Source = ImageSource.FromUri(new Uri("https://craftroom.tizen.org/wp-content/themes/craftroom/assets/images/Tizen-Pinwheel-On-Light-RGB.png")),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 50,
                HeightRequest = 50,
            };
#endif
            Label label02 = new Label
            {
                Text = "Using FromResource",
                HorizontalOptions = LayoutOptions.Center,
                Margin= 10,

            };

            Image image02 = new Image
            {
                //BackgroundColor = Color.Blue,
                Source = ImageSource.FromResource("TizenWatchXamlApp1.asset.img.Tizen-logo.png"),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 80,
                HeightRequest  = 80,

            };

            stacklayout.Children.Add(label01);
            stacklayout.Children.Add(image01);
            stacklayout.Children.Add(label02);
            stacklayout.Children.Add(image02);

            this.Content = stacklayout;


        }
    }
}