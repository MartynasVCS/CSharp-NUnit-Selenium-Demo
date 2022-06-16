using Framework;
using Framework.Pages.DemoQA;
using NUnit.Framework;

namespace Tests.DemoQA
{
    public class TextBox
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demoqa.com/text-box");
        }

        [Test]
        public static void demoQaTextBox()
        {
            string expectedName = "Martynas";
            string expectedEmail = "email@email.com";

            TextBoxPage.enterFullName(expectedName);
            TextBoxPage.enterEmail(expectedEmail);
            TextBoxPage.clickSubmitButton();
            string actualName = TextBoxPage.getNameAfterSubmit();
            string actualEmail = TextBoxPage.getEmailAfterSubmit();

            Assert.IsTrue(actualName.Contains(expectedName));
            Assert.IsTrue(actualEmail.Contains(expectedEmail));
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
