using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace FrameworkTryouts.Tabs
{
    public class TabSizeConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter,
            CultureInfo culture)
        {
            var tabControl = values[0] as TabControl;
            var width = tabControl.ActualWidth / tabControl.Items.Count;
            //Subtract 1, otherwise we could overflow to two rows.
            return width <= 1 ? 0 : width - 1;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter,
            CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}