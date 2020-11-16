using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using Color = Xamarin.Forms.Color;

namespace TizenWatchXamlApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutEx : ContentPage
    {
        public AbsoluteLayoutEx()
        {
            //InitializeComponent();

            AbsoluteLayout absoluteLayout = new AbsoluteLayout();

            Label label01 = new Label
            {
                Text = "AbsoluteLayout w/ C# codes",
                BackgroundColor = new Color(255, 0, 0)
            };
            //label01.FontSize = new Size(50, 10);

            AbsoluteLayout.SetLayoutBounds(label01, new Rectangle(0.5, 0.3, 200, 100));
            AbsoluteLayout.SetLayoutFlags(label01, AbsoluteLayoutFlags.PositionProportional);

            absoluteLayout.Children.Add(label01);

            Label label02 = new Label
            {
                Text = "Green",
                BackgroundColor = new Color(0, 255, 0)
            };
            //label01.FontSize = new Size(50, 10);

            AbsoluteLayout.SetLayoutBounds(label02, new Rectangle(0.3, 0.7, 100, 100));
            AbsoluteLayout.SetLayoutFlags(label02, AbsoluteLayoutFlags.PositionProportional);

            absoluteLayout.Children.Add(label02);

            Label label03 = new Label
            {
                Text = "Blue",
                BackgroundColor = new Color(0, 0, 255)
            };
            //label01.FontSize = new Size(50, 10);

            AbsoluteLayout.SetLayoutBounds(label03, new Rectangle(0.7, 0.7, 80, 50));
            AbsoluteLayout.SetLayoutFlags(label03, AbsoluteLayoutFlags.PositionProportional);

            absoluteLayout.Children.Add(label03);

            this.Content = absoluteLayout;

        }
    }
}