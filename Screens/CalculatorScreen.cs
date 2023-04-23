using OpenQA.Selenium.Appium.Windows;

namespace AppiumCalculatorTestsPOM.Screens
{
    public class CalculatorScreen
    {
        private WindowsDriver<WindowsElement> driver;
        public CalculatorScreen(WindowsDriver<WindowsElement> driver) 
        {
            this.driver = driver;
        }

        public WindowsElement FirstField => driver.FindElementByAccessibilityId("textBoxFirstNum");
        public WindowsElement SecondField => driver.FindElementByAccessibilityId("textBoxSecondNum");
        public WindowsElement ResultField => driver.FindElementByAccessibilityId("textBoxSum");
        public WindowsElement CalcButton => driver.FindElementByAccessibilityId("buttonCalc");

        public string CalculateTwoNumbers(string firstValue, string secondValue) 
        {
            FirstField.Clear();
            SecondField.Clear();
            FirstField.SendKeys(firstValue);
            SecondField.SendKeys(secondValue); 
            CalcButton.Click();

            return ResultField.Text;
        }

    }
}
