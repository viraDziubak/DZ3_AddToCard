using System;
using System.Linq;
using DZ3_AddToCard.Framework;
using OpenQA.Selenium;

namespace DZ3_AddToCard.PageObject
{
    public class Header : PageObjectBase
    {
        private static readonly By addCastom = By.ClassName("button ajax_add_to_cart_button btn btn-default");
        private static readonly By checkCart = By.ClassName("icon-ok");

        public Header(IWebDriver driver) : base(driver)
        {
            
        }

        public Header addingToCart()
        {
            Driver.FindElement(addCastom).Click();
            return this;
        }

        public bool isAddingOk()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk = Wait.WaitFor(() => Driver.FindElements(checkCart).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
            return isOk;
        }
    }
}