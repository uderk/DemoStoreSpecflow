using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DemoStoreSpecflowProject.PageObjects.Locators
{
    public class MyAccountPageLocators
    {
        public By myAccountMessageLocator = By.XPath("//h1[contains(text(),\"My account\")]");
        public By myAccountErrorMessageInvalidUser = By.XPath("//ul[@class=\"woocommerce-error\" and @role=\"alert\"]");
        public By dashboardLocator = By.XPath("//a[contains(text(),\"Dashboard\")]");
    }
}
