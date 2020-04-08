using DZ3_AddToCard.Framework;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DZ3_AddToCard.Tests
{
    public abstract class BaseTest
    {
        protected readonly IWebDriver Driver;
       
        protected BaseTest()
        {
            Driver = Selenium.GetDriver(Settings.Driver);
            Driver.Navigate().GoToUrl(Settings.Url);
        }
        static void Main ()
        {
            
        }
        
        [OneTimeTearDown]
        public void OneTimeTearDown() => Driver.Quit();
    }
}