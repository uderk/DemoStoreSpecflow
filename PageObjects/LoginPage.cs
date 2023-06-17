using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using DemoStoreSpecflowProject.PageObjects.Locators;
using DemoStoreSpecflowProject.Support;
using System.Security.Policy;

namespace DemoStoreSpecflowProject.PageObjects
{
    public  class LoginPage
    {
        private IWebDriver driver;
        private LoginPageLocators LoginPageLoc;
        private SeleniumExtended SelExtended;
        public string username = "venislav.zdravkov@gmail.com";
        public string password = "!77842590!";
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            SelExtended = new SeleniumExtended(driver, 10);
            LoginPageLoc = new LoginPageLocators();
        }

        private string loginPageUrl = "http://mydemostore.local/my-account/";
       

        public void GoToLoginPage()
        {
            driver.Navigate().GoToUrl(this.loginPageUrl);
        }
        public void InputUsername(By locator, string username, int timeout=10)
        {
            SelExtended.InputText(locator,username,timeout );
        }

        public void InputPassword(By locator, string password, int timeout=10)
        {
            SelExtended.InputText(locator, password, timeout);
        }

        public void clickLoginButton(By locator, int timeout)
        {
            SelExtended.clickButton(locator, timeout);
        }
    }
}
