using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Globalization;

namespace A080916
{
    public class DTConverter : IValueConverter 
    {
        public object Convert(object value, Type targettype, object parameter, CultureInfo culture)
        {
            DateTime DT_out = DateTime.Now;
            return DT_out.DayOfWeek.ToString();

        }
        public object ConvertBack(object value, Type targettype, object parameter, CultureInfo culture)
        {

            return DateTime.Now.DayOfYear;
        }
      }
}
