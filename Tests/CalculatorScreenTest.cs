using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using AppiumCalculatorTestsPOM.Screens;

namespace AppiumCalculatorTestsPOM.Tests
{
    public class CalculatorScreenTest : BaseTest
    {
        private CalculatorScreen screen;

        [SetUp]
        public void Setup() 
        { 
            this.screen = new CalculatorScreen(driver);
        }
        
        [Test]
        public void Test_Calculate_TwoPositiveNumbers()
        {
            var result = screen.CalculateTwoNumbers("5", "10");
            Assert.That(result, Is.EqualTo("15"));
        }
    }
}