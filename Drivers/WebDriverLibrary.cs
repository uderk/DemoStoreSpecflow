using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStoreSpecflowProject.Drivers
{
    internal class WebDriverLibrary
    {
        private readonly ScenarioContext scenarioContext;
        private readonly IWebDriver driver;

        public WebDriverLibrary (ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
           // this.driver = driver;
        }

        public IWebDriver Setup(string browserName)
        {
            dynamic capability = GetBrowserOptions(browserName);
            IWebDriver driver;

            if (browserName.Equals("firefox", StringComparison.OrdinalIgnoreCase))
            {
                driver = new FirefoxDriver(capability);
            }
            else if (browserName.Equals("chrome", StringComparison.OrdinalIgnoreCase))
            {
                driver = new ChromeDriver(capability);
            }
            else if (browserName.Equals("edge", StringComparison.OrdinalIgnoreCase))
            {
                driver = new EdgeDriver(capability);
            }
            else
            {
                // Add handling for other browsers if needed
                throw new NotSupportedException($"Browser '{browserName}' is not supported.");
            }

            this.scenarioContext.Set(driver, "WebDriver");
            return driver;
        }


        private dynamic GetBrowserOptions(string browserName)
        {
            switch (browserName.ToLower())
            {
                case "chrome":
                    return new ChromeOptions();
                case "firefox":
                    return new FirefoxOptions();
                case "Edge": 
                    return new EdgeOptions();
                default: return new ChromeOptions();
            }

        }
    }
}
