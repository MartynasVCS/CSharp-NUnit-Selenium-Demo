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

        public static void clickButtonThatChangesTextColor()
        {
            string locator = "//*[@id='colorChange']";
            string attributeName = "class";
            string attributeValue = "text-danger";
            Common.waitForElementAttributeToContainValue(locator, attributeName, attributeValue);
            Common.clickElement(locator);

        }
    }
}
