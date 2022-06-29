using Framework.Pages.DemoQA;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests.DemoQA
{
    public class RadioButton : BaseTest
    {
        [SetUp]
        public void openPage()
        {
            RadioButtonPage.open();
        }

        [Test]
        public void radioButton()
        {
            string expectedMessage = "Yes";

            RadioButtonPage.clickYesRadioButton();
            string actualMessage = RadioButtonPage.getMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));
        }
    }
}
