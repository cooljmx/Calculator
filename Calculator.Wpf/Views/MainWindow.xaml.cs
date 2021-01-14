using System;
using Calculator.Wpf.ViewModels;

namespace Calculator.Wpf.Views
{
    public partial class MainWindow
    {
        public MainWindow(MainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();

            DataContext = mainWindowViewModel;
        }
    }
}