using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace _29_08_2016
{
    public class MyPage : ContentPage
    {
        public MyPage()
        {
            var red = new Label
            {
                Text = "red label",
                BackgroundColor = Color.Red,
                FontSize = 20
            };
            var yellow = new Label();
            yellow.Text = "Yellow";
            yellow.BackgroundColor = Color.Yellow;
            yellow.FontSize = 20;
            yellow.TextColor = Color.Black;
            // yellow.VerticalOptions = LayoutOptions.CenterAndExpand;

            var green = new Label();
            yellow.Text = "YGRØN";
            yellow.BackgroundColor = Color.Aqua;
            yellow.FontSize = 30;
            yellow.TextColor = Color.Black;


            Content = new StackLayout
            {
                Children = {
                   red, yellow
                }
            };
        }
    }
}
