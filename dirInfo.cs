using System.Collections.ObjectModel;

namespace Serxplorer.ViewModels
{
    public class DirInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public ObservableCollection<DirInfo> SubItems { get; set; }
        public string Icon { get; set; }

        public DirInfo(string name, string path, string icon)
        {
            Name = name;
            Path = path;
            SubItems = new ObservableCollection<DirInfo>();
            Icon = icon;
        }
    }
}
