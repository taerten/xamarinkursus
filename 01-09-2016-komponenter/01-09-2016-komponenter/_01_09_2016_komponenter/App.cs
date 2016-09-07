using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace _01_09_2016_komponenter
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            //MainPage = new Page1();
            MainPage = new Page2();
        }

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
    }
}
