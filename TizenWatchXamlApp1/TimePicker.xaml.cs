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
    public partial class TimePicker : ContentPage
    {
        public TimePicker()
        {
            InitializeComponent();
        }

        private void tp_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var Id = ((TimePicker)sender).Id;

#if false

            if (Id == tp.Id)
            {
                if (e.PropertyName == "Time")
                {
                    //labeTP.Text = tp.Time.ToString();

                    int h = tp.Time.Hours;
                    int m = tp.Time.Minutes;
                    int s = tp.Time.Seconds;

                    labeTP.Text = $"{h}h {m}m {s}s";


                }
            }
#endif
        }
    }
}