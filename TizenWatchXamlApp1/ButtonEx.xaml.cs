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
    public partial class ButtonEx : ContentPage
    {
        public ButtonEx()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            var btnId = ((Button)sender).Id;

            if(btnId == btn01.Id)
            {
                Debug.WriteLine("Debug ---> Button01 Clicked!!");
                this.DisplayAlert("Button01", "Button01 Clicked\n" + "id: " + btnId.ToString(), "Close");
            }
            else if (btnId == btn02.Id)
            {
                Debug.WriteLine("Debug ---> Button02 Clicked!!");
                this.DisplayAlert("Button02", "Button02 Clicked\n" + "id: " + btnId.ToString(), "Accept", "Cancel");
            }
            else if (btnId == btn03.Id)
            {
                Debug.WriteLine("Debug ---> Button03 Clicked!!");
                this.DisplayAlert("Button03", "Button03 Clicked\n" + "id: " + btnId.ToString(), "Close");
            }
        }
    }
}