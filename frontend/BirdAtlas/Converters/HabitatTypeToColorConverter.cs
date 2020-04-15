using System;
using System.Globalization;
using BirdAtlas.Models;
using Xamarin.Forms;

namespace BirdAtlas.Converters
{
    public class HabitatTypeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is HabitatType habitatType)
            {
                switch(habitatType)
                {
                    case HabitatType.Tundra:
                    case HabitatType.Grassland:
                        return (Color)Application.Current.Resources["WarmBlue"];
                    case HabitatType.Forest:
                    case HabitatType.Wetland:
                    case HabitatType.UrbanSuburban:
                        return (Color)Application.Current.Resources["LightBlue"];
                    case HabitatType.Desert:
                    case HabitatType.Ocean:
                        return (Color)Application.Current.Resources["DarkBlue"];
                }
            }

            return Color.Default;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}