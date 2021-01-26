using System.Windows;
using Calculator.Wpf.ViewModels;
using Calculator.Wpf.Views;

namespace Calculator.Wpf
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindowViewModel = new MainWindowViewModel();

            MainWindow = new MainWindow(mainWindowViewModel);

            MainWindow.Show();
        }
    }
}