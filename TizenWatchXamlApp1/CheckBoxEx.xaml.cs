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
    public partial class CheckBoxEx : ContentPage
    {
        public CheckBoxEx()
        {
            InitializeComponent();
        }

        private void cbOnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var Id = ((CheckBox)sender).Id;

            if (Id == cbPizza.Id)
            {
                Debug.WriteLine($"cbPizza: {cbPizza.IsChecked}");
            }
            else if (Id == cbCock.Id)
            {
                Debug.WriteLine($"cbCock: {cbCock.IsChecked}");
            }
#if false
            else if (Id == cbHam.Id)
            {
                Debug.WriteLine($"chHam: {cbHam.IsChecked}");
                ;
            }
#endif

            resultMenu();
        }

        private void resultMenu()
        {
            labelMenu.Text = $"<Selected Menu>\n" +
                $"  Pizza: {cbPizza.IsChecked}\n" +
                $"  Cock : {cbCock.IsChecked}\n";
                
        }
    }
}