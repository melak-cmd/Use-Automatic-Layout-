using System.Windows.Input;

namespace AdvanceTileLayout.ViewModels
{
    public class TileItemViewModel
    {
        public string Header { get; set; }
        public ICommand Command { get; set; }
    }
}