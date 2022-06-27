namespace Framework.Pages.DemoQA
{
    public class ButtonsPage
    {
        public static void leftClick()
        {
            string locator = "//*[text()='Click Me']";
            Common.clickElement(locator);
        }

        public static string readMessageLeftClick()
        {
            string locator = "//*[@id='dynamicClickMessage']";
            return Common.getElementText(locator);
        }
    }
}
