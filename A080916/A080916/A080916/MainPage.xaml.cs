using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace A080916
{
    public partial class MainPage : ContentPage
    {
        private DateTime inputDate = DateTime.Now;
        private DTConverter converter1 = new DTConverter();

        //private

        public DateTime InputDate
        {
            get
            {
                return inputDate;
            }
            set
            {
                inputDate = value;
            }
           
        }


        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            label_IO.SetBinding(Label.TextProperty, "InputDate", BindingMode.OneWay, converter1); 
        }
    }
}
