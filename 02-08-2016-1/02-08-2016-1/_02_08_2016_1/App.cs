using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace _02_08_2016_1
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application

            //MainPage = new Page1();
            // MainPage = new Page2();
            MainPage = new Page3();
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
