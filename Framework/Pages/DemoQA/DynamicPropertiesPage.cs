namespace Framework.Pages.DemoQA
{
    public class DynamicPropertiesPage
    {
        public static void open()
        {
            Driver.open(Constants.Urls.DemoQA.DynamicPropertiesPage);
        }
        public static void clickButtonEnabledAfter5Seconds()
        {
            string locator = "//*[@id='enableAfter']";
            Common.waitForElementToBeClickable(locator);
            Common.clickElement(locator);
        }
    }
}
