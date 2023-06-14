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
    }
}
