using Avalonia.Controls;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTests
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
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
        public async void Test2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
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
        public async void Test3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonMul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonMul");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
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
        public async void Test4()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonL = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonL");
            var buttonDiv = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonDiv");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
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
        public async void Test5()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonL = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonL");
            var buttonC = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonC");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonL.Command.Execute(buttonL.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "LVI", "result != LVI");
        }

        [Fact]
        public async void Test6()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonDiv = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonDiv");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonDiv.Command.Execute(buttonDiv.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);

            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }

        [Fact]
        public async void Test7()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonMul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonMul");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonMul.Command.Execute(buttonMul.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);

            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }

        [Fact]
        public async void Test8()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);

            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }

        [Fact]
        public async void Test9()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);

            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }

        [Fact]
        public async void Test10()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "CMLXXX", "result != CMLXXX");
        }

        [Fact]
        public async void Test11()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "X", "result != X");
        }

        [Fact]
        public async void Test12()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);

            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "result != #ERROR");
        }

        [Fact]
        public async void Test13()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");

            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonCE.Command.Execute(buttonCE.CommandParameter);

            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            Assert.True(text == "", "result != '");
        }

        [Fact]
        public async void Test14()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(t => t.Name == "textResult");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");

            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "VI", "result != VI");
        }
    }
}