using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;

namespace Tests.SeleniumEasy
{
    public class BasicCheckboxDemo
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        [Test]
        public static void singleCheckbox()
        {
            string expectedMessage = "Success - Check box is checked";
            string actualMessage;

            BasicCheckboxDemoPage.clickSingleCheckbox();
            actualMessage = BasicCheckboxDemoPage.readMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
