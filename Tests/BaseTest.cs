using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using AppiumCalculatorTestsPOM.Screens;
using NUnit.Framework;

namespace AppiumCalculatorTestsPOM.Tests
{
    public class BaseTest
    {
        private const string appiumServer = "http://[::1]:4723/wd/hub";
        private const string appLocation = @"D:\ina_rd\QA\QA Authomation FrontEnd\00. Projects\04.Appium-Desktop-Testing-Resources\SummatorDesktopApp.exe";
        protected WindowsDriver<WindowsElement> driver;
        private AppiumOptions appiumOptions;

        [SetUp]
        public void Setup()
        {
            this.appiumOptions = new AppiumOptions() { PlatformName = "Windows" };
            appiumOptions.AddAdditionalCapability("app", appLocation);
            //appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, appLocation);
            appiumOptions.AddAdditionalCapability("PlatformName", "Windows");
            this.driver = new WindowsDriver<WindowsElement>(new Uri(appiumServer), appiumOptions);
        }

        [TearDown]
        public void CloseApp()
        {
            driver.Quit();
        }
    }

}
