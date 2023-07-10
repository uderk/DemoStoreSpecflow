using DemoStoreSpecflowProject.Support;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace DemoStoreSpecflowProject.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private IWebDriver driver;
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
             driver = WebDriverManager.GetDriver();
        }


        [AfterScenario]
        public void AfterScenario()
        {
            {
                WebDriverManager.CloseDriver();
            }
        }
    }
}