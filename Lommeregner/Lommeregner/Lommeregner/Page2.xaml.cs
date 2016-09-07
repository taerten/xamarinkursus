using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Lommeregner
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        public async void GotoPage1(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Page1());
        }

    }
}
