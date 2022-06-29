using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;

namespace Tests.SeleniumEasy
{
    public class JavascriptAlerts
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demo.seleniumeasy.com/javascript-alert-box-demo.html");
        }

        [Test]
        public static void acceptAlertBox()
        {
            JavascriptAlertsPage.clickButtonToOpenAlertBox();
            JavascriptAlertsPage.clickOkInAlertBox();

            // Assert ?! :/
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
