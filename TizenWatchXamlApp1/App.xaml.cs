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
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new TizenWatchXamlApp1.MainPage(); // Blank basic.

            /* Layout test */
            //MainPage = new TizenWatchXamlApp1.ScrollViewVertical();
            //MainPage = new TizenWatchXamlApp1.ScrollViewHori();
            //MainPage = new TizenWatchXamlApp1.MyContentPage1(); //
            //MainPage = new TizenWatchXamlApp1.FrameEx();
            //MainPage = new TizenWatchXamlApp1.AbsoluteLayout1();//
            //MainPage = new TizenWatchXamlApp1.AbsoluteLayoutEx(); //Supported on w/ C# code!

#if UNSUPP
            //MainPage = new TizenWatchXamlApp1.RelativeEx(); //RelativeLayout
#endif
            //MainPage = new TizenWatchXamlApp1.FlexEx(); //FlexLayout Ex. 
            //MainPage = new TizenWatchXamlApp1.GridEx(); 
            //MainPage = new TizenWatchXamlApp1.TableViewEx();

            /* UI Component test */
            //MainPage = new TizenWatchXamlApp1.ButtonEx();
            //MainPage = new TizenWatchXamlApp1.EntryEx();
            //MainPage = new TizenWatchXamlApp1.EditorEx();
            //MainPage = new TizenWatchXamlApp1.ImageEx(); // dosen't support when using FromUri.
            //MainPage = new TizenWatchXamlApp1.SliderEx(); // dosen't support when minimum, maximum value.
            //MainPage = new TizenWatchXamlApp1.CheckBoxEx(); // caption
            //MainPage = new TizenWatchXamlApp1.SwtichEx();
            //MainPage = new TizenWatchXamlApp1.PopupEx();
            //MainPage = new TizenWatchXamlApp1.PromptEx();
            //MainPage = new TizenWatchXamlApp1.DatePicker(); // Not supported or should bugfixed.
#if UNSUPP
            //MainPage = new TizenWatchXamlApp1.TimePicker(); // Not supported.
#endif

            /* Page navigation test*/
            //MainPage = new NavigationPage(new TizenWatchXamlApp1.FirstPage()); //<== Page Navi on Xaml. Not supported.
            //MainPage = new TizenWatchXamlApp1.FirstPage(); ////<== Page Navi on CS. Not supported.


            /*
             * 
             * You should copy and paste the "ScrollViewVertical()"  below 
             * such as this form with below methods:
             * 
             * "ScrollViewVertical()"
             * "ScrollViewHori()"
             * "MyContentPage1()"
             * "FrameEx()"
             * 
             */
            MainPage = new TizenWatchXamlApp1.ScrollViewVertical();

#if DEBUG
            TizenHotReloader.HotReloader.Open(this);
#endif
        }

        protected override void OnStart()
        {
            // Handle when your app starts
#if DEBUG
            Debug.WriteLine("Debug ---> OnStart ");
#endif
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
#if DEBUG
            Debug.WriteLine("Debug ---> OnSleep ");
#endif
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
#if DEBUG
            Debug.WriteLine("Debug ---> OnResume ");
#endif
        }
    }
}

