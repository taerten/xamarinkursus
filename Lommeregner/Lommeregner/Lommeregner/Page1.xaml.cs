using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Lommeregner
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            knap1.Clicked+= click1;
        }

        private void click1(Object sender, EventArgs e)
        {
            outputlabel.Text = "1";
        }
    }
}
