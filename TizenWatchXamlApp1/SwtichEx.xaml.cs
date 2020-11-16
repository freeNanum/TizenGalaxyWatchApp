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
    public partial class SwtichEx : ContentPage
    {
        public SwtichEx()
        {
            InitializeComponent();
        }

        private void OnToggled(object sender, ToggledEventArgs e)
        {
            var Id = ((Xamarin.Forms.Switch)sender).Id;

            if (Id == swPizza.Id)
            {
                Debug.WriteLine($"Pizza: {swPizza.IsToggled}");
            }
            else if(Id == swCock.Id)
            {
                Debug.WriteLine($"Cock: {swCock.IsToggled}");
            }

            printMenu();
        }

        private void printMenu()
        {
            labelSWMenu.Text = $"<Selected Menu>\n " +
                $"   Pizza: {swPizza.IsToggled}\n " +
                $"   Cock: {swCock.IsToggled}";
        }
    }
}