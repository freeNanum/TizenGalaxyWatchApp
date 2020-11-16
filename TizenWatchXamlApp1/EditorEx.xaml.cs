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
    public partial class EditorEx : ContentPage
    {
        public EditorEx()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.DisplayAlert("User Message", eMsg.Text.Count() != 0? eMsg.Text: "None", "Close");
        }
    }
}