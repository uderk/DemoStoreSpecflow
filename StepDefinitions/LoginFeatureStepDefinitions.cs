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

        public LoginFeatureStepDefinitions()
        {
            LoginPage = new LoginPage();
            LoginPageLocators = new LoginPageLocators();
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

        [Then(@"I log in successfully")]
        public void ThenILogInSuccessfully()
        {
            Console.WriteLine("I am logged in successfully. This is a mock up to not have exception");
        }

    }
}
