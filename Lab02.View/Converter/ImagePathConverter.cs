using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using Lab02.Model;

namespace Lab02.View.Converter
{
    [ValueConversion(typeof(HotelType), typeof(BitmapImage))]
    class ImagePathConverter : IValueConverter
    {
        Dictionary<HotelType, BitmapImage> cache = new Dictionary<HotelType, BitmapImage>();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            HotelType type = (HotelType)value;
            if (cache.ContainsKey(type))
            {
                Uri uri = new Uri(string.Format(@"../Images/HotelType/Type_{0}.png", type), UriKind.Relative);
                cache.Add(type, new BitmapImage(uri));
            }
            return cache[type];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
