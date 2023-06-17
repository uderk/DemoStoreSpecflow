using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoStoreSpecflowProject.PageObjects.Locators;
using DemoStoreSpecflowProject.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoStoreSpecflowProject.PageObjects
{
    public class MyAccountPage
    {
        private IWebDriver driver;
        private MyAccountPageLocators MyAccountPageLocators;
        private SeleniumExtended SelExtended;

        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            SelExtended = new SeleniumExtended(driver, 10);
            MyAccountPageLocators = new MyAccountPageLocators();
        }

        public void VerifyMyAccountMessageDisplayed(By locator, int timeout=10)
        {
            SelExtended.waitUntilElementIsDisplayed(MyAccountPageLocators.myAccountMessageLocator, 10);
        }

        //public void VerifyIfErrorMessageIsDisplayed(By locator)
        //{
        //    SelExtended.waitUntilElementIsDisplayed(locator);
        //}
    }
}
