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

        [Test]
        public static void multipleCheckbox()
        {
            string expectedButtonCheckedText = "Uncheck All";
            string expectedButtonUncheckedText = "Check All";
            string actualButtonText;

            // Click button and check button text
            BasicCheckboxDemoPage.clickMultiCheckboxButton();
            actualButtonText = BasicCheckboxDemoPage.readButtonText();
            Assert.AreEqual(expectedButtonCheckedText, actualButtonText);

            // Check status of all checkboxes
            bool actualStatus = BasicCheckboxDemoPage.checkIfAllCheckboxesAreSelected();
            Assert.AreEqual(true, actualStatus);

            // Click button and check button text
            BasicCheckboxDemoPage.clickMultiCheckboxButton();
            actualButtonText = BasicCheckboxDemoPage.readButtonText();
            Assert.AreEqual(expectedButtonUncheckedText, actualButtonText);

            // Check status of all checkboxes
            actualStatus = BasicCheckboxDemoPage.checkIfAllCheckboxesAreNotSelected();
            Assert.AreEqual(true, actualStatus);
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
