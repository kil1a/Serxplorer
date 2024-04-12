using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Serxplorer.ViewModels
{
    public class FileExplorerViewModel : BaseViewModel
    {
        private string _currentPath;
        private ObservableCollection<DirInfo> _currentItems;

        public string CurrentPath
        {
            get => _currentPath;
            set
            {
                _currentPath = value;
                OnPropertyChanged();
                LoadCurrentItems();
            }
        }

        public ObservableCollection<DirInfo> CurrentItems
        {
            get => _currentItems;
            set
            {
                _currentItems = value;
                OnPropertyChanged();
            }
        }

        public ICommand NavigateCommand { get; set; }

        public FileExplorerViewModel()
        {
            NavigateCommand = new RelayCommand(Navigate);
            CurrentPath = @"C:\";
        }

        private void LoadCurrentItems()
        {
            // Логика загрузки содержимого текущей директории
            // Вам нужно реализовать этот метод по вашим требованиям
        }

        private void Navigate()
        {
            // Логика навигации по директориям
            // Вам также нужно реализовать этот метод
        }
    }
}
