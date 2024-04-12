using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Serxplorer.Shared.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _mainDiskName;
        public string MainDiskName
        {
            get => _mainDiskName;
            set
            {
                _mainDiskName = value;

                OnPropertyChanged(nameof(MainDiskName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            MainDiskName = Environment.SystemDirectory;
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
