using System;
using TechTalk.SpecFlow;
using DemoStoreSpecflowProject.PageObjects;
using DemoStoreSpecflowProject.PageObjects.Locators;
using OpenQA.Selenium;
using DemoStoreSpecflowProject.Support;
using System.Runtime.CompilerServices;

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
        //private WebDriverManager DriverManager;


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
            LoginPage.InputUsername(LoginPageLocators.userNameLoginLocator, LoginPage.username);
        }

        [When(@"I type my password")]
        public void WhenITypeMyPassword()
        {
            LoginPage.InputPassword(LoginPageLocators.passwordLoginLocator, LoginPage.password);
        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            LoginPage.ClickLoginButton(LoginPageLocators.logInButtonLocator, 10);
        }


        [Then(@"I log in successfully")]
        public void ThenILogInSuccessfully()
        {
            MyAccountPage.VerifyMyAccountMessageDisplayed(MyAccountPageLocators.myAccountMessageLocator, 10);
        }



        [When(@"I type my non-exsiting user name ""([^""]*)""")]
        public void WhenITypeMyLoginName(string username)
        {
            LoginPage.InputUsername(LoginPageLocators.userNameLoginLocator, username);
        }

        [When(@"I type my non valid password ""([^""]*)""")]
        public void WhenITypeMyPassword(string nonValidPassword)
        {
            LoginPage.InputPassword(LoginPageLocators.userNameLoginLocator, nonValidPassword);
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            MyAccountPage.VerifyMyAccountMessageDisplayed(MyAccountPageLocators.myAccountErrorMessageInvalidUser);
        }

        [When(@"I type my username ""([^""]*)""")]
        public void WhenITypeMyUsername(string username)
        {
           LoginPage.InputUsername(LoginPageLocators.userNameLoginLocator,username);
        }

        [When(@"I type wrong password ""([^""]*)""")]
        public void WhenITypeWrongPassword(string wrongPassword)
        {
            LoginPage.InputPassword(LoginPageLocators.passwordLoginLocator, wrongPassword);
        }


    }
}
