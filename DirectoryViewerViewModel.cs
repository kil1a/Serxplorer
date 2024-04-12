using System;
using System.Collections.ObjectModel;

namespace Serxplorer.ViewModels
{
    public class DirectoryViewerViewModel : BaseViewModel
    {
        private ObservableCollection<string> _directories;
        private ObservableCollection<string> _files;

        public ObservableCollection<string> Directories
        {
            get => _directories;
            set
            {
                _directories = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> Files
        {
            get => _files;
            set
            {
                _files = value;
                OnPropertyChanged();
            }
        }

        public DirectoryViewerViewModel()
        {
            // Примерный код для загрузки директорий и файлов
            LoadDirectoriesAndFiles(@"C:\ExamplePath");
        }

        private void LoadDirectoriesAndFiles(string path)
        {
            try
            {
                FileSystemExplorerService service = new FileSystemExplorerService();
                Directories = new ObservableCollection<string>(service.GetDirectories(path));
                Files = new ObservableCollection<string>(service.GetFiles(path));
            }
            catch (Exception ex)
            {
                // Обработка исключений по вашему усмотрению
                throw;
            }
        }
    }
}
