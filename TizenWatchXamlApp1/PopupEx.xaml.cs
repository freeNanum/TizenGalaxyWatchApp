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
    public partial class PopupEx : ContentPage
    {
        public PopupEx()
        {
            InitializeComponent();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            var Id = ((Button)sender).Id;

            if(Id == btn01.Id)
            {
                Debug.WriteLine($"btn01 clicked");
                await DisplayAlert("Alert", $"Button Clicked!", "Cancel");
                labelPopup.Text = $"Result: None";
            }
            else if(Id == btn02.Id)
            {
                Debug.WriteLine($"btn02 clicked");
                bool rFlag = await DisplayAlert("Choose", $"Do you want?", "yes", "No");
                Debug.WriteLine($"Debug ==> resultFlag: {rFlag}");
                labelPopup.Text = $"Result: {rFlag}";

            }
            else if (Id == btn03.Id)
            {
                Debug.WriteLine($"btn03 clicked");
                String rStr = await DisplayActionSheet("Select", "Cancel", null, "Korea", "China", "England", "Denmark");
                Debug.WriteLine($"Debug ==> resultString: {rStr}");
                labelPopup.Text = $"Result: {rStr}";
            }

        }
    }
}