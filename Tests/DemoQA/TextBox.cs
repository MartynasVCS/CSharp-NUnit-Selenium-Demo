using Framework.Pages.DemoQA;
using NUnit.Framework;
using Tests.BaseClasses;

namespace Tests.DemoQA
{
    public class TextBox : BaseTest
    {
        [SetUp]
        public static void openPage()
        {
            TextBoxPage.open();
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
    }
}
