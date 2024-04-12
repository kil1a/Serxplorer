using System.Windows;

namespace Serxplorer.WPF.Ui
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var MainWindow = new MainWindow();

            MainWindow.Show();
        }
    }
}
