using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
                default: 
                    return "Inconnu";
                    break;
            }

            return "invalid";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string texte = value as string;

            switch (texte)
            {
                case "Processeur":
                    return 1;
                case "Carte mère":
                    return 2;
                case "Ram":
                    return 3;
                case "Refroidissement":
                    return 4;
                case "Stockage":
                    return 5;
                case "Système d'exploitation":
                    return 6;
                case "Boitier":
                    return 7;
                case "Carte graphique":
                    return 8;
                case "Alimentation":
                    return 9;
                default:
                    return DependencyProperty.UnsetValue;
            }
        }
    }
}

