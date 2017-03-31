using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Fussball_DB
{
    class SpielfeldConv : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int i = (int)value;
            switch (i)
            {
                case 1:
                    return "4-3-3.jpg";
                case 2:
                    return "christmas-tree.jpg";
                case 3:
                    return "4-4-2diamond.jpg";
                default:
                    return "4-4-2.jpg";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
