using Framework;
using Framework.Pages.DemoQA;
using NUnit.Framework;

namespace Tests.DemoQA
{
    public class BrowserWindows
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demoqa.com/browser-windows");
        }

        [Test]
        public static void tabs()
        {
            // Variables
            string expectedParentTabHeader = "Browser Windows";
            string expectedNewTabHeader = "This is a sample page";
            string actualParentTabHeader;
            string actualNewTabHeader;
            string parentWindowHandle;
            string newWindowHandle;
            int actualWindowsCount;

            // Get parent window handle (getCurrentWindowHandle)
            parentWindowHandle = BrowserWindowsPage.getCurrentWindowHandle();
            actualWindowsCount = BrowserWindowsPage.getWindowsCount();
            Assert.AreEqual(1, actualWindowsCount);

            // Open new tab
            BrowserWindowsPage.clickNewTab();
            actualWindowsCount = BrowserWindowsPage.getWindowsCount();
            Assert.AreEqual(2, actualWindowsCount);

            // Switch to new tab
            BrowserWindowsPage.switchToNewWindowFromParentWindowByHandle(parentWindowHandle);
            newWindowHandle = BrowserWindowsPage.getCurrentWindowHandle();
            actualNewTabHeader = BrowserWindowsPage.readNewTabHeader();
            Assert.AreEqual(expectedNewTabHeader, actualNewTabHeader);

            // Switch to parent
            BrowserWindowsPage.switchToWindowByHandle(parentWindowHandle);
            actualParentTabHeader = BrowserWindowsPage.readParentTabHeader();
            Assert.AreEqual(expectedParentTabHeader, actualParentTabHeader);

            // Close new tab, switch to parent
            BrowserWindowsPage.closeWindowByHandle(newWindowHandle);
            BrowserWindowsPage.switchToWindowByHandle(parentWindowHandle);
            actualWindowsCount = BrowserWindowsPage.getWindowsCount();
            Assert.AreEqual(1, actualWindowsCount);
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
