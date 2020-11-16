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
    public partial class EntryEx : ContentPage
    {
        public EntryEx()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string strInfo = String.Format($"Name: {eName.Text}\n" +
                $"Id: {eId.Text}\n " +
                $"E-mail: {eMail.Text}\n " +
                $"Phone: {ePhone.Text}\n " +
                $"Grade: {eGrade.Text} ");

            this.DisplayAlert("Student Info", strInfo, "Close");
        }
    }
}