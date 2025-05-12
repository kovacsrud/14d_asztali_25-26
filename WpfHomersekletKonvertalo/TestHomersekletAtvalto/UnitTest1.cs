using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace TestHomersekletAtvalto
{
    public class Tests
    {
        protected const string WinAppDriverUrl = "http://127.0.0.1:4723/";
        private const string WPFProgramId = @"D:\rud-2\kodtarak_2024\13d_asztali_24-25\WpfHomersekletKonvertalo\WpfHomersekletKonvertalo\bin\Debug\net8.0-windows\WpfHomersekletKonvertalo.exe";

        protected static WindowsDriver<WindowsElement> driver;

        [OneTimeSetUp]
        public void Setup()
        {
            if (driver == null)
            {
                var appiumOptions= new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", WPFProgramId);
                appiumOptions.AddAdditionalCapability("devicename", "WindowsPC");
                driver = new WindowsDriver<WindowsElement>(new Uri(WinAppDriverUrl),appiumOptions);
            }   
        }

        [Test]
        [TestCase(27.77777777,82)]
        [TestCase(31,87.8)]
        public void CelsiusToFahrenheitTest(double celsius,double elvart)
        {
            var homerseklet = driver.FindElementByAccessibilityId("textboxHomersekletErtek");
            homerseklet.Clear();
            driver.FindElementByAccessibilityId("radioFahrenheitKivalaszt").Click();
            homerseklet.SendKeys(celsius.ToString());
            driver.FindElementByAccessibilityId("buttonKonvertalas").Click();
            var eredmeny=driver.FindElementByAccessibilityId("textblockEredmeny");

            Assert.AreEqual(elvart, Convert.ToDouble(eredmeny.Text),0.0005);
        }

        //Tesztmetódusok ide

        [OneTimeTearDown]
        public void Endtest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}