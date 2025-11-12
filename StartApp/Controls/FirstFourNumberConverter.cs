using System.Globalization;

namespace StartApp.Controls
{
    public class FirstFourNumberConverter : IValueConverter
    {
        public object? Convert(object? value, Type? targetType, object? parameter, CultureInfo culture)
        {
            string? phoneNumber = value as string;
            return phoneNumber?.Substring(0, Math.Min(4, phoneNumber.Length));
        }

        public object? ConvertBack(object? value, Type? targetType, object? parameter, CultureInfo? culture)
        {
            throw new NotImplementedException();
        }
    }
}
