using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Pages
{
    internal class Common
    {
        internal static IWebElement getElement(string locator)
        {
            return Driver.getDriver().FindElement(By.XPath(locator));
        }

        internal static List<string> getCurrentWindowHandles()
        {
            return Driver.getDriver().WindowHandles.ToList();
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

        internal static void switchToNewWindowFromParentWindowByHandle(string parentWindowHandle)
        {
            List<string> handles = getCurrentWindowHandles();
            foreach (string handle in handles)
            {
                if (handle != parentWindowHandle)
                {
                    Common.switchToWindowByHandle(handle);
                }
            }
        }

        internal static void switchToWindowByHandle(string handle)
        {
            Driver.getDriver().SwitchTo().Window(handle);
        }

        internal static void closeWindowByHandle(string handle)
        {
            Driver.getDriver().SwitchTo().Window(handle).Close();
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

        internal static string getCurrentWindowHandle()
        {
            return Driver.getDriver().CurrentWindowHandle;
        }
    }
}
