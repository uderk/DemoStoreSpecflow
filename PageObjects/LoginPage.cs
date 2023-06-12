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

        public LoginPage()
        {
           // driver = new ChromeDriver();
            SelExtended = new SeleniumExtended(driver, 10);
            LoginPageLoc = new LoginPageLocators();
            this.driver = new ChromeDriver();
        }

        private string loginPageUrl = "http://mydemostore.local/my-account/";
       

        public void GoToLoginPage()
        {
            driver.Navigate().GoToUrl(this.loginPageUrl);
        }
        // By myLocator = LoginPageLocators.userNameLoginLocator;
        public void inputUsername(By locator, string username, int timeout)
        {
            SelExtended.InputText(locator,username,timeout );
        }

        public void inputPassword(By locator, string password, int timeout)
        {
            SelExtended.InputText(locator, password, 10);
        }

        public void clickLoginButton(By locator, int timeout)
        {
            SelExtended.clickButton(locator,timeout);
        }
    }
}
