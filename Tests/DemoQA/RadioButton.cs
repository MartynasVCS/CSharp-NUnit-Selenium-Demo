using Framework;
using Framework.Pages.DemoQA;
using NUnit.Framework;

namespace Tests.DemoQA
{
    public class RadioButton
    {
        [OneTimeSetUp]
        public void setup()
        {

            Driver.setDriver();
            Driver.open("https://demoqa.com/radio-button");
        }

        [Test]
        public void radioButton()
        {
            string expectedMessage = "Yes";

            RadioButtonPage.clickYesRadioButton();
            string actualMessage = RadioButtonPage.getMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));
        }

        [OneTimeTearDown]
        public void close()
        {
            Driver.closeDriver();
        }
    }
}
