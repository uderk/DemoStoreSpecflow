using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace DemoStoreSpecflowProject.PageObjects.Locators
{
    public  class LoginPageLocators
    {
        public  By userNameLoginLocator = By.Id("username");
        public  By passwordLoginLocator = By.Id("password");
        public  By logInButtonLocator = By.Name("login");


    }
}
