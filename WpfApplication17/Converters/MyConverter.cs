using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
using AdvanceTileLayout.Models;
using AdvanceTileLayout.ViewModels;

namespace AdvanceTileLayout.Converters
{
    public class MyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var flatCollection = new ObservableCollection<TileExtended>();
            var groups = value as ObservableCollection<GroupItemViewModel>;
            if (groups == null) return flatCollection;
            foreach (GroupItemViewModel group in groups)
            {
                bool first = true;
                foreach (TileItemViewModel tile in @group.Tiles)
                {
                    if (first)
                        flatCollection.Add(new TileExtended
                        {
                            Header = tile.Header,
                            Command = tile.Command,
                            GroupHeader = @group.Header,
                            IsFlowBreak = true
                        });
                    else
                        flatCollection.Add(new TileExtended {Header = tile.Header, Command = tile.Command,});
                    first = false;
                }
            }
            return flatCollection;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}