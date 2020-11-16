using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenWatchXamlApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

#if true
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var Id = ((Button)sender).Id;

            if(Id == btn01.Id)
            {
                var newPage = new TizenWatchXamlApp1.ScrollViewVertical();
                await Navigation.PushAsync(newPage);
                //Debug.WriteLine("the new page is now showing");
            }
            else if (Id == btn02.Id)
            {
                var newPage = new TizenWatchXamlApp1.ScrollViewHori();
                await Navigation.PushAsync(newPage);
                //Debug.WriteLine("the new page is now showing");
            }
        }
#endif

    }
}