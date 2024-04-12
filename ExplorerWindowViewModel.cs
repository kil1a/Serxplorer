using System.Collections.ObjectModel;

namespace Serxplorer.ViewModels
{
    public class ExplorerWindowViewModel : BaseViewModel
    {
        private ObservableCollection<DirInfo> _rootItems;

        public ObservableCollection<DirInfo> RootItems
        {
            get => _rootItems;
            set
            {
                _rootItems = value;
                OnPropertyChanged();
            }
        }

        public ExplorerWindowViewModel()
        {
            // Загрузка корневых элементов директорий
            LoadRootItems();
        }

        private void LoadRootItems()
        {
            // Пример загрузки корневых элементов, замените это вашей логикой
            RootItems = new ObservableCollection<DirInfo>
            {
                new DirInfo("Root", @"C:\", "icon.png"),
                new DirInfo("AnotherRoot", @"D:\", "icon.png")
            };
        }
    }
}
