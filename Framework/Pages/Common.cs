using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Framework.Pages
{
    internal class Common
    {
        internal static IWebElement getElement(string locator)
        {
            return Driver.getDriver().FindElement(By.XPath(locator));
        }

        internal static void alertAccept()
        {
            Driver.getDriver().SwitchTo().Alert().Accept();
        }

        internal static void selectOptionByValue(string locator, string value)
        {
            IWebElement element = getElement(locator);
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }

        internal static void sendKeysToAlert(string keys)
        {
            Driver.getDriver().SwitchTo().Alert().SendKeys(keys);
            alertAccept();
        }

        internal static void performRightClick(string locator)
        {
            IWebElement element = getElement(locator);
            Actions actions = new Actions(Driver.getDriver());

            actions.ContextClick(element);
            actions.Perform();
        }

        internal static void alertDismiss()
        {
            Driver.getDriver().SwitchTo().Alert().Dismiss();
        }

        internal static void performDoubleClick(string locator)
        {
            IWebElement element = getElement(locator);
            Actions actions = new Actions(Driver.getDriver());

            actions.DoubleClick(element);
            actions.Perform();
        }

        internal static void sendKeysToElement(string locator, string keys)
        {
            getElement(locator).SendKeys(keys);
        }

        internal static void clickElement(string locator)
        {
            getElement(locator).Click();
        }

        internal static string getElementText(string locator)
        {
            return getElement(locator).Text;
        }

        internal static void waitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void waitForElementToBeInvisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(locator)));
        }

        internal static void waitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }

        internal static void waitForElementAttributeToContainValue(string locator, string attributeName, string attributeValue)
        {
            new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10))
               .Until(d => d.FindElement(By.XPath(locator)).GetAttribute(attributeName).Contains(attributeValue));
        }
    }
}
