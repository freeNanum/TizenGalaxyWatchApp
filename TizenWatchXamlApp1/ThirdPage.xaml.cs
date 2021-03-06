﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenWatchXamlApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var Id = ((Button)sender).Id;

            if (Id == prevBtn.Id)
            {
                await Navigation.PopAsync();
                //Debug.WriteLine("the new page is now showing");
            }
            else if (Id == nextBtn.Id)
            {
                await Navigation.PopToRootAsync();
                //Debug.WriteLine("the new page is now showing");
            }
        }

    }
}