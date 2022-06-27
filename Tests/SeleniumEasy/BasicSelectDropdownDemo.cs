using Framework;
using Framework.Pages.SeleniumEasy;
using NUnit.Framework;

namespace Tests.SeleniumEasy
{
    public class BasicSelectDropdownDemo
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://demo.seleniumeasy.com/basic-select-dropdown-demo.html");
        }

        [Test]
        public static void singleSelect()
        {
            string expectedDay = "Tuesday";
            string actualMessage;

            BasicSelectDropdownDemoPage.selectDayByValue(expectedDay);
            actualMessage = BasicSelectDropdownDemoPage.readSelectedDay();

            Assert.IsTrue(actualMessage.Contains(expectedDay), 
                $"Expected '{actualMessage}' to contain value: '{expectedDay}'");
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
