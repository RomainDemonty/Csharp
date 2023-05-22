using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Vue
{
    public class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case 1:
                    return "Processeur";
                    break;
                case 2:
                    return "Carte mère";
                    break;
                case 3:
                    return "Ram";
                    break;
                case 4:
                    return "Refroidissement";
                    break;
                case 5:
                    return "Stockage";
                    break;
                case 6:
                    return "Système d'exploitation";
                    break;
                case 7:
                    return "Boitier";
                    break;
                case 8:
                    return "Carte graphique";
                    break;
                case 9:
                    return "Alimentation";
                    break;
            }

            return "invalid";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

