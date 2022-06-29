﻿namespace Framework.Pages.DemoQA
{
    public class RadioButtonPage
    {
        public static void open()
        {
            Driver.open(Constants.Urls.DemoQA.RadioButtonPage);
        }

        public static void clickYesRadioButton()
        {
            string locator = "//*[@for='yesRadio']";
            Common.clickElement(locator);
        }

        public static string getMessage()
        {
            string locator = "//*[@class='text-success']";
            return Common.getElementText(locator);
        }
    }
}
