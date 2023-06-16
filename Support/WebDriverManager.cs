using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace DemoStoreSpecflowProject.Support
{
    public static class WebDriverManager
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void CloseDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
