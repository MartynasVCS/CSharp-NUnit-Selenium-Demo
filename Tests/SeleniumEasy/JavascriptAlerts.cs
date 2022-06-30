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

        [Test]
        public static void promptBoxSendKeys()
        {
            string expectedKeys = "Labas";
            string actualMessage;

            JavascriptAlertsPage.clickButtonToOpenPromptBox();
            JavascriptAlertsPage.sendKeysToPromptBox(expectedKeys);
            actualMessage = JavascriptAlertsPage.readPromptBoxMessage();

            Assert.IsTrue(actualMessage.Contains(expectedKeys));
        }

        [Test]
        public static void promptBoxAcceptDefaultKeys()
        {
            string expectedDefaultKeys = "Enter name";
            string actualMessage;

            JavascriptAlertsPage.clickButtonToOpenPromptBox();
            JavascriptAlertsPage.clickOkInPromptBox();
            actualMessage = JavascriptAlertsPage.readPromptBoxMessage();

            Assert.IsTrue(actualMessage.Contains(expectedDefaultKeys));
        }

        [Test]
        public static void promptBoxDismiss()
        {
            string expectedMessage = "";
            string actualMessage;

            JavascriptAlertsPage.clickButtonToOpenPromptBox();
            JavascriptAlertsPage.clickCancelInPromptBox();
            actualMessage = JavascriptAlertsPage.readPromptBoxMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
