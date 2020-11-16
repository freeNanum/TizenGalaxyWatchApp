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
    public partial class SliderEx : ContentPage
    {
        public SliderEx()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var Id = ((Slider)sender).Id;

            if (Id == slider01.Id) 
            {
                Debug.WriteLine($"slider01 value: {slider01.Value} "); // slider01.Value same to e.NewValue.

                if (label01 != null)
                {
                    label01.Text = String.Format("Slider01 = {0}", e.NewValue*10);// 0~10
                }
            }
#if true
            else if (Id == slider02.Id)
            {
                Debug.WriteLine($"slider02 value: {slider02.Value} ");

                if (label02 != null)
                {
                    label02.Text = String.Format("Slider02 = {0}", e.NewValue);
                }
            }
#endif
        }
    }
}