using System;
using TechTalk.SpecFlow;
using DemoStoreSpecflowProject.PageObjects;
using DemoStoreSpecflowProject.PageObjects.Locators;

namespace DemoStoreSpecflowProject.StepDefinitions
{

    [Binding]
    public class LoginFeatureStepDefinitions
    {
        private LoginPage LoginPage;
        private LoginPageLocators LoginPageLocators;
        private MyAccountPage MyAccountPage;
        private MyAccountPageLocators MyAccountPageLocators;

        public LoginFeatureStepDefinitions()
        {
            LoginPage = new LoginPage();
            LoginPageLocators = new LoginPageLocators();
            MyAccountPage = new MyAccountPage();
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


        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            LoginPage.clickLoginButton(LoginPageLocators.logInButtonLocator, 8);
        }


        [When(@"I type my password")]
        public void WhenITypeMyPassword()
        {
            LoginPage.inputPassword(LoginPageLocators.passwordLoginLocator, "!77842590!Uderk", 10);
        }

        [Then(@"I see my account message displayed")]
        public void ThenISeeMyAccountMessageDisplayed()
        {
           MyAccountPage.VerifyMyAccountMessageDisplayed(MyAccountPageLocators.myAccountMessageLocator,10);
        }




    }
}
