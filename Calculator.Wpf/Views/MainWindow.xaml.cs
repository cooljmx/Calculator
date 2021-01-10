using Calculator.Wpf.ViewModels;

namespace Calculator.Wpf.Views
{
    public partial class MainWindow
    {
        public MainWindow(IMainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();

            DataContext = mainWindowViewModel;
        }
    }
}