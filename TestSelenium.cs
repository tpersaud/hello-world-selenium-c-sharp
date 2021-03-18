using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace hello_world
{
    public class TestSelenium
    {
        string test_url = "http://www.google.com";

        IWebDriver driver;

        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Search()
        {
            System.Threading.Thread.Sleep(2000);

            IWebElement searchText = driver.FindElement(By.Name("q")); 
            searchText.SendKeys("LambdaTest");
            searchText.Submit();

            System.Threading.Thread.Sleep(6000);
            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }
    }
}