namespace ComboBoxBox
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Data;
    public class SelectedItemsToStringConverter : IValueConverter
    {
        public static SelectedItemsToStringConverter Default { get; } = new SelectedItemsToStringConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var items = (IReadOnlyList<TypeItem>)value;
            return string.Join(" ", items.Where(x => x.IsSelecteded).Select(x => x.Text));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
