using System.Windows.Input;

namespace Calculator.Wpf.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _resultPanel;

        public MainWindowViewModel()
        {
            ResultPanel = "0";

            Button0Command = new RelayCommand(() => DigitButtonExecute('0'));
            Button1Command = new RelayCommand(() => DigitButtonExecute('1'));
            Button2Command = new RelayCommand(() => DigitButtonExecute('2'));
            Button3Command = new RelayCommand(() => DigitButtonExecute('3'));
            Button4Command = new RelayCommand(() => DigitButtonExecute('4'));
            Button5Command = new RelayCommand(() => DigitButtonExecute('5'));
            Button6Command = new RelayCommand(() => DigitButtonExecute('6'));
            Button7Command = new RelayCommand(() => DigitButtonExecute('7'));
            Button8Command = new RelayCommand(() => DigitButtonExecute('8'));
            Button9Command = new RelayCommand(() => DigitButtonExecute('9'));
            ClearButtonCommand = new RelayCommand(ClearResultPanel);
        }

        public ICommand Button0Command { get; }
        public ICommand Button1Command { get; }
        public ICommand Button2Command { get; }
        public ICommand Button3Command { get; }
        public ICommand Button4Command { get; }
        public ICommand Button5Command { get; }
        public ICommand Button6Command { get; }
        public ICommand Button7Command { get; }
        public ICommand Button8Command { get; }
        public ICommand Button9Command { get; }
        public ICommand ClearButtonCommand { get; }

        public string ResultPanel
        {
            get => _resultPanel;
            private set
            {
                _resultPanel = value;

                RaisePropertyChanged();
            }
        }

        private void ClearResultPanel()
        {
            ResultPanel = "0";
        }

        private void DigitButtonExecute(char digit)
        {
            if (ResultPanel == "0")
                ResultPanel = $"{digit}";
            else
                ResultPanel += digit;
        }
    }
}