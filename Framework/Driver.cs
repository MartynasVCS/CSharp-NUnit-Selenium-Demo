using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Framework
{
    public static class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void setDriver()
        {
            driver.Value = new ChromeDriver();
            driver.Value.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public static IWebDriver getDriver()
        {
            return driver.Value;
        }

        public static void open(string url)
        {
            driver.Value.Url = url;
        }

        public static void closeDriver()
        {
            driver.Value.Quit();
        }
    }
}
