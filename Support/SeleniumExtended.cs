using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace DemoStoreSpecflowProject.Support
{
    public  class SeleniumExtended
    {
        private  IWebDriver driver;
        private  int defaultTimeout;

        public  SeleniumExtended(IWebDriver driver, int defaultTimeout = 10)
        {
            this.driver = driver;
            this.defaultTimeout = defaultTimeout;
        }

        public void InputText(By locator, string text, int? timeout = null)
        {
            int timeoutValue = timeout ?? defaultTimeout;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutValue));
            wait.Until(ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);
        }

        public void ClickButton(By locator, int? timeout = null)
        {
            int timeoutValue = timeout ?? defaultTimeout;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutValue));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

        public void WaitUntilElementIsDisplayed(By locator, int? timeout = null)
        {
            int timeoutValue = timeout ?? defaultTimeout;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutValue));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));

        }

        public void CheckIfElementIsNotDisplayed(By locator, int? timeout = null)
        {
            int timeoutValue = timeout ?? defaultTimeout;
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutValue));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Element is present in the DOM.");
            }

        }
    }
}
