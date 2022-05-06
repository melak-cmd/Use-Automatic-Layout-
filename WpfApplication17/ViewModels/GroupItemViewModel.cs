using System.Collections.ObjectModel;

namespace AdvanceTileLayout.ViewModels
{
    public class GroupItemViewModel
    {
        public string Header { get; set; }

        public ObservableCollection<TileItemViewModel> Tiles { get; set; }
    }
}