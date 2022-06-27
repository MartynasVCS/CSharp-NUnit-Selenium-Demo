namespace Framework.Pages.SeleniumEasy
{
    public class BasicFirstFormDemoPage
    {
        public static void closeAdvertisement()
        {
            string locator = "//*[@id='at-cv-lightbox-close']";
            Common.waitForElementToBeVisible(locator);
            Common.clickElement(locator);
        }

        public static void enterMessage(string message)
        {
            string locator = "//*[@id='user-message']";
            Common.sendKeysToElement(locator, message);
        }

        public static void clickShowMessageButton()
        {
            string locator = "//*[@id='get-input']/button";
            Common.clickElement(locator);
        }

        public static string readMessage()
        {
            string locator = "//*[@id='display']";
            return Common.getElementText(locator);
        }
    }
}