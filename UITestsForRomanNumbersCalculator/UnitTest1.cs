using Avalonia.Controls;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTests
    {

        [Fact]
        public async void TestNamderKey()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");

            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonC = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonC");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonD = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonD");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonL = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonL");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonD.Command.Execute(buttonD.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonL.Command.Execute(buttonL.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "ICVDXML", "result != ICVDXML");
        }

        [Fact]
        public async void TestDiv()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonL = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonL");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonDiv = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonDiv");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonL.Command.Execute(buttonL.CommandParameter);
            buttonDiv.Command.Execute(buttonDiv.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "X", "result != X");
        }

        [Fact]
        public async void TestSub()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "IV", "result != IV");
        }

        [Fact]
        public async void TestMul()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonMul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonMul");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonMul.Command.Execute(buttonMul.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "L", "result != L");
        }

        [Fact]
        public async void TestPlus()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "VI", "result != VI");
        }

        [Fact]
        public async void TestManyOperations()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonC = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonC");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonSub.Command.Execute(buttonPlus.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonSub.Command.Execute(buttonPlus.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);

            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "CLXXXIX", "result != CLXXXIX");
        }
    }
}