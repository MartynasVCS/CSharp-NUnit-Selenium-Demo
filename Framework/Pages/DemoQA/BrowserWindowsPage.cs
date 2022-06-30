namespace Framework.Pages.DemoQA
{
    public class BrowserWindowsPage
    {
        public static string getCurrentWindowHandle()
        {
            return Common.getCurrentWindowHandle();
        }

        public static int getWindowsCount()
        {
            return Common.getCurrentWindowHandles().Count;
        }

        public static void clickNewTab()
        {
            string locator = "//*[@id='tabButton']";
            Common.clickElement(locator);
        }

        public static void switchToNewWindowFromParentWindowByHandle(string parentWindowHandle)
        {
            Common.switchToNewWindowFromParentWindowByHandle(parentWindowHandle);
        }

        public static string readNewTabHeader()
        {
            string locator = "//*[@id='sampleHeading']";
            return Common.getElementText(locator);
        }

        public static void switchToWindowByHandle(string handle)
        {
            Common.switchToWindowByHandle(handle);
        }

        public static string readParentTabHeader()
        {
            string locator = "//*[@class='main-header']";
            return Common.getElementText(locator);
        }

        public static void closeWindowByHandle(string handle)
        {
            Common.closeWindowByHandle(handle);
        }
    }
}
