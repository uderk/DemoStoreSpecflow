using DemoStoreSpecflowProject.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStoreSpecflowProject.Hooks
{
    [Binding]
    internal class TestSetUp
    {
        private readonly ScenarioContext scenarioContext;

        public TestSetUp( ScenarioContext scenarioContext) 
        {
             this.scenarioContext=scenarioContext;
        }

        [BeforeScenario]
        public void StartWebDriver()
        {
            WebDriverLibrary webDriverLibrary = new WebDriverLibrary(this.scenarioContext);
            scenarioContext.Set(webDriverLibrary, "WebDriverLibrary");
        }

        [AfterScenario]
        public void StopWebDriver()
        {
            this.scenarioContext.Get<IWebDriver>("WebDriver").Dispose();
        }
    }
}
