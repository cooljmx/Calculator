using Calculator.Wpf.ViewModels;
using NUnit.Framework;

namespace Calculator.Wpf.Tests
{
    [TestFixture]
    public class MainWindowViewModelTests
    {
        [Test]
        public void ReturnsZeroFromResultPanelWhenCreated()
        {
            var viewModel = new MainWindowViewModel();

            Assert.That(viewModel.ResultPanel, Is.EqualTo("0"));
        }

        [Test]
        public void ReturnsThreeFromResultPanelWhenDigitalButtonCommandExecutedWithThree()
        {
            var viewModel = new MainWindowViewModel();

            viewModel.DigitalButtonCommand.Execute("3");

            Assert.That(viewModel.ResultPanel, Is.EqualTo("3"));
        }

        [Test]
        public void ReturnsSevenFromResultPanelWhenDigitalButtonCommandExecutedWithSeven()
        {
            var viewModel = new MainWindowViewModel();

            viewModel.DigitalButtonCommand.Execute("7");

            Assert.That(viewModel.ResultPanel, Is.EqualTo("7"));
        }

        [Test]
        public void ReturnsZeroFromResultPanelWhenClearButtonCommandExecuted()
        {
            var viewModel = new MainWindowViewModel();
            viewModel.DigitalButtonCommand.Execute("4");

            viewModel.ClearButtonCommand.Execute(null);

            Assert.That(viewModel.ResultPanel, Is.EqualTo("0"));
        }

        [Test]
        public void ReturnsAggregatedNumberFromResultPanelWhenDigitalButtonCommandExecutedManyTimes()
        {
            var viewModel = new MainWindowViewModel();

            viewModel.DigitalButtonCommand.Execute("5");
            viewModel.DigitalButtonCommand.Execute("2");

            Assert.That(viewModel.ResultPanel, Is.EqualTo("52"));
        }

        [Test]
        public void ReturnsAggregatedZeroWithDelimiterFromResultPanelWhenDigitalButtonCommandExecutedWithDelimiter()
        {
            var viewModel = new MainWindowViewModel();

            viewModel.DigitalButtonCommand.Execute(",");

            Assert.That(viewModel.ResultPanel, Is.EqualTo("0,"));
        }
    }
}