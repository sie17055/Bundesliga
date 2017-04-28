using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Fussball_DB
{
    class Conv : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (System.Convert.ToDouble(value) == 0)
            {
                return "1.PNG";
            }
            else if (System.Convert.ToDouble(value) == 1)
            {
                return "2.PNG";
            }
            else if (System.Convert.ToDouble(value) == 2)
            {
                return "3.PNG";
            }
            else return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
