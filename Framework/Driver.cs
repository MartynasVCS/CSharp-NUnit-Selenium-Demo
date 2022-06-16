using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public static class Driver
    {
        private static IWebDriver driver;

        public static void setDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }

        public static void open(string url)
        {
            driver.Url = url;
        }

        public static void closeDriver()
        {
            driver.Quit();
        }
    }
}
