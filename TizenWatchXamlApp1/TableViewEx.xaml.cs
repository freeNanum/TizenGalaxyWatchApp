using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenWatchXamlApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableViewEx : ContentPage
    {
        public TableViewEx()
        {
            InitializeComponent();

            this.Content = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection("Mail")
                    {
                        new SwitchCell
                        {
                            Text = "New Mail",
                            On = false
                        },
                        new SwitchCell
                        {
                            Text = "New Voice Mail",
                            On = true
                        }
                    },

                    new TableSection("Messages")
                    {
                        new SwitchCell
                        {
                            Text = "New Message Service",
                            On = true
                        },
                        new SwitchCell
                        {
                            Text = "New Mutimedia Mail",
                            On = false
                        }
                    }
                }
            };
        }
    }
}