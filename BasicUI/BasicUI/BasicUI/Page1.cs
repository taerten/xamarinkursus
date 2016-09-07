using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace BasicUI
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            var red = new Label();
            red.Text = "Red";
            red.BackgroundColor = Color.Red;
            red.TextColor = Color.Black;
            red.FontSize = 20;

            var yellow = new Label();
            yellow.Text = "Yellow";
            yellow.BackgroundColor = Color.Yellow;
            yellow.TextColor = Color.Pink;
            yellow.FontSize = 30;

            var green = new Label();
            green.Text = "Green";
            green.BackgroundColor = Color.Green;
            green.TextColor = Color.Olive;
            green.FontSize = 40;

            var listview = new ListView();

            listview.ItemsSource = new string[]
                {
                    "Liste1 1","Liste 2"
                                    };




            Content = new StackLayout
            {
                Children = { red, yellow, green, listview }
            };
        }
    }
}
