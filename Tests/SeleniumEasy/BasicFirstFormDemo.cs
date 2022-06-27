using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;

namespace Tests.SeleniumEasy
{
    public class BasicFirstFormDemo
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demo.seleniumeasy.com/basic-first-form-demo.html");
            BasicFirstFormDemoPage.closeAdvertisement();
        }

        [Test]
        public static void singleInputField()
        {
            string expectedMessage = "Test";
            string actualMessage;

            BasicFirstFormDemoPage.enterMessage(expectedMessage);
            BasicFirstFormDemoPage.clickShowMessageButton();
            actualMessage = BasicFirstFormDemoPage.readMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}