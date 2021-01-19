using System.Windows.Input;

namespace Calculator.Wpf.ViewModels
{
    public interface IMainWindowViewModel
    {
        ICommand ClearButtonCommand { get; }
        ICommand DigitalButtonCommand { get; }
        string ResultPanel { get; }
    }
}