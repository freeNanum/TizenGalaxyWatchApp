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
    public partial class PromptEx : ContentPage
    {
        public PromptEx()
        {
            InitializeComponent();
        }

        private async void OnBtn_Clicked(object sender, EventArgs e)
        {
            var Id = ((Button)sender).Id;

            String resultName;
            String resultCal;
            if (Id == NameBtn.Id)
            {
                resultName = await DisplayPromptAsync("Name", "What's your name?", "OK", "Cancel", 
                    "=> Input here.", keyboard:Keyboard.Text);

                if (!string.IsNullOrWhiteSpace(resultName))
                {
                    RstName.Text = $"result: {resultName}";
                }

            }
            else if (Id == CalBtn.Id)
            {
                resultCal = await DisplayPromptAsync("Question", "What's (7 + 2) ?", "OK", "Cancel", 
                    "=> Input here.", keyboard: Keyboard.Numeric);

                if (!string.IsNullOrWhiteSpace(resultCal))
                {
                    int num = Convert.ToInt32(resultCal);
                    RstCal.Text = num == 9? "Right answer": "Wrong answer";
                }

            }

        }
    }
}