using DemoStoreSpecflowProject.PageObjects;
using DemoStoreSpecflowProject.PageObjects.Locators;
using DemoStoreSpecflowProject.Support;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace DemoStoreSpecflowProject.StepDefinitions
{
    [Binding]
    public class RegisterValidUserStepDefinitions
    {
        private IWebDriver driver;
        private LoginPage LoginPage;
        private LoginPageLocators LoginPageLoc;
        private SeleniumExtended SelExtended;
        private MyAccountPage MyAccountPage;
        private MyAccountPageLocators MyAccountPageLocators;

        public RegisterValidUserStepDefinitions()
        {
            driver = WebDriverManager.GetDriver();
            LoginPage = new LoginPage(driver);
            LoginPageLoc = new LoginPageLocators();
            MyAccountPage = new MyAccountPage(driver);
            MyAccountPageLocators = new MyAccountPageLocators();
        }


        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            LoginPage.GoToLoginPage();
        }

        [When(@"I type ""([^""]*)""")]
        public void WhenIType(string email)
        {
            LoginPage.InputUsername(LoginPageLoc.registerWithEmailLocator,email);
        }

        [When(@"I type my new ""([^""]*)""")]
        public void WhenITypeMyNew(string password)
        {
            LoginPage.InputPassword(LoginPageLoc.registerPasswrodLocator,password);
        }

        [Then(@"I see success message")]
        public void ThenISeeSuccessMessage()
        {
            MyAccountPage.VerifyMyAccountMessageDisplayed(MyAccountPageLocators.myAccountMessageLocator);
        }
    }
}
