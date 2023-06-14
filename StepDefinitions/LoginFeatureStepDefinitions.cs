using System;
using TechTalk.SpecFlow;
using DemoStoreSpecflowProject.PageObjects;
using DemoStoreSpecflowProject.PageObjects.Locators;
using OpenQA.Selenium;
using DemoStoreSpecflowProject.Support;

namespace DemoStoreSpecflowProject.StepDefinitions
{

    [Binding]
    public class LoginFeatureStepDefinitions
    {
        private LoginPage LoginPage;
        private LoginPageLocators LoginPageLocators;
        private MyAccountPage MyAccountPage;
        private MyAccountPageLocators MyAccountPageLocators;
        private IWebDriver driver;

        public LoginFeatureStepDefinitions()
        {
            driver = WebDriverManager.GetDriver();
            LoginPage = new LoginPage(driver);
            LoginPageLocators = new LoginPageLocators();
            MyAccountPage = new MyAccountPage(driver);
            MyAccountPageLocators = new MyAccountPageLocators();

        }

        [Given(@"I go to the login page")]
        public void GivenIGoToTheLoginPage()
        {
            LoginPage.GoToLoginPage();
        }

        [When(@"I type my username")]
        public void WhenITypeMyUsername()
        {
            Console.WriteLine("I do some shit here");
            LoginPage.inputUsername(LoginPageLocators.userNameLoginLocator, "venislav.zdravkov@gmail.com", 10);
        }

        [When(@"I type my password")]
        public void WhenITypeMyPassword()
        {
            LoginPage.inputPassword(LoginPageLocators.passwordLoginLocator, "!77842590!Uderk", 10);
        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            LoginPage.clickLoginButton(LoginPageLocators.logInButtonLocator, 10);
        }


        [Then(@"I log in successfully")]
        public void ThenILogInSuccessfully()
        {
            MyAccountPage.VerifyMyAccountMessageDisplayed(MyAccountPageLocators.myAccountMessageLocator, 10);
        }

    }
}
