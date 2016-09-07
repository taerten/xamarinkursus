using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CustomComponent
{
    public partial class MyView : StackLayout
    {
        public MyView()
        {
            InitializeComponent();
            firstName.Text = "Anders";
            lastName.Text = "And";
        }
    }
}
