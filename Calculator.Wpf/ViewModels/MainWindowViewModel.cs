using System.Windows.Input;

namespace Calculator.Wpf.ViewModels
{
    public class MainWindowViewModel : BaseViewModel, IMainWindowViewModel
    {
        private string _resultPanel;

        public MainWindowViewModel()
        {
            ResultPanel = "0";

            DigitalButtonCommand = new RelayCommand(DigitalButtonCommandExecute);
            ClearButtonCommand = new RelayCommand(ClearButtonCommandExecute);
        }

        public ICommand ClearButtonCommand { get; }
        public ICommand DigitalButtonCommand { get; }

        public string ResultPanel
        {
            get => _resultPanel;
            private set
            {
                _resultPanel = value;

                RaisePropertyChanged();
            }
        }

        private void ClearButtonCommandExecute(object parameter)
        {
            ResultPanel = "0";
        }

        private void DigitalButtonCommandExecute(object parameter)
        {
            if (ResultPanel == "0")
                ResultPanel = parameter.ToString();
            else
                ResultPanel += parameter;
        }
    }
}