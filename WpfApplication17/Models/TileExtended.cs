using System.Windows.Input;

namespace AdvanceTileLayout.Models
{
    public class TileExtended
    {
        public string Header { get; set; }

        public ICommand Command { get; set; }

        public string GroupHeader { get; set; }

        public bool IsFlowBreak { get; set; }
    }
}