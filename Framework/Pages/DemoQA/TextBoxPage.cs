namespace Framework.Pages.DemoQA
{
    public class TextBoxPage
    {
        public static void enterFullName(string name)
        {
            string locator = "//*[@id='userName']";
            Common.sendKeysToElement(locator, name);
        }

        public static void enterEmail(string email)
        {
            string locator = "//*[@id='userEmail']";
            Common.sendKeysToElement(locator, email);
        }

        public static void clickSubmitButton()
        {
            string locator = "//*[@id='submit']";
            Common.clickElement(locator);
        }

        public static string getNameAfterSubmit()
        {
            string locator = "//*[@id='name']";
            return Common.getElementText(locator);
        }

        public static string getEmailAfterSubmit()
        {
            string locator = "//*[@id='email']";
            return Common.getElementText(locator);
        }
    }
}
