using System;
using System.Windows;

namespace Serxplorer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Здесь вы можете выполнить любые инициализации приложения
            // например, настройку локализации, создание экземпляров моделей представлений и т.д.

            MainWindow mainWindow = new MainWindow(); // Создание экземпляра главного окна
            mainWindow.Show(); // Показать главное окно

            // Метод Run вызывается на текущем объекте Application для запуска приложения
            this.Run();
        }
    }
}
