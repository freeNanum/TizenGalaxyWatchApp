﻿using System;
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

            if(Id == prevBtn.Id)
            {
#if true
                await DisplayAlert("안내", "첫번째 페이지입니다.", "확인");
#else
                var newPage = new TizenWatchXamlApp1.ScrollViewVertical();
                await Navigation.PushAsync(newPage);
                //Debug.WriteLine("the new page is now showing");
#endif
            }
            else if (Id == nextBtn.Id)
            {
                var newPage = new TizenWatchXamlApp.SecondPage();
                await Navigation.PushAsync(newPage);
                //Debug.WriteLine("the new page is now showing");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
#endif

            }
}