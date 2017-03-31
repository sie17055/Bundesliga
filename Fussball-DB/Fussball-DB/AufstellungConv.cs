using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Fussball_DB
{
    class AufstellungConv : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int i = (int)value;
            switch (i)
            {
                case 1:
                    return "4-3-3_quer.jpg";
                case 2:
                    return "christmas-tree_quer.jpg";
                case 3:
                    return "4-4-2diamond_quer.jpg";
                default:
                    return "4-4-2_quer.jpg";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
