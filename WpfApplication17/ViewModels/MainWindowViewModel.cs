using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AdvanceTileLayout.ViewModels
{
    public class MainWindowViewModel
    {
        private ObservableCollection<GroupItemViewModel> _groups;

        public MainWindowViewModel()
        {
            _groups = new ObservableCollection<GroupItemViewModel>();

            var group1 = new GroupItemViewModel();
            var group2 = new GroupItemViewModel();

            group1.Header = "Group1";
            group2.Header = "Group2";

            group1.Tiles = new ObservableCollection<TileItemViewModel>
            {
                new TileItemViewModel {Header = "Copy", Command = ApplicationCommands.Copy},
                new TileItemViewModel {Header = "Paste", Command = ApplicationCommands.Paste}
            };

            group2.Tiles = new ObservableCollection<TileItemViewModel>
            {
                new TileItemViewModel {Header = "Copy", Command = ApplicationCommands.Copy},
                new TileItemViewModel {Header = "Paste", Command = ApplicationCommands.Paste}
            };

            _groups.Add(group1);
            _groups.Add(group2);
        }

        public ObservableCollection<GroupItemViewModel> Groups
        {
            get { return _groups; }
            set { _groups = value; }
        }
    }
}