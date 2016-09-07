using System;
using Xamarin.Forms;

namespace a06_09_2016
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = new StackLayout
            {
                Children = {
        new Label {
          Text = "Hello, Custom Renderer !"
        },
        new MyEntry {
          Text = "In Shared Code"
        }
      },
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
        }
    }
}
