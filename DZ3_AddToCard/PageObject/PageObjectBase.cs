using OpenQA.Selenium;

namespace DZ3_AddToCard.PageObject
{
    public abstract class PageObjectBase
    {
        protected readonly IWebDriver Driver;
        public PageObjectBase(IWebDriver driver) => Driver = driver;
    }
}