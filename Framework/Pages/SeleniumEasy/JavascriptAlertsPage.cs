namespace Framework.Pages.SeleniumEasy
{
    public class JavascriptAlertsPage
    {
        public static void clickButtonToOpenAlertBox()
        {
            string locator = "//*[@onclick='myAlertFunction()']";
            Common.clickElement(locator);
        }

        public static void clickOkInAlertBox()
        {
            Common.alertAccept();
        }

        public static void clickButtonToOpenPromptBox()
        {
            string locator = "//*[@onclick='myPromptFunction()']";
            Common.clickElement(locator);
        }

        public static void sendKeysToPromptBox(string keys)
        {
            Common.sendKeysToAlert(keys);
        }

        public static string readPromptBoxMessage()
        {
            string locator = "//*[@id='prompt-demo']";
            return Common.getElementText(locator);
        }

        public static void clickOkInPromptBox()
        {
            Common.alertAccept();
        }

        public static void clickCancelInPromptBox()
        {
            Common.alertDismiss();
        }
    }
}
