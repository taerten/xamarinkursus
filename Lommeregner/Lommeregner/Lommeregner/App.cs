using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lommeregner
{
    public class App : Application
    {
        public App()
        {
            /*
            var nav = new NavigationPage();
            var page1 = new Page1();
            nav.PushAsync(page1);
            MainPage = nav;
            */

            /*
            var nav = new NavigationPage();
            var page2 = new Page2();
            nav.PushAsync(page2);
            MainPage = nav;
            */
            
            var nav = new NavigationPage();
            var page3 = new Page3();
            nav.PushAsync(page3);
            MainPage = nav;
            
        }
        /*
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        */
    }
}
