using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BasicUI
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            pushButton.Clicked += PushButton_Clicked;

        }
        private void PushButton_Clicked(object sender, EventArgs e)
        {
            yellowlabel.Text = "Styrer";
        }
        private void PushButton_Clicked2(object sender, EventArgs e)
        {
            yellowlabel.Text = "STYRER";
        }
    }
}
