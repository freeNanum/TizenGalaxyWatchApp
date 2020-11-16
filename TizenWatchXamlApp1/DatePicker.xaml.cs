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
    public partial class DatePicker : ContentPage
    {
        public DatePicker()
        {
            InitializeComponent();
        }

        private void dp_DateSelected(object sender, DateChangedEventArgs e)
        {
            var Id = ((DatePicker)sender).Id;

            if(Id == dp.Id)
            {
                //DateTime dateTime = e.NewDate;

                Debug.WriteLine("Debug ===> {e.NewDate}");
                //labeDP.Text = $"{e.NewDate}";
                labeDP.Text = $"Setted !";

#if false
                int year = dateTime.Year;
                int mon = dateTime.Month;
                int day = dateTime.Day;

                String[] days = { "Sun", "Mon", "Tue", "Wen", "Tur", "Fri", "Sat" };
                String date = days[(int)dateTime.DayOfWeek];

                labeDP.Text = $"{year}Y {mon}M {day}D {date}";
#endif
            }
        }
    }
}