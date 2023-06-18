using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DemoStoreSpecflowProject.PageObjects.Locators
{
    public  class BasePageLocators
    {
        public By homeNavigationButton = By.XPath("//li/a[contains(text(),\"Home\")][1]");
        public By cartNavigationButton = By.XPath("//nav[@id=\"site-navigation\"]/div/ul/li/a[contains(text(),\"Cart\")]");
        public By checkoutNavigationButton = By.XPath("//li/a[contains(text(),\"Checkout\")]");
        public By myAccountNavigationButton = By.XPath("//li/a[contains(text(),\"My account\")]");
    }
}
