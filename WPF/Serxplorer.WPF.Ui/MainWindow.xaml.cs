using Serxplorer.Shared.ViewModels;

namespace Serxplorer.WPF.Ui
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
